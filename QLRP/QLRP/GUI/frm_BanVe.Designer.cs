namespace QLRP.GUI
{
    partial class frm_BanVe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BanVe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Slide = new System.Windows.Forms.Panel();
            this.pnl_Movie = new System.Windows.Forms.Panel();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.flpSeatMap = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SelectedMovie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_SuatChieu = new System.Windows.Forms.ComboBox();
            this.pt_SelectedMoviePoster = new System.Windows.Forms.PictureBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_SeatsList = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lbltl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ThoiLuong = new System.Windows.Forms.Label();
            this.lbl_TheLoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Slide.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_SelectedMoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.pnl_Slide);
            this.panel1.Controls.Add(this.btn_Prev);
            this.panel1.Controls.Add(this.flpSeatMap);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 691);
            this.panel1.TabIndex = 0;
            // 
            // btn_Next
            // 
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.ImageIndex = 1;
            this.btn_Next.ImageList = this.imageList1;
            this.btn_Next.Location = new System.Drawing.Point(619, 132);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(41, 81);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "left-arrow.png");
            this.imageList1.Images.SetKeyName(1, "right-arrow.png");
            this.imageList1.Images.SetKeyName(2, "money.png");
            // 
            // pnl_Slide
            // 
            this.pnl_Slide.Controls.Add(this.pnl_Movie);
            this.pnl_Slide.Location = new System.Drawing.Point(86, 45);
            this.pnl_Slide.Name = "pnl_Slide";
            this.pnl_Slide.Size = new System.Drawing.Size(527, 317);
            this.pnl_Slide.TabIndex = 0;
            // 
            // pnl_Movie
            // 
            this.pnl_Movie.AutoSize = true;
            this.pnl_Movie.Location = new System.Drawing.Point(0, 0);
            this.pnl_Movie.Name = "pnl_Movie";
            this.pnl_Movie.Size = new System.Drawing.Size(1810, 258);
            this.pnl_Movie.TabIndex = 0;
            this.pnl_Movie.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Movie_Paint);
            // 
            // btn_Prev
            // 
            this.btn_Prev.FlatAppearance.BorderSize = 0;
            this.btn_Prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_Prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Prev.ForeColor = System.Drawing.Color.White;
            this.btn_Prev.ImageKey = "left-arrow.png";
            this.btn_Prev.ImageList = this.imageList1;
            this.btn_Prev.Location = new System.Drawing.Point(39, 132);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(41, 81);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // flpSeatMap
            // 
            this.flpSeatMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpSeatMap.Location = new System.Drawing.Point(75, 368);
            this.flpSeatMap.Name = "flpSeatMap";
            this.flpSeatMap.Size = new System.Drawing.Size(564, 266);
            this.flpSeatMap.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_SuatChieu);
            this.groupBox1.Controls.Add(this.pt_SelectedMoviePoster);
            this.groupBox1.Controls.Add(this.lbl_Total);
            this.groupBox1.Controls.Add(this.lbl_SeatsList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.btn_Pay);
            this.groupBox1.Controls.Add(this.lbltl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_ThoiLuong);
            this.groupBox1.Controls.Add(this.lbl_TheLoai);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(827, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 589);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_SelectedMovie);
            this.panel2.Location = new System.Drawing.Point(6, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 91);
            this.panel2.TabIndex = 8;
            // 
            // lbl_SelectedMovie
            // 
            this.lbl_SelectedMovie.AutoSize = true;
            this.lbl_SelectedMovie.Location = new System.Drawing.Point(16, 41);
            this.lbl_SelectedMovie.Name = "lbl_SelectedMovie";
            this.lbl_SelectedMovie.Size = new System.Drawing.Size(61, 26);
            this.lbl_SelectedMovie.TabIndex = 0;
            this.lbl_SelectedMovie.Text = "Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Suất chiếu";
            // 
            // cbb_SuatChieu
            // 
            this.cbb_SuatChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cbb_SuatChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_SuatChieu.ForeColor = System.Drawing.Color.White;
            this.cbb_SuatChieu.FormattingEnabled = true;
            this.cbb_SuatChieu.Location = new System.Drawing.Point(162, 389);
            this.cbb_SuatChieu.Name = "cbb_SuatChieu";
            this.cbb_SuatChieu.Size = new System.Drawing.Size(188, 34);
            this.cbb_SuatChieu.TabIndex = 6;
            this.cbb_SuatChieu.SelectedIndexChanged += new System.EventHandler(this.cbb_Phim_SelectedIndexChanged);
            // 
            // pt_SelectedMoviePoster
            // 
            this.pt_SelectedMoviePoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pt_SelectedMoviePoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pt_SelectedMoviePoster.Location = new System.Drawing.Point(268, 12);
            this.pt_SelectedMoviePoster.Name = "pt_SelectedMoviePoster";
            this.pt_SelectedMoviePoster.Size = new System.Drawing.Size(165, 234);
            this.pt_SelectedMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_SelectedMoviePoster.TabIndex = 5;
            this.pt_SelectedMoviePoster.TabStop = false;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(174, 249);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 26);
            this.lbl_Total.TabIndex = 4;
            // 
            // lbl_SeatsList
            // 
            this.lbl_SeatsList.AutoSize = true;
            this.lbl_SeatsList.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_SeatsList.Location = new System.Drawing.Point(20, 323);
            this.lbl_SeatsList.Name = "lbl_SeatsList";
            this.lbl_SeatsList.Size = new System.Drawing.Size(152, 26);
            this.lbl_SeatsList.TabIndex = 3;
            this.lbl_SeatsList.Text = "Ghế chưa chọn";
            this.lbl_SeatsList.Click += new System.EventHandler(this.lbl_SeatsList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng cộng:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(176, 477);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 26);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Tổng cộng";
            // 
            // btn_Pay
            // 
            this.btn_Pay.FlatAppearance.BorderSize = 0;
            this.btn_Pay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_Pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.ImageIndex = 0;
            this.btn_Pay.ImageList = this.imageList2;
            this.btn_Pay.Location = new System.Drawing.Point(181, 523);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(109, 39);
            this.btn_Pay.TabIndex = 1;
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click_1);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "money.png");
            // 
            // lbltl
            // 
            this.lbltl.AutoSize = true;
            this.lbltl.Location = new System.Drawing.Point(136, 165);
            this.lbltl.Name = "lbltl";
            this.lbltl.Size = new System.Drawing.Size(0, 26);
            this.lbltl.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 0;
            // 
            // lbl_ThoiLuong
            // 
            this.lbl_ThoiLuong.AutoSize = true;
            this.lbl_ThoiLuong.Location = new System.Drawing.Point(15, 249);
            this.lbl_ThoiLuong.Name = "lbl_ThoiLuong";
            this.lbl_ThoiLuong.Size = new System.Drawing.Size(121, 26);
            this.lbl_ThoiLuong.TabIndex = 0;
            this.lbl_ThoiLuong.Text = "Thời lượng:";
            this.lbl_ThoiLuong.Click += new System.EventHandler(this.lbl_ThoiLuong_Click);
            // 
            // lbl_TheLoai
            // 
            this.lbl_TheLoai.AutoSize = true;
            this.lbl_TheLoai.Location = new System.Drawing.Point(20, 165);
            this.lbl_TheLoai.Name = "lbl_TheLoai";
            this.lbl_TheLoai.Size = new System.Drawing.Size(100, 26);
            this.lbl_TheLoai.TabIndex = 0;
            this.lbl_TheLoai.Text = "Thể loại: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(515, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẦY BÁN VÉ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_BanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1289, 717);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÁN VÉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BanVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Slide.ResumeLayout(false);
            this.pnl_Slide.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_SelectedMoviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_SelectedMovie;
        private System.Windows.Forms.FlowLayoutPanel flpSeatMap;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Panel pnl_Slide;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Panel pnl_Movie;
        private System.Windows.Forms.PictureBox pt_SelectedMoviePoster;
        private System.Windows.Forms.Label lbl_SeatsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TheLoai;
        private System.Windows.Forms.Label lbltl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ThoiLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_SuatChieu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel2;
    }
}