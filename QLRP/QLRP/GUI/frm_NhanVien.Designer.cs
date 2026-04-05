namespace QLRP.GUI
{
    partial class frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_ChonAnh = new System.Windows.Forms.Button();
            this.pt_Anh = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_VaiTro = new System.Windows.Forms.ComboBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.pnl_NhanVien = new System.Windows.Forms.Panel();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.pnl_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Anh)).BeginInit();
            this.pnl_NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(487, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(276, 32);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "QUẢN LÝ NHÂN SỰ";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.btn_Sua);
            this.pnl_Info.Controls.Add(this.btn_Xoa);
            this.pnl_Info.Controls.Add(this.btn_Them);
            this.pnl_Info.Controls.Add(this.btn_ChonAnh);
            this.pnl_Info.Controls.Add(this.pt_Anh);
            this.pnl_Info.Controls.Add(this.label7);
            this.pnl_Info.Controls.Add(this.label5);
            this.pnl_Info.Controls.Add(this.label3);
            this.pnl_Info.Controls.Add(this.label6);
            this.pnl_Info.Controls.Add(this.label4);
            this.pnl_Info.Controls.Add(this.label2);
            this.pnl_Info.Controls.Add(this.cbb_VaiTro);
            this.pnl_Info.Controls.Add(this.txt_MatKhau);
            this.pnl_Info.Controls.Add(this.txt_TaiKhoan);
            this.pnl_Info.Controls.Add(this.txt_SDT);
            this.pnl_Info.Controls.Add(this.txt_TenNV);
            this.pnl_Info.Controls.Add(this.txt_MaNV);
            this.pnl_Info.Location = new System.Drawing.Point(12, 87);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(531, 478);
            this.pnl_Info.TabIndex = 1;
            // 
            // btn_Sua
            // 
            this.btn_Sua.ImageIndex = 3;
            this.btn_Sua.ImageList = this.imageList1;
            this.btn_Sua.Location = new System.Drawing.Point(382, 391);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 68);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_pic.png");
            this.imageList1.Images.SetKeyName(1, "delete-user.png");
            this.imageList1.Images.SetKeyName(2, "user.png");
            this.imageList1.Images.SetKeyName(3, "user-refresh.png");
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ImageIndex = 1;
            this.btn_Xoa.ImageList = this.imageList1;
            this.btn_Xoa.Location = new System.Drawing.Point(198, 391);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 68);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.ImageIndex = 2;
            this.btn_Them.ImageList = this.imageList1;
            this.btn_Them.Location = new System.Drawing.Point(17, 391);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 68);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.ImageIndex = 0;
            this.btn_ChonAnh.ImageList = this.imageList1;
            this.btn_ChonAnh.Location = new System.Drawing.Point(382, 287);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(108, 68);
            this.btn_ChonAnh.TabIndex = 5;
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // pt_Anh
            // 
            this.pt_Anh.Location = new System.Drawing.Point(351, 3);
            this.pt_Anh.Name = "pt_Anh";
            this.pt_Anh.Size = new System.Drawing.Size(177, 228);
            this.pt_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Anh.TabIndex = 3;
            this.pt_Anh.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vai trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // cbb_VaiTro
            // 
            this.cbb_VaiTro.FormattingEnabled = true;
            this.cbb_VaiTro.Items.AddRange(new object[] {
            "Admin",
            "Bán Vé"});
            this.cbb_VaiTro.Location = new System.Drawing.Point(142, 325);
            this.cbb_VaiTro.Name = "cbb_VaiTro";
            this.cbb_VaiTro.Size = new System.Drawing.Size(183, 30);
            this.cbb_VaiTro.TabIndex = 4;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(142, 261);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(183, 30);
            this.txt_MatKhau.TabIndex = 3;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Location = new System.Drawing.Point(142, 203);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(183, 30);
            this.txt_TaiKhoan.TabIndex = 2;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(142, 137);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(183, 30);
            this.txt_SDT.TabIndex = 1;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(142, 73);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(183, 30);
            this.txt_TenNV.TabIndex = 0;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(142, 7);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.Size = new System.Drawing.Size(183, 30);
            this.txt_MaNV.TabIndex = 14;
            // 
            // pnl_NhanVien
            // 
            this.pnl_NhanVien.Controls.Add(this.dgv_NhanVien);
            this.pnl_NhanVien.Location = new System.Drawing.Point(571, 87);
            this.pnl_NhanVien.Name = "pnl_NhanVien";
            this.pnl_NhanVien.Size = new System.Drawing.Size(637, 478);
            this.pnl_NhanVien.TabIndex = 2;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.AllowUserToResizeColumns = false;
            this.dgv_NhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_NhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgv_NhanVien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhanVien.EnableHeadersVisualStyles = false;
            this.dgv_NhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_NhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_NhanVien.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_NhanVien.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgv_NhanVien.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_NhanVien.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dgv_NhanVien.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.RowTemplate.ReadOnly = true;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(637, 478);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.lbl_Title);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1220, 61);
            this.pnl_Title.TabIndex = 3;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1220, 574);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.pnl_NhanVien);
            this.Controls.Add(this.pnl_Info);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Anh)).EndInit();
            this.pnl_NhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_NhanVien;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_VaiTro;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pt_Anh;
        private System.Windows.Forms.Button btn_ChonAnh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel pnl_Title;
    }
}