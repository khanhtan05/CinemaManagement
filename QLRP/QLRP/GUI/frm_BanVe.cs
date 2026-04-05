using QLRP.BUS;
using QLRP.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLRP.GUI
{
    public partial class frm_BanVe : Form
    {
        // Điều khiển Slide
        private Timer slideTimer = new Timer();
        private int targetX = 0;
        private const int STEP = 210;

        // Dữ liệu nghiệp vụ
        private int currentMaSuatChieu;
        private decimal currentGiaVe;
        private int currentMaPhim;
        private List<string> selectedSeats = new List<string>();

        public frm_BanVe()
        {
            InitializeComponent();
            SetupSlider();
        }

        private void frm_BanVe_Load(object sender, EventArgs e)
        {
            if (btn_Next.Image != null)
                btn_Next.Image = ColorFilter(btn_Next.Image, Color.White);

            if (btn_Prev.Image != null)
                btn_Prev.Image = ColorFilter(btn_Prev.Image, Color.White);
            if (btn_Pay.Image != null)
                btn_Pay.Image = ColorFilter(btn_Pay.Image, Color.White);
            LoadMoviesToUI();
        }
        public Image ColorFilter(Image image, Color color)
        {
            Bitmap bmp = new Bitmap(image);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color oldColor = bmp.GetPixel(x, y);
                    // Chỉ đổi màu những điểm ảnh không trong suốt (Alpha > 0)
                    if (oldColor.A > 0)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(oldColor.A, color.R, color.G, color.B));
                    }
                }
            }
            return bmp;
        }

        private void SetupSlider()
        {
            slideTimer.Interval = 10;
            slideTimer.Tick += SlideTimer_Tick;

            // Cấu hình Panel để trượt mượt mà
            pnl_Movie.Parent = pnl_Slide;
            pnl_Movie.Location = new Point(0, 0);
            pnl_Movie.Dock = DockStyle.None;
            pnl_Slide.AutoScroll = false;

            // Đảm bảo nút điều hướng không bị che
            btn_Next.BringToFront();
            btn_Prev.BringToFront();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            int speed = 35;
            if (Math.Abs(pnl_Movie.Left - targetX) > speed)
            {
                pnl_Movie.Left += (targetX > pnl_Movie.Left) ? speed : -speed;
            }
            else
            {
                pnl_Movie.Left = targetX;
                slideTimer.Stop();
            }
        }

        // --- XỬ LÝ TRƯỢT PHIM SÁT LỀ ---
        private void btn_Next_Click1(object sender, EventArgs e)
        {
            
        }

      
        // --- TẢI DANH SÁCH PHIM ---
        void LoadMoviesToUI()
        {
            pnl_Movie.Controls.Clear();

            // Câu lệnh SQL JOIN để lấy tên thể loại từ bảng TheLoai
            string query = @"SELECT p.MaPhim, p.TenPhim, p.Poster, p.ThoiLuong, t.TenTheLoai 
                     FROM Phim p 
                     INNER JOIN TheLoai t ON p.MaTheLoai = t.MaTheLoai";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            int xPos = 0;
            foreach (DataRow row in data.Rows)
            {
                // Khởi tạo ucMovie với đầy đủ tham số mới
                ucMovie movieCard = new ucMovie(
                    (int)row["MaPhim"],
                    row["TenPhim"].ToString(),
                    row["Poster"].ToString(),
                    row["TenTheLoai"].ToString(),
                    (int)row["ThoiLuong"]
                );

                // Gán Tag để tránh lỗi NullReferenceException khi load ảnh
                movieCard.Tag = row["Poster"].ToString();
                movieCard.Location = new Point(xPos, 0);

                // Đăng ký sự kiện khi click vào phim
                movieCard.OnSelectPhim += (s, ev) => {
                    ucMovie selected = s as ucMovie;
                    if (selected != null)
                    {
                        lbl_SelectedMovie.Text = "Phim: " + selected.TenPhim;
                        lbl_TheLoai.Text = "Thể loại: " + selected.TenTheLoai;
                        lbl_ThoiLuong.Text = "Thời lượng: " + selected.ThoiLuong + " phút";
                        currentMaPhim = selected.MaPhim; // Lưu lại mã phim

                        DisplayMoviePoster(selected.Tag?.ToString());

                        // Nạp danh sách suất chiếu vào ComboBox
                        LoadComboBoxSuatChieu(selected.MaPhim);

                        // Tự động load sơ đồ ghế của suất chiếu đầu tiên trong danh sách (nếu có)
                        if (cbb_SuatChieu.SelectedValue != null && int.TryParse(cbb_SuatChieu.SelectedValue.ToString(), out int firstSC))
                        {
                            LoadSeatsByMovie(firstSC);
                        }
                        else
                        {
                            flpSeatMap.Controls.Clear();
                            MessageBox.Show("Phim này hiện không có suất chiếu nào!");
                        }
                    }
                };

                pnl_Movie.Controls.Add(movieCard);
                xPos += 210; // Khoảng cách giữa các phim
            }
            pnl_Movie.Width = xPos;
        }

        // --- HIỂN THỊ THÔNG TIN & POSTER ---
        private void DisplayMoviePoster(string posterName)
        {
            if (string.IsNullOrEmpty(posterName)) return;

            try
            {
                string path = Path.Combine(Application.StartupPath, "Posters", posterName);
                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        // Giải phóng bộ nhớ ảnh cũ trước khi nạp ảnh mới
                        if (pt_SelectedMoviePoster.Image != null)
                            pt_SelectedMoviePoster.Image.Dispose();

                        pt_SelectedMoviePoster.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    pt_SelectedMoviePoster.Image = null; // Hoặc ảnh mặc định nếu không tìm thấy file
                }
            }
            catch
            {
                pt_SelectedMoviePoster.Image = null;
            }
        }

        // --- XỬ LÝ SƠ ĐỒ GHẾ ---
        // --- XỬ LÝ SƠ ĐỒ GHẾ ---
        void LoadSeatsByMovie(int maSC)
        {
            // 1. Dọn dẹp giao diện cũ và reset thông tin
            flpSeatMap.Controls.Clear();
            selectedSeats.Clear();
            currentMaSuatChieu = maSC; // Gán mã suất chiếu hiện tại để dùng khi thanh toán
            lbl_SeatsList.Text = "Ghế: Chưa chọn";
            lbl1.Text = "0 VNĐ";

            // 2. Lấy thông tin giá vé và mã phòng của suất chiếu này
            string queryInfo = @"SELECT GiaVe, MaPhong FROM SuatChieu WHERE MaSuatChieu = @maSC";
            DataTable dtInfo = DataProvider.Instance.ExecuteQuery(queryInfo, new object[] { maSC });

            if (dtInfo.Rows.Count > 0)
            {
                currentGiaVe = Convert.ToDecimal(dtInfo.Rows[0]["GiaVe"]);
                int maPhong = (int)dtInfo.Rows[0]["MaPhong"];

                // 3. Truy vấn danh sách ghế của phòng và kiểm tra xem ghế nào đã được bán (TrangThai = 1)
                string querySeats = @"SELECT g.MaGhe, g.TenGhe, ISNULL(v.TrangThai, 0) AS TrangThai 
                      FROM Ghe g
                      LEFT JOIN Ve v ON g.MaGhe = v.MaGhe AND v.MaSuatChieu = @maSC
                      WHERE g.MaPhong = @maPhong
                      ORDER BY LEN(g.TenGhe), g.TenGhe ASC";

                DataTable dataSeats = DataProvider.Instance.ExecuteQuery(querySeats, new object[] { maSC, maPhong });

                foreach (DataRow row in dataSeats.Rows)
                {
                    Button btnSeat = new Button
                    {
                        Width = 55,
                        Height = 55,
                        Text = row["TenGhe"].ToString(),
                        Tag = row, // Lưu dòng dữ liệu để lấy MaGhe nhanh nếu cần
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand,
                        Margin = new Padding(5)
                    };

                    int status = Convert.ToInt32(row["TrangThai"]);

                    if (status == 1) // Ghế đã bán (Đỏ)
                    {
                        btnSeat.BackColor = Color.FromArgb(231, 76, 60);
                        btnSeat.ForeColor = Color.White;
                        btnSeat.Enabled = false;
                    }
                    else // Ghế trống (Trắng)
                    {
                        btnSeat.BackColor = Color.FromArgb(236, 240, 241);
                        btnSeat.Click += BtnSeat_Click; // Gán sự kiện click chọn ghế
                    }

                    flpSeatMap.Controls.Add(btnSeat);
                }
            }
        }
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seatName = btn.Text;

            // Nếu đang màu trắng (chưa chọn) -> Đổi sang màu vàng (đang chọn)
            if (btn.BackColor == Color.FromArgb(236, 240, 241))
            {
                btn.BackColor = Color.FromArgb(241, 196, 15);
                selectedSeats.Add(seatName);
            }
            // Nếu đang màu vàng (hủy chọn) -> Đổi về màu trắng
            else
            {
                btn.BackColor = Color.FromArgb(236, 240, 241);
                selectedSeats.Remove(seatName);
            }

            UpdateSeatInfoUI(); // Cập nhật Label tổng tiền và danh sách ghế
        }

        // Hàm cập nhật Label tên ghế và Tổng tiền
        private void UpdateSeatInfoUI()
        {
            if (selectedSeats.Count > 0)
                lbl_SeatsList.Text = "Ghế đã chọn: " + string.Join(", ", selectedSeats);
            else
                lbl_SeatsList.Text = "Ghế: Chưa chọn";

            lbl1.Text = string.Format("{0:N0} VNĐ", selectedSeats.Count * currentGiaVe);
        }

        private void GenerateSeats()
        {
            // Code tạo Button ghế và xử lý sự kiện click đổi màu vàng
            // Khi click ghế, cập nhật: 
            // lbl_SeatsList.Text = "Ghế: " + string.Join(", ", selectedSeats);
            // UpdateTotalAmount();
        }
        private int GetMaGheFromName(string seatName)
        {
            // Truy vấn lấy MaGhe dựa trên tên ghế và suất chiếu hiện tại
            string query = @"SELECT g.MaGhe FROM Ghe g 
                     JOIN SuatChieu sc ON g.MaPhong = sc.MaPhong 
                     WHERE g.TenGhe = @tenGhe AND sc.MaSuatChieu = @maSC";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { seatName, currentMaSuatChieu });

            return result != null ? Convert.ToInt32(result) : 0;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            // Code thanh toán giữ nguyên theo logic cũ của bạn
        }

        private void lbl_ThoiLuong_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            ucMovie prevMovie = null;
            int currentViewedX = Math.Abs(targetX);

            for (int i = pnl_Movie.Controls.Count - 1; i >= 0; i--)
            {
                if (pnl_Movie.Controls[i] is ucMovie movie && movie.Left < currentViewedX - 10)
                {
                    prevMovie = movie;
                    break;
                }
            }

            targetX = (prevMovie != null) ? -prevMovie.Left : 0;
            slideTimer.Start();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            ucMovie nextMovie = null;
            int currentViewedX = Math.Abs(targetX);

            foreach (Control ct in pnl_Movie.Controls)
            {
                if (ct is ucMovie movie && movie.Left > currentViewedX + 10)
                {
                    nextMovie = movie;
                    break;
                }
            }

            if (nextMovie != null)
            {
                targetX = -nextMovie.Left;
                slideTimer.Start();
            }
        }

        private void btn_Pay_Click_1(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0) return;

            try
            {
                // 1. Tạo một hóa đơn chung duy nhất
                object resHoaDon = DataProvider.Instance.ExecuteScalar("EXEC USP_CreateEmptyBill @MaNV , @MaKH", new object[] { 1, 1 });
                int maHoaDonChung = Convert.ToInt32(resHoaDon);

                // 2. Lặp để thêm từng ghế vào hóa đơn đó
                foreach (string seatName in selectedSeats)
                {
                    int maGhe = GetMaGheFromName(seatName);

                    DataProvider.Instance.ExecuteNonQuery("EXEC USP_AddTicketToBill @MaHD , @MaSC , @MaGhe , @Gia",
                        new object[] { maHoaDonChung, currentMaSuatChieu, maGhe, currentGiaVe });
                }

                // 3. Hiển thị hóa đơn chung (Lúc này tổng tiền sẽ tự cập nhật nhờ Trigger)
                MessageBox.Show("Thanh toán thành công!");
                frm_HoaDon frm = new frm_HoaDon();
                frm.LoadTicketDetails(maHoaDonChung);
                frm.ShowDialog();

                LoadSeatsByMovie(currentMaPhim);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SeatsList_Click(object sender, EventArgs e)
        {

        }

        private void cbb_Phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_SuatChieu.SelectedValue != null && int.TryParse(cbb_SuatChieu.SelectedValue.ToString(), out int maSC))
            {
                LoadSeatsByMovie(maSC); // Hàm này giờ nhận vào mã suất chiếu để vẽ ghế
            }
        }
        void LoadComboBoxSuatChieu(int maPhim)
        {
            DataTable dt = BUS_SuatChieu.Instance.GetSuatChieuByMaPhim(maPhim);

            if (dt.Rows.Count > 0)
            {
                cbb_SuatChieu.DataSource = dt;
                // Cột này chứa chuỗi "18:00 (Phòng 1)" đã tạo ở bước trên
                cbb_SuatChieu.DisplayMember = "ThongTinSuatChieu";
                // Cột này chứa mã số để code xử lý bên dưới
                cbb_SuatChieu.ValueMember = "MaSuatChieu";
            }
            else
            {
                cbb_SuatChieu.DataSource = null;
                cbb_SuatChieu.Items.Clear();
                cbb_SuatChieu.Text = "Không có suất chiếu";
            }
        }

        private void pnl_Movie_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}