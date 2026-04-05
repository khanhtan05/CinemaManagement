using QLRP.DTO;
using QLRP.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLRP.GUI.Menutrip;

namespace QLRP
{
    public partial class frm_main : Form
    {
        private DTO_NhanVien currentUser;
       
        public frm_main(DTO_NhanVien NhanVien)
        {
            InitializeComponent();
            currentUser = NhanVien;
        }

        public frm_main()
        {
            InitializeComponent();
        }

   

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (currentUser.VaiTro == "BanVe")
            {
                mn_NhanVien.Visible = false;
                mn_BaoCao.Visible = false;
            }

            // Gán bộ dựng hình tùy chỉnh
            mnt_Menu.Renderer = new MovieMenuRenderer();

            // Chỉnh màu nền tổng thể của MenuStrip
            mnt_Menu.BackColor = Color.FromArgb(31, 40, 51);

            // Tùy chỉnh thêm để giống ảnh của bạn hơn
            mnt_Menu.AutoSize = false;
            mnt_Menu.Width = 220; // Độ rộng menu bên trái

            foreach (ToolStripMenuItem item in mnt_Menu.Items)
            {
                // Padding: Left, Top, Right, Bottom
                // Tăng Top và Bottom lên 10-15 để giãn cách theo chiều dọc
                item.Padding = new Padding(10, 10, 0, 10);

                // Nếu bạn muốn các mục có độ rộng bằng nhau và khớp với thanh menu
                item.AutoSize = false;
                item.Size = new Size(mnt_Menu.Width, 50); // Chiều cao mỗi mục là 50px
            }
        }


  


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Hide();
                frm_Login login = new frm_Login();
                login.ShowDialog();
            }
        }

        private void doanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoanhThuTheoNgay fr = new frm_DoanhThuTheoNgay();
            pictureBox1.Visible = false;
            fr.MdiParent = this;
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UpdatePass fr = new frm_UpdatePass();  
            fr.MdiParent = this;
            fr.Show();
        }

        private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            frm_BanVe fr = new frm_BanVe();
            fr.MdiParent = this;
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
            fr.Activate();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            frm_Phim fr = new frm_Phim();
            fr.MdiParent = this;
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.Show();
        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
