using QLRP.BUS; // Gọi BUS vào
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP.GUI
{
    public partial class frm_Phim : Form
    {
        string currentPosterName = "default.jpg";
        string selectedImagePath = "";

        public frm_Phim()
        {
            InitializeComponent();
        }

        private void frm_Phim_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhim();
            // Hàm LoadTheLoai() gọi từ TheLoaiDAO...
            LoadTheLoai();
        }

        void LoadDanhSachPhim()
        {
            // GỌI QUA LỚP BUS
            dgv_Phim.DataSource = BUS_Phim.Instance.GetListPhim();
            dgv_Phim.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgv_Phim.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgv_Phim.Columns["ThoiLuong"].HeaderText = "Thời Lượng";
            dgv_Phim.Columns["NgayKhoiChieu"].HeaderText = "Ngày Khởi Chiếu";
            dgv_Phim.Columns["MoTa"].HeaderText = "Mô Tả";
            if (dgv_Phim.Columns.Contains("Poster"))
            {
                dgv_Phim.Columns["Poster"].Visible = false;
            }

            // Bạn cũng có thể ẩn luôn cột MaTheLoai nếu muốn giao diện sạch hơn
            if (dgv_Phim.Columns.Contains("MaTheLoai"))
            {
                dgv_Phim.Columns["MaTheLoai"].Visible = false;
            }
        }

        // ================= XỬ LÝ ẢNH =================

        private void SaveImageToFolder()
        {
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                string appPath = Path.Combine(Application.StartupPath, "Posters");
                if (!Directory.Exists(appPath)) Directory.CreateDirectory(appPath);

                string destPath = Path.Combine(appPath, currentPosterName);
                if (!File.Exists(destPath)) File.Copy(selectedImagePath, destPath);
            }
        }

        // ================= CÁC NÚT CHỨC NĂNG =================
        private void LoadTheLoai()
        {
            // Lấy dữ liệu từ DB (Gọi hàm ở Bước 1)
            DataTable dt = BUS_TheLoai.Instance.GetListTheLoai(); // (Hoặc code gọi DB của bạn)

            cbb_TheLoai.DataSource = dt;

            // ĐỔI DÒNG NÀY: Hiện ra ngoài màn hình chuỗi "1 - Hành động"
            cbb_TheLoai.DisplayMember = "TenHienThi";

            // GIỮ NGUYÊN DÒNG NÀY: Vẫn giấu mã ID (1, 2, 3...) ở bên dưới để lưu vào Database
            cbb_TheLoai.ValueMember = "MaTheLoai";
        }




        private void dgv_Phim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Phim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào một dòng hợp lệ không (tránh click vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy ra dòng đang được chọn
                DataGridViewRow row = dgv_Phim.Rows[e.RowIndex];

                // 1. Đổ dữ liệu text vào khung bên trái
                txt_MaPhim.Text = row.Cells["MaPhim"].Value.ToString();
                txt_TenPhim.Text = row.Cells["TenPhim"].Value.ToString();
                txt_ThoiLuong.Text = row.Cells["ThoiLuong"].Value.ToString();
                dtp_NgayKhoiChieu.Value = Convert.ToDateTime(row.Cells["NgayKhoiChieu"].Value);
                txt_MoTa.Text = row.Cells["MoTa"].Value.ToString();

                // Nếu bạn giữ bảng Thể Loại riêng (mô hình 3 lớp):
                cbb_TheLoai.SelectedValue = row.Cells["MaTheLoai"].Value;

                // 2. Xử lý load lại ảnh Poster lên góc trái
                currentPosterName = row.Cells["Poster"].Value.ToString();
                string path = Path.Combine(Application.StartupPath, "Posters", currentPosterName);

                // Kiểm tra xem file ảnh có tồn tại trong máy không để tránh lỗi văng app
                if (File.Exists(path))
                {
                    pb_Poster.Image = Image.FromFile(path);
                }
                else
                {
                    pb_Poster.Image = null; // Hoặc bạn có thể gán 1 ảnh mặc định như Image.FromFile("default.jpg")
                }
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Phim.Rows[e.RowIndex];

                // --- Giữ nguyên phần đổ dữ liệu cũ của bạn ---
                txt_MaPhim.Text = row.Cells["MaPhim"].Value.ToString();
                txt_TenPhim.Text = row.Cells["TenPhim"].Value.ToString();
                // ... (các dòng txt khác) ...

                // --- THÊM PHẦN NÀY ĐỂ LOAD SUẤT CHIẾU ---
                int maPhim = Convert.ToInt32(row.Cells["MaPhim"].Value);
                LoadSuatChieu(maPhim); // Gọi hàm load suất chiếu theo mã phim vừa click
            }
        }

        private void btn_Poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFile.FileName;
                currentPosterName = Path.GetFileName(openFile.FileName);
                pb_Poster.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int thoiLuong = int.Parse(txt_ThoiLuong.Text);
                int maTL = Convert.ToInt32(cbb_TheLoai.SelectedValue);

                SaveImageToFolder(); // Lưu ảnh trước

                // Gọi qua BUS thay vì viết câu query dài dòng
                if (BUS_Phim.Instance.InsertPhim(txt_TenPhim.Text, thoiLuong, dtp_NgayKhoiChieu.Value, txt_MoTa.Text, currentPosterName, maTL))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDanhSachPhim();
                }
                else MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại thời lượng!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {

            try
            {
                int maPhim = int.Parse(txt_MaPhim.Text);
                if (MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (BUS_Phim.Instance.DeletePhim(maPhim))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDanhSachPhim();
                    }
                }
            }
            catch (Exception)
            {
                // Lỗi này bắt được nếu phim đang có suất chiếu (Ràng buộc khóa ngoại)
                MessageBox.Show("Không thể xóa phim này vì đã có lịch chiếu hoặc đã bán vé!");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhim = int.Parse(txt_MaPhim.Text);
                int thoiLuong = int.Parse(txt_ThoiLuong.Text);
                int maTL = Convert.ToInt32(cbb_TheLoai.SelectedValue);

                SaveImageToFolder();

                if (BUS_Phim.Instance.UpdatePhim(maPhim, txt_TenPhim.Text, thoiLuong, dtp_NgayKhoiChieu.Value, txt_MoTa.Text, currentPosterName, maTL))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadDanhSachPhim();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void cbo_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Phim_Load_1(object sender, EventArgs e)
        {
            dtp_GioChieu.Value = DateTime.Now;
            LoadDanhSachPhim();
            // Hàm LoadTheLoai() gọi từ TheLoaiDAO...
            LoadTheLoai();
            LoadComboBoxPhong();

        }

        private void dgv_SuatChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadSuatChieu(int maPhim)
        {
            DataTable dt = BUS_SuatChieu.Instance.GetSuatChieuByMaPhim(maPhim);
            dgv_SuatChieu.DataSource = dt;

            if (dgv_SuatChieu.Columns.Count > 0)
            {
                // 1. Đặt tên tiếng Việt
                dgv_SuatChieu.Columns["MaSuatChieu"].HeaderText = "Mã Suất";
                dgv_SuatChieu.Columns["TenPhong"].HeaderText = "Phòng Chiếu";
                dgv_SuatChieu.Columns["GioBatDau"].HeaderText = "Giờ Chiếu";
                dgv_SuatChieu.Columns["GiaVe"].HeaderText = "Giá Vé";

                // 2. Ẩn cột bổ trợ (Dùng cho ComboBox nhưng không hiện lên bảng)
                if (dgv_SuatChieu.Columns.Contains("ThongTinSuatChieu"))
                    dgv_SuatChieu.Columns["ThongTinSuatChieu"].Visible = false;

                // 3. Định dạng hiển thị
                dgv_SuatChieu.Columns["GioBatDau"].DefaultCellStyle.Format = "HH:mm"; // Chỉ hiện Giờ:Phút
                dgv_SuatChieu.Columns["GiaVe"].DefaultCellStyle.Format = "N0";        // Hiện 80,000 thay vì 80000.00

                // 4. Tự động dãn cột cho khít bảng
                dgv_SuatChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dgv_SuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void cbb_PhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemSuat_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy thông tin từ giao diện
                int maPhim = int.Parse(txt_MaPhim.Text);
                int maPhong = (int)cbb_PhongChieu.SelectedValue;
                DateTime gioChieu = dtp_GioChieu.Value;
                float giaVe = float.Parse(txt_GiaVe.Text);

                // 2. Gọi BUS để thêm
                if (BUS_SuatChieu.Instance.AddSuatChieu(maPhim, maPhong, gioChieu, giaVe))
                {
                    MessageBox.Show("Thêm suất chiếu thành công!");
                    // 3. Load lại bảng Suất chiếu để thấy dòng mới ngay lập tức
                    LoadSuatChieu(maPhim);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm suất chiếu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: " + ex.Message);
            }
        }

        private void dtp_GioChieu_ValueChanged(object sender, EventArgs e)
        {
         
        }
        void LoadComboBoxPhong()
        {
            DataTable dt = BUS_PhongChieu.Instance.GetListPhongChieu();
            cbb_PhongChieu.DataSource = dt;
            cbb_PhongChieu.DisplayMember = "TenPhong"; // Hiển thị tên phòng
            cbb_PhongChieu.ValueMember = "MaPhong";    // Lưu mã phòng xuống dưới
        }
    }
}
