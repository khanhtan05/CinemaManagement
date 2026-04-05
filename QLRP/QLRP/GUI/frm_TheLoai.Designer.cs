namespace QLRP.GUI
{
    partial class frm_TheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TheLoai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_TheLoai = new System.Windows.Forms.Label();
            this.lbl_MaTheLoai = new System.Windows.Forms.Label();
            this.txt_TheLoai = new System.Windows.Forms.TextBox();
            this.txt_MaTheLoai = new System.Windows.Forms.TextBox();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.dgv_TheLoai = new System.Windows.Forms.DataGridView();
            this.pnl_Left.SuspendLayout();
            this.pnl_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Left
            // 
            this.pnl_Left.Controls.Add(this.btn_Update);
            this.pnl_Left.Controls.Add(this.btn_Delete);
            this.pnl_Left.Controls.Add(this.btn_Add);
            this.pnl_Left.Controls.Add(this.lbl_TheLoai);
            this.pnl_Left.Controls.Add(this.lbl_MaTheLoai);
            this.pnl_Left.Controls.Add(this.txt_TheLoai);
            this.pnl_Left.Controls.Add(this.txt_MaTheLoai);
            this.pnl_Left.ForeColor = System.Drawing.Color.White;
            this.pnl_Left.Location = new System.Drawing.Point(16, 16);
            this.pnl_Left.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(374, 360);
            this.pnl_Left.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.ImageIndex = 2;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(280, 250);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 62);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addition.png");
            this.imageList1.Images.SetKeyName(1, "cancel.png");
            this.imageList1.Images.SetKeyName(2, "refresh.png");
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.ImageIndex = 1;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(144, 250);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 62);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.ImageIndex = 0;
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(21, 250);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 62);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_TheLoai
            // 
            this.lbl_TheLoai.AutoSize = true;
            this.lbl_TheLoai.Location = new System.Drawing.Point(77, 143);
            this.lbl_TheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TheLoai.Name = "lbl_TheLoai";
            this.lbl_TheLoai.Size = new System.Drawing.Size(82, 22);
            this.lbl_TheLoai.TabIndex = 11;
            this.lbl_TheLoai.Text = "Thể loại:";
            // 
            // lbl_MaTheLoai
            // 
            this.lbl_MaTheLoai.AutoSize = true;
            this.lbl_MaTheLoai.Location = new System.Drawing.Point(77, 87);
            this.lbl_MaTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaTheLoai.Name = "lbl_MaTheLoai";
            this.lbl_MaTheLoai.Size = new System.Drawing.Size(106, 22);
            this.lbl_MaTheLoai.TabIndex = 12;
            this.lbl_MaTheLoai.Text = "Mã thể loại:";
            // 
            // txt_TheLoai
            // 
            this.txt_TheLoai.Location = new System.Drawing.Point(190, 135);
            this.txt_TheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TheLoai.Name = "txt_TheLoai";
            this.txt_TheLoai.Size = new System.Drawing.Size(136, 30);
            this.txt_TheLoai.TabIndex = 1;
            // 
            // txt_MaTheLoai
            // 
            this.txt_MaTheLoai.Location = new System.Drawing.Point(190, 79);
            this.txt_MaTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaTheLoai.Name = "txt_MaTheLoai";
            this.txt_MaTheLoai.ReadOnly = true;
            this.txt_MaTheLoai.Size = new System.Drawing.Size(136, 30);
            this.txt_MaTheLoai.TabIndex = 0;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Controls.Add(this.dgv_TheLoai);
            this.pnl_Right.Location = new System.Drawing.Point(398, 16);
            this.pnl_Right.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(573, 360);
            this.pnl_Right.TabIndex = 1;
            // 
            // dgv_TheLoai
            // 
            this.dgv_TheLoai.AllowUserToAddRows = false;
            this.dgv_TheLoai.AllowUserToDeleteRows = false;
            this.dgv_TheLoai.AllowUserToResizeColumns = false;
            this.dgv_TheLoai.AllowUserToResizeRows = false;
            this.dgv_TheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_TheLoai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_TheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TheLoai.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_TheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TheLoai.EnableHeadersVisualStyles = false;
            this.dgv_TheLoai.Location = new System.Drawing.Point(0, 0);
            this.dgv_TheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_TheLoai.Name = "dgv_TheLoai";
            this.dgv_TheLoai.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TheLoai.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_TheLoai.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_TheLoai.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_TheLoai.RowTemplate.Height = 24;
            this.dgv_TheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TheLoai.Size = new System.Drawing.Size(573, 360);
            this.dgv_TheLoai.TabIndex = 0;
            this.dgv_TheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_TheLoai_CellClick);
            // 
            // frm_TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(974, 382);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Left);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THỂ LOẠI";
            this.pnl_Left.ResumeLayout(false);
            this.pnl_Left.PerformLayout();
            this.pnl_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.DataGridView dgv_TheLoai;
        private System.Windows.Forms.Label lbl_TheLoai;
        private System.Windows.Forms.Label lbl_MaTheLoai;
        private System.Windows.Forms.TextBox txt_TheLoai;
        private System.Windows.Forms.TextBox txt_MaTheLoai;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ImageList imageList1;
    }
}