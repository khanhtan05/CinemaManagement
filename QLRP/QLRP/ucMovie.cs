using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLRP
{
    public partial class ucMovie : UserControl
    {
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string TenTheLoai {  get; set; }

        public int ThoiLuong { get; set; }
        public event EventHandler OnSelectPhim;

        public ucMovie(int id, string name, string posterName, string tenTheLoai, int thoiLuong )
        {
            InitializeComponent();
            this.MaPhim = id;
            this.TenPhim = name;
            this.TenTheLoai = tenTheLoai;
            this.ThoiLuong = thoiLuong;
            // Gán tên phim vào Label đúng tên lbl_movie1 trong Designer
            this.lbl_movie1.Text = name;

            // Chỉnh ảnh tự động co giãn cho vừa khung
            pt_Movie.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                string path = Path.Combine(Application.StartupPath, "Posters", posterName);

                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pt_Movie.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    // Nếu không tìm thấy, hiện thông báo để biết nó đang tìm ở đâu
                    MessageBox.Show("Không tìm thấy ảnh tại: " + path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ảnh: " + ex.Message);
            }

            // Đăng ký sự kiện click cho tất cả thành phần để khi bấm vào đâu cũng chọn được phim
            this.Click += (s, e) => OnSelectPhim?.Invoke(this, e);
            pt_Movie.Click += (s, e) => OnSelectPhim?.Invoke(this, e);
            lbl_movie1.Click += (s, e) => OnSelectPhim?.Invoke(this, e);
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {
            // Hàm này sinh ra do bạn double click vào label trong Designer, 
            // có thể để trống vì ta đã đăng ký sự kiện ở Constructor phía trên.
        }
    }
}