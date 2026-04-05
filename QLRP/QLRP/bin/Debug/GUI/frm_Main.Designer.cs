using QLRP.DTO;
using QLRP.GUI;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static QLRP.GUI.Menutrip;

namespace QLRP
{
    public partial class frm_main : Form
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tt_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tt_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuTheoPhimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_Menu = new System.Windows.Forms.MenuStrip();
            this.pt_Main = new System.Windows.Forms.PictureBox();
            this.pnl_Movie = new System.Windows.Forms.Panel();
            this.pnl_Slide = new System.Windows.Forms.Panel();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_MenuTrip = new System.Windows.Forms.Panel();
            this.mnt_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Main)).BeginInit();
            this.pnl_Slide.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_MenuTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tt_HeThong
            // 
            this.tt_HeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.tt_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tt_HeThong.ForeColor = System.Drawing.Color.White;
            this.tt_HeThong.Image = ((System.Drawing.Image)(resources.GetObject("tt_HeThong.Image")));
            this.tt_HeThong.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tt_HeThong.Name = "tt_HeThong";
            this.tt_HeThong.Size = new System.Drawing.Size(126, 38);
            this.tt_HeThong.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tt_QuanLy
            // 
            this.tt_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thểLoạiToolStripMenuItem,
            this.phimToolStripMenuItem,
            this.mn_NhanVien});
            this.tt_QuanLy.ForeColor = System.Drawing.Color.White;
            this.tt_QuanLy.Image = ((System.Drawing.Image)(resources.GetObject("tt_QuanLy.Image")));
            this.tt_QuanLy.Name = "tt_QuanLy";
            this.tt_QuanLy.Size = new System.Drawing.Size(134, 38);
            this.tt_QuanLy.Text = "Danh mục";
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // phimToolStripMenuItem
            // 
            this.phimToolStripMenuItem.Name = "phimToolStripMenuItem";
            this.phimToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.phimToolStripMenuItem.Text = "Phim";
            this.phimToolStripMenuItem.Click += new System.EventHandler(this.phimToolStripMenuItem_Click);
            // 
            // mn_NhanVien
            // 
            this.mn_NhanVien.Name = "mn_NhanVien";
            this.mn_NhanVien.Size = new System.Drawing.Size(174, 26);
            this.mn_NhanVien.Text = "Nhân viên";
            this.mn_NhanVien.Click += new System.EventHandler(this.mn_NhanVien_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánVéToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nghiệpVụToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nghiệpVụToolStripMenuItem.Image")));
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(137, 38);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // bánVéToolStripMenuItem
            // 
            this.bánVéToolStripMenuItem.Name = "bánVéToolStripMenuItem";
            this.bánVéToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.bánVéToolStripMenuItem.Text = "Bán vé";
            this.bánVéToolStripMenuItem.Click += new System.EventHandler(this.bánVéToolStripMenuItem_Click);
            // 
            // mn_BaoCao
            // 
            this.mn_BaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuTheoNgàyToolStripMenuItem,
            this.doanhThuTheoThángToolStripMenuItem,
            this.doanhThuTheoPhimToolStripMenuItem});
            this.mn_BaoCao.ForeColor = System.Drawing.Color.White;
            this.mn_BaoCao.Image = ((System.Drawing.Image)(resources.GetObject("mn_BaoCao.Image")));
            this.mn_BaoCao.Name = "mn_BaoCao";
            this.mn_BaoCao.Size = new System.Drawing.Size(121, 38);
            this.mn_BaoCao.Text = "Báo cáo";
            // 
            // doanhThuTheoNgàyToolStripMenuItem
            // 
            this.doanhThuTheoNgàyToolStripMenuItem.Name = "doanhThuTheoNgàyToolStripMenuItem";
            this.doanhThuTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.doanhThuTheoNgàyToolStripMenuItem.Text = "Doanh thu theo ngày";
            this.doanhThuTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.doanhThuTheoNgàyToolStripMenuItem_Click);
            // 
            // doanhThuTheoThángToolStripMenuItem
            // 
            this.doanhThuTheoThángToolStripMenuItem.Name = "doanhThuTheoThángToolStripMenuItem";
            this.doanhThuTheoThángToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.doanhThuTheoThángToolStripMenuItem.Text = "Doanh thu theo tháng";
            this.doanhThuTheoThángToolStripMenuItem.Click += new System.EventHandler(this.doanhThuTheoThángToolStripMenuItem_Click);
            // 
            // doanhThuTheoPhimToolStripMenuItem
            // 
            this.doanhThuTheoPhimToolStripMenuItem.Name = "doanhThuTheoPhimToolStripMenuItem";
            this.doanhThuTheoPhimToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.doanhThuTheoPhimToolStripMenuItem.Text = "Doanh thu theo phim";
            this.doanhThuTheoPhimToolStripMenuItem.Click += new System.EventHandler(this.doanhThuTheoPhimToolStripMenuItem_Click);
            // 
            // mnt_Menu
            // 
            this.mnt_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.mnt_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnt_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt_Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnt_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tt_HeThong,
            this.tt_QuanLy,
            this.nghiệpVụToolStripMenuItem,
            this.mn_BaoCao});
            this.mnt_Menu.Location = new System.Drawing.Point(0, 0);
            this.mnt_Menu.Name = "mnt_Menu";
            this.mnt_Menu.Size = new System.Drawing.Size(725, 42);
            this.mnt_Menu.TabIndex = 1;
            this.mnt_Menu.Text = "menuStrip1";
            // 
            // pt_Main
            // 
            this.pt_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pt_Main.Image = ((System.Drawing.Image)(resources.GetObject("pt_Main.Image")));
            this.pt_Main.Location = new System.Drawing.Point(151, 42);
            this.pt_Main.Name = "pt_Main";
            this.pt_Main.Size = new System.Drawing.Size(725, 468);
            this.pt_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Main.TabIndex = 3;
            this.pt_Main.TabStop = false;
            this.pt_Main.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_Movie
            // 
            this.pnl_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnl_Movie.Location = new System.Drawing.Point(0, 9);
            this.pnl_Movie.Name = "pnl_Movie";
            this.pnl_Movie.Size = new System.Drawing.Size(143, 700);
            this.pnl_Movie.TabIndex = 5;
            // 
            // pnl_Slide
            // 
            this.pnl_Slide.Controls.Add(this.pnl_Movie);
            this.pnl_Slide.Location = new System.Drawing.Point(3, 137);
            this.pnl_Slide.Name = "pnl_Slide";
            this.pnl_Slide.Size = new System.Drawing.Size(148, 361);
            this.pnl_Slide.TabIndex = 6;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.lbl_Name);
            this.pnl_Info.Controls.Add(this.lbl_Date);
            this.pnl_Info.Controls.Add(this.lbl_Time);
            this.pnl_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Info.ForeColor = System.Drawing.Color.White;
            this.pnl_Info.Location = new System.Drawing.Point(0, 0);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(151, 125);
            this.pnl_Info.TabIndex = 6;
            this.pnl_Info.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Info_Paint);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(3, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(56, 22);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(3, 49);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(47, 22);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(3, 91);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(50, 22);
            this.lbl_Time.TabIndex = 5;
            this.lbl_Time.Text = "Time";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.pnl_Menu.Controls.Add(this.pnl_Info);
            this.pnl_Menu.Controls.Add(this.pnl_Slide);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(151, 510);
            this.pnl_Menu.TabIndex = 8;
            // 
            // pnl_MenuTrip
            // 
            this.pnl_MenuTrip.Controls.Add(this.mnt_Menu);
            this.pnl_MenuTrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuTrip.Location = new System.Drawing.Point(151, 0);
            this.pnl_MenuTrip.Name = "pnl_MenuTrip";
            this.pnl_MenuTrip.Size = new System.Drawing.Size(725, 42);
            this.pnl_MenuTrip.TabIndex = 4;
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.Controls.Add(this.pt_Main);
            this.Controls.Add(this.pnl_MenuTrip);
            this.Controls.Add(this.pnl_Menu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnt_Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ RẠP PHIM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.mnt_Menu.ResumeLayout(false);
            this.mnt_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Main)).EndInit();
            this.pnl_Slide.ResumeLayout(false);
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_MenuTrip.ResumeLayout(false);
            this.pnl_MenuTrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tt_HeThong;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tt_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_BaoCao;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoPhimToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnt_Menu;
        private System.Windows.Forms.PictureBox pt_Main;
        private DTO_NhanVien nhanVien;
        private Panel pnl_Movie;
        private Panel pnl_Menu;
        private Panel pnl_MenuTrip;
        private Label lbl_Name;
        private DTO_NhanVien currentUser;
        private Label lbl_Time;
        private Label lbl_Date;
        private DTO_NhanVien User;
        private Panel pnl_Info;
        private Panel pnl_Slide;
        Timer timer = new Timer();
        Timer slideTimer = new Timer();
        int targetY = 0;
        const int STEP = 210;

        public frm_main(DTO_NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
            User = nhanVien;
            if (User != null)
            {
                lbl_Name.Text = "👤 " + User.TenNhanVien;
            }
            // Giả sử panel1 cao 140px, bạn muốn cách thêm 20px nữa
            pnl_Slide.Location = new Point(3, 160);

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_Date.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            lbl_Time.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbl_Time.ForeColor = Color.Cyan;

            lbl_Date.Font = new Font("Segoe UI", 10);
            lbl_Date.ForeColor = Color.White;
        }
        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            int speed = 2;

            pnl_Slide.Top -= speed;

            // Khi trượt hết thì quay lại đầu
            if (Math.Abs(pnl_Slide.Top) >= pnl_Slide.Height - pnl_Movie.Height)
            {
                pnl_Slide.Top = 300;
            }
        }
        void SetupSlider()
        {
            slideTimer.Interval = 30;
            slideTimer.Tick += SlideTimer_Tick;

            pnl_Slide.Top = 300;
        }

        void LoadMoviesToUI()
        {
            pnl_Slide.Controls.Clear();

            string query = @"SELECT Poster FROM Phim";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            int yPos = 500;

            foreach (DataRow row in data.Rows)
            {
                PictureBox pic = new PictureBox();
                pic.Width = pnl_Slide.Width;
                pic.Height = 200;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                string poster = row["Poster"].ToString();
                string path = Path.Combine(Application.StartupPath, "Posters", poster);

                if (File.Exists(path))
                {
                    pic.Image = Image.FromFile(path);
                }

                pic.Location = new Point(0, yPos);

                pnl_Slide.Controls.Add(pic);
                yPos += STEP;
            }

            pnl_Slide.Height = yPos;

            slideTimer.Start(); // auto chạy
        }



        private void frm_main_Load(object sender, System.EventArgs e)
        {
            mnt_Menu.Location = new Point(0, 0);
            SetupSlider();
            LoadMoviesToUI();
   

            // Gán bộ dựng hình tùy chỉnh
            mnt_Menu.Renderer = new MovieMenuRenderer();

            // Chỉnh màu nền tổng thể của MenuStrip
            mnt_Menu.BackColor = Color.FromArgb(31, 40, 51);

        }

        private void bánVéToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            pt_Main.Visible = false;
            frm_BanVe fr = new frm_BanVe();
            fr.MdiParent = this;
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
            fr.Activate();
        }

        private void doanhThuTheoNgàyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frm_DoanhThu fr = new frm_DoanhThu();
            pt_Main.Visible = false;
            fr.MdiParent = this;
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.LoadReport("Ngay", ngay: DateTime.Now);
            fr.Show();
        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frm_DoanhThu fr = new frm_DoanhThu();
            pt_Main.Visible = false;
            fr.MdiParent = this;
            int namHienTai = DateTime.Now.Year;
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.LoadReport("Thang",nam: namHienTai);
            fr.Show();
        }

        private void doanhThuTheoPhimToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frm_DoanhThu fr = new frm_DoanhThu();
            pt_Main.Visible = false;
            fr.MdiParent = this;
            fr.LoadReport("Phim");
            fr.StartPosition = FormStartPosition.CenterScreen;
            fr.Show();
           
        }

        private void phimToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            pt_Main.Visible = false;
            frm_Phim fr = new frm_Phim();
            fr.MdiParent = this;
            fr.StartPosition = FormStartPosition.CenterParent;
            fr.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Hide();
                frm_Login login = new frm_Login();
                login.ShowDialog();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            frm_UpdatePass fr = new frm_UpdatePass();
            fr.MdiParent = this;
            pt_Main.Visible = false;
            fr.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình Con Gà Con không?",
                                      "Xác nhận thoát",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit(); // Đóng toàn bộ ứng dụng
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TheLoai fr = new frm_TheLoai();
            fr.MdiParent = this;
            pt_Main.Visible = false;
            fr.Show();
        }

        private void mn_NhanVien_Click(object sender, EventArgs e)
        {
            frm_NhanVien fr = new frm_NhanVien();
            fr.MdiParent = this;
            pt_Main.Visible = false;
            fr.Show();
        }
    }
}

