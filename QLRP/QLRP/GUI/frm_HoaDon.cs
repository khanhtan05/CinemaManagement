using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QLRP.GUI
{
    public partial class frm_HoaDon : Form
    {
        private object dt;

        public frm_HoaDon()
        {
            InitializeComponent();
            // Đăng ký sự kiện vẽ đường răng cưa cho Panel vé
            pnl_Ticket.Paint += Pnl_Ticket_Paint;
        }

        private void Pnl_Ticket_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 2);
            pen.DashStyle = DashStyle.Dash;

            // Vẽ đường xé vé giả lập ở 3/4 chiều cao của panel
            int y = (pnl_Ticket.Height / 4) * 3;
            g.DrawLine(pen, 10, y, pnl_Ticket.Width - 10, y);

            // Vẽ 2 hình bán nguyệt ở 2 đầu đường kẻ để tạo hiệu ứng vé bị bấm lỗ
            g.FillEllipse(Brushes.DarkSlateBlue, -15, y - 15, 30, 30); // Màu khớp với Background Form
            g.FillEllipse(Brushes.DarkSlateBlue, pnl_Ticket.Width - 15, y - 15, 30, 30);
        }

        // Truy vấn SQL lấy thông tin chi tiết để đổ vào vé
        public void LoadTicketDetails(int maHoaDon)
        {
            // Câu lệnh SQL này lấy tổng tiền từ HoaDon và gộp tên các ghế lại thành 1 chuỗi
            string query = @"SELECT hd.MaHoaDon, p.TenPhim, sc.GioBatDau, pc.TenPhong, hd.TongTien, nv.TenNhanVien,
                     (SELECT STRING_AGG(g2.TenGhe, ', ') 
                      FROM ChiTietHoaDon cthd2 
                      JOIN Ve v2 ON cthd2.MaVe = v2.MaVe 
                      JOIN Ghe g2 ON v2.MaGhe = g2.MaGhe 
                      WHERE cthd2.MaHoaDon = hd.MaHoaDon) AS DanhSachGhe
                     FROM HoaDon hd
                     JOIN ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon
                     JOIN Ve v ON cthd.MaVe = v.MaVe
                     JOIN SuatChieu sc ON v.MaSuatChieu = sc.MaSuatChieu
                     JOIN Phim p ON sc.MaPhim = p.MaPhim
                     JOIN PhongChieu pc ON sc.MaPhong = pc.MaPhong
                     JOIN NhanVien nv ON hd.MaNhanVien = nv.MaNhanVien
                     WHERE hd.MaHoaDon = @maHoaDon";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maHoaDon });

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                lbl_TicketID.Text = "No: " + r["MaHoaDon"].ToString();
                lbl_MovieName.Text = r["TenPhim"].ToString().ToUpper();

                // Bây giờ cột GioBatDau đã tồn tại trong query, sẽ không còn lỗi hình 2
                lbl_Date.Text = Convert.ToDateTime(r["GioBatDau"]).ToString("dd/MM/yyyy");
                lbl_Time.Text = Convert.ToDateTime(r["GioBatDau"]).ToString("HH:mm");

                lbl_Room.Text = r["TenPhong"].ToString();
                lbl_Seat.Text = r["DanhSachGhe"].ToString(); // Hiển thị "G1, G2" thay vì chỉ 1 ghế
                lbl_Price.Text = string.Format("{0:N0} VNĐ", r["TongTien"]); // Sẽ hiện đúng 180,000 VNĐ
                lbl_Staff.Text = "Nhân Viên: " + r["TenNhanVien"].ToString();
            }
        }

        private void btn_PrintTicket_Click(object sender, EventArgs e)
        {
            // Sử dụng PrintDialog để in nội dung pnl_Ticket ra máy in nhiệt
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                // Logic in ấn tại đây...
                MessageBox.Show("Đang gửi lệnh tới máy in...", "In vé thành công");
            }
        }
  

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
       
        }

        private void btn_PrintTicket_Click_1(object sender, EventArgs e)
        {
            try
            {
                // FIX 1: Lấy số ID từ chuỗi "No: 7" -> kết quả là "7"
                string maHD = lbl_TicketID.Text.Replace("No: ", "").Trim();

                // FIX 2: Thêm từ khóa WHERE và cấu trúc JOIN chuẩn để lấy đủ thông tin in vé
                // Lưu ý: Tên cột phải khớp với tên trong file .rdlc của bạn
                string query = $@"SELECT hd.MaHoaDon as [MaHoaDon], nv.TenNhanVien as [NhanVien], p.TenPhim as [TenPhim], 
                          sc.GioBatDau as [NgayChieu], sc.GioBatDau as [SuatChieu], 
                          pc.TenPhong as [PhongChieu], hd.TongTien as [GiaVe], (SELECT STRING_AGG(g2.TenGhe, ', ') 
                          FROM ChiTietHoaDon cthd2 
                          JOIN Ve v2 ON cthd2.MaVe = v2.MaVe 
                          JOIN Ghe g2 ON v2.MaGhe = g2.MaGhe 
                          WHERE cthd2.MaHoaDon = hd.MaHoaDon) AS [Ghe]
                          FROM HoaDon hd
                          JOIN NhanVien nv ON hd.MaNhanVien = nv.MaNhanVien
                          JOIN ChiTietHoaDon cthd ON hd.MaHoaDon = cthd.MaHoaDon
                          JOIN Ve v ON cthd.MaVe = v.MaVe
                          JOIN SuatChieu sc ON v.MaSuatChieu = sc.MaSuatChieu
                          JOIN Phim p ON sc.MaPhim = p.MaPhim
                          JOIN PhongChieu pc ON sc.MaPhong = pc.MaPhong
                          WHERE hd.MaHoaDon = {maHD}";

                // FIX 3: Khai báo DataTable ngay tại đây để hết lỗi "The name 'dt' does not exist"
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {
                    frm_Ticket f = new frm_Ticket();

                    // FIX 4: Đảm bảo "DataSet1" trùng với tên trong file RDLC
                    ReportDataSource rds = new ReportDataSource("DataSet1", dataTable);

                    f.rpt_TK.LocalReport.DataSources.Clear();
                    f.rpt_TK.LocalReport.DataSources.Add(rds);

                    // FIX 5: Kiểm tra tên file .rdlc của bạn là rpt_Ticket hay rpt_DoanhThu
                    f.rpt_TK.LocalReport.ReportPath = Application.StartupPath + @"\rpt_Ticket.rdlc";

                    f.rpt_TK.RefreshReport();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho hóa đơn số: " + maHD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi SQL: " + ex.Message);
            }
        }
    }
}