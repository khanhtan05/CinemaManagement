namespace QLRP
{
    partial class frm_QLKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.grp_ThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_DanhSachKhachHang = new System.Windows.Forms.GroupBox();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.grp_ThongTinKhachHang.SuspendLayout();
            this.grp_DanhSachKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // grp_ThongTinKhachHang
            // 
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_DienThoai);
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_TenKhachHang);
            this.grp_ThongTinKhachHang.Controls.Add(this.txt_MaKhachHang);
            this.grp_ThongTinKhachHang.Controls.Add(this.label4);
            this.grp_ThongTinKhachHang.Controls.Add(this.label3);
            this.grp_ThongTinKhachHang.Controls.Add(this.label2);
            this.grp_ThongTinKhachHang.Location = new System.Drawing.Point(109, 72);
            this.grp_ThongTinKhachHang.Name = "grp_ThongTinKhachHang";
            this.grp_ThongTinKhachHang.Size = new System.Drawing.Size(576, 333);
            this.grp_ThongTinKhachHang.TabIndex = 1;
            this.grp_ThongTinKhachHang.TabStop = false;
            this.grp_ThongTinKhachHang.Text = "Thông tin khách hàng";
            this.grp_ThongTinKhachHang.Enter += new System.EventHandler(this.grp_ThongTinKhachHang_Enter);
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(227, 224);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(155, 26);
            this.txt_DienThoai.TabIndex = 5;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(227, 139);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(155, 26);
            this.txt_TenKhachHang.TabIndex = 4;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(227, 56);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(84, 26);
            this.txt_MaKhachHang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng:";
            // 
            // grp_DanhSachKhachHang
            // 
            this.grp_DanhSachKhachHang.Controls.Add(this.dgv_KhachHang);
            this.grp_DanhSachKhachHang.Location = new System.Drawing.Point(749, 72);
            this.grp_DanhSachKhachHang.Name = "grp_DanhSachKhachHang";
            this.grp_DanhSachKhachHang.Size = new System.Drawing.Size(553, 333);
            this.grp_DanhSachKhachHang.TabIndex = 2;
            this.grp_DanhSachKhachHang.TabStop = false;
            this.grp_DanhSachKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(6, 39);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.Size = new System.Drawing.Size(541, 272);
            this.dgv_KhachHang.TabIndex = 0;
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 658);
            this.Controls.Add(this.grp_DanhSachKhachHang);
            this.Controls.Add(this.grp_ThongTinKhachHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frm_QLKhachHang_Load);
            this.grp_ThongTinKhachHang.ResumeLayout(false);
            this.grp_ThongTinKhachHang.PerformLayout();
            this.grp_DanhSachKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_ThongTinKhachHang;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_DanhSachKhachHang;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
    }
}