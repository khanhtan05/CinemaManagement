using QLRP.BUS;
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
    public partial class frm_NhanVien : Form
    {
        string fileName = "";
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }
        void LoadNV()
        {
            dgv_NhanVien.DataSource = BUS_NhanVien.Instance.GetList();
        }
        private Image LoadImageSafe(string path)
        {
            try
            {
                if (!File.Exists(path)) return null;

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    // Copy ảnh ra một bản sao trong bộ nhớ rồi đóng file lại ngay
                    return Image.FromStream(fs);
                }
            }
            catch (Exception)
            {
                return null; // Trả về null nếu file lỗi để không làm sập app
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv_NhanVien.Rows[e.RowIndex];
                // Lưu ý: Tên cột trong ngoặc ["..."] phải khớp với bí danh 'as' trong DAO
                txt_MaNV.Text = r.Cells["Mã NV"].Value.ToString();
                txt_TenNV.Text = r.Cells["Họ Tên"].Value.ToString();
                txt_SDT.Text = r.Cells["SĐT"].Value.ToString();
                txt_TaiKhoan.Text = r.Cells["Tài khoản"].Value.ToString();
                cbb_VaiTro.Text = r.Cells["Vai trò"].Value.ToString();
                string imagePath = r.Cells["HinhAnh"].Value.ToString();
                string fullPath = Path.Combine(Application.StartupPath, "img", imagePath);
                pt_Anh.Image = LoadImageSafe(fullPath);
                if (File.Exists(fullPath))
                    pt_Anh.Image = Image.FromFile(fullPath);
                else
                    pt_Anh.Image = null; // Hoặc set ảnh mặc định
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = open.FileName;
                    fileName = Path.GetFileName(sourcePath);
                    string folderPath = Path.Combine(Application.StartupPath, "img");
                    string destPath = Path.Combine(folderPath, fileName);

                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                    try
                    {
                        // BƯỚC QUAN TRỌNG: Giải phóng PictureBox để mở khóa file
                        if (pt_Anh.Image != null)
                        {
                            pt_Anh.Image.Dispose();
                            pt_Anh.Image = null;
                        }

                        // Copy ảnh (ghi đè an toàn)
                        File.Copy(sourcePath, destPath, true);

                        // Hiển thị lại bằng hàm LoadImageSafe (đã dùng FileStream để không khóa file)
                        pt_Anh.Image = LoadImageSafe(destPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ma = txt_MaNV.Text;
            string ten = txt_TenNV.Text;
            string sdt = txt_SDT.Text;
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;
            string vt = cbb_VaiTro.Text;
            // ... lấy các thông tin khác ...
            string hinh = fileName; // Chính là tên file vừa chọn ở nút btn_Anh

            if (cbb_VaiTro.Text == "Bán Vé")
            {
                vt = "BanVe";
            }
            else
            {
                vt = "Admin";
            }

            if (BUS_NhanVien.Instance.ThemNV(ma, ten, sdt, tk, mk, vt, hinh))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadNV();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string ma = txt_MaNV.Text;
            string ten = txt_TenNV.Text;
            string sdt = txt_SDT.Text;
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;
            string vt = cbb_VaiTro.Text;

            // Nếu fileName trống (người dùng không chọn ảnh mới), 
            // ta có thể lấy lại tên ảnh cũ từ Grid hoặc để nguyên
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = dgv_NhanVien.CurrentRow.Cells["HinhAnh"].Value.ToString();
            }

            if (BUS_NhanVien.Instance.SuaNV(ma, ten, sdt, tk, mk, vt, fileName))
            {
                MessageBox.Show("Cập nhật nhân viên " + ten + " thành công!");
                LoadNV(); // Load lại Grid
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_MaNV.Text;

            if (ma == "admin")
            { // Chặn không cho xóa tài khoản admin chính
                MessageBox.Show("Không thể xóa tài khoản Quản trị hệ thống!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (BUS_NhanVien.Instance.XoaNV(ma))
                {
                    MessageBox.Show("Đã xóa nhân viên.");
                    LoadNV();
                }
            }
        }
    }
}
