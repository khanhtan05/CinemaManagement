namespace QLRP.GUI
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.img_Icon = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.lbl_l4 = new System.Windows.Forms.Label();
            this.lbl_l2 = new System.Windows.Forms.Label();
            this.lbl_l3 = new System.Windows.Forms.Label();
            this.lbl_l1 = new System.Windows.Forms.Label();
            this.pnl_Line2 = new System.Windows.Forms.Panel();
            this.pnl_Line = new System.Windows.Forms.Panel();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.lbl_SubTitle = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Logo)).BeginInit();
            this.pnl_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txt_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Account.ForeColor = System.Drawing.Color.White;
            this.txt_Account.Location = new System.Drawing.Point(190, 152);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(132, 23);
            this.txt_Account.TabIndex = 0;
            this.txt_Account.Enter += new System.EventHandler(this.txt_Account_Enter);
            this.txt_Account.Leave += new System.EventHandler(this.txt_Account_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.ImageIndex = 0;
            this.btn_Login.ImageList = this.img_Icon;
            this.btn_Login.Location = new System.Drawing.Point(206, 299);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(92, 69);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // img_Icon
            // 
            this.img_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Icon.ImageStream")));
            this.img_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Icon.Images.SetKeyName(0, "login.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pt_Logo);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 296);
            this.panel1.TabIndex = 3;
            // 
            // pt_Logo
            // 
            this.pt_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pt_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pt_Logo.Image")));
            this.pt_Logo.Location = new System.Drawing.Point(0, 0);
            this.pt_Logo.Name = "pt_Logo";
            this.pt_Logo.Size = new System.Drawing.Size(408, 296);
            this.pt_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Logo.TabIndex = 4;
            this.pt_Logo.TabStop = false;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Right.Controls.Add(this.lbl_l4);
            this.pnl_Right.Controls.Add(this.lbl_l2);
            this.pnl_Right.Controls.Add(this.lbl_l3);
            this.pnl_Right.Controls.Add(this.lbl_l1);
            this.pnl_Right.Controls.Add(this.pnl_Line2);
            this.pnl_Right.Controls.Add(this.pnl_Line);
            this.pnl_Right.Controls.Add(this.lbl_Pass);
            this.pnl_Right.Controls.Add(this.lbl_User);
            this.pnl_Right.Controls.Add(this.txt_PassWord);
            this.pnl_Right.Controls.Add(this.txt_Account);
            this.pnl_Right.Controls.Add(this.lbl_SubTitle);
            this.pnl_Right.Controls.Add(this.lbl_Title);
            this.pnl_Right.Controls.Add(this.btn_Login);
            this.pnl_Right.ForeColor = System.Drawing.Color.White;
            this.pnl_Right.Location = new System.Drawing.Point(346, 12);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(571, 385);
            this.pnl_Right.TabIndex = 4;
            this.pnl_Right.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_l4
            // 
            this.lbl_l4.AutoSize = true;
            this.lbl_l4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l4.ForeColor = System.Drawing.Color.White;
            this.lbl_l4.Location = new System.Drawing.Point(314, 251);
            this.lbl_l4.Name = "lbl_l4";
            this.lbl_l4.Size = new System.Drawing.Size(20, 25);
            this.lbl_l4.TabIndex = 7;
            this.lbl_l4.Text = "]";
            // 
            // lbl_l2
            // 
            this.lbl_l2.AutoSize = true;
            this.lbl_l2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l2.ForeColor = System.Drawing.Color.White;
            this.lbl_l2.Location = new System.Drawing.Point(314, 152);
            this.lbl_l2.Name = "lbl_l2";
            this.lbl_l2.Size = new System.Drawing.Size(20, 25);
            this.lbl_l2.TabIndex = 7;
            this.lbl_l2.Text = "]";
            // 
            // lbl_l3
            // 
            this.lbl_l3.AutoSize = true;
            this.lbl_l3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l3.ForeColor = System.Drawing.Color.White;
            this.lbl_l3.Location = new System.Drawing.Point(174, 251);
            this.lbl_l3.Name = "lbl_l3";
            this.lbl_l3.Size = new System.Drawing.Size(20, 25);
            this.lbl_l3.TabIndex = 7;
            this.lbl_l3.Text = "[";
            // 
            // lbl_l1
            // 
            this.lbl_l1.AutoSize = true;
            this.lbl_l1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l1.ForeColor = System.Drawing.Color.White;
            this.lbl_l1.Location = new System.Drawing.Point(174, 152);
            this.lbl_l1.Name = "lbl_l1";
            this.lbl_l1.Size = new System.Drawing.Size(20, 25);
            this.lbl_l1.TabIndex = 7;
            this.lbl_l1.Text = "[";
            // 
            // pnl_Line2
            // 
            this.pnl_Line2.BackColor = System.Drawing.Color.Gray;
            this.pnl_Line2.Location = new System.Drawing.Point(179, 275);
            this.pnl_Line2.Name = "pnl_Line2";
            this.pnl_Line2.Size = new System.Drawing.Size(143, 2);
            this.pnl_Line2.TabIndex = 6;
            // 
            // pnl_Line
            // 
            this.pnl_Line.BackColor = System.Drawing.Color.Gray;
            this.pnl_Line.Location = new System.Drawing.Point(179, 172);
            this.pnl_Line.Name = "pnl_Line";
            this.pnl_Line.Size = new System.Drawing.Size(143, 2);
            this.pnl_Line.TabIndex = 6;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(160, 226);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(82, 22);
            this.lbl_Pass.TabIndex = 5;
            this.lbl_Pass.Text = "Mật khẩu";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(160, 127);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 22);
            this.lbl_User.TabIndex = 5;
            this.lbl_User.Text = "Tài khoản";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txt_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassWord.ForeColor = System.Drawing.Color.White;
            this.txt_PassWord.Location = new System.Drawing.Point(190, 255);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(132, 23);
            this.txt_PassWord.TabIndex = 1;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.Enter += new System.EventHandler(this.txt_PassWord_Enter);
            this.txt_PassWord.Leave += new System.EventHandler(this.txt_PassWord_Leave);
            // 
            // lbl_SubTitle
            // 
            this.lbl_SubTitle.AutoSize = true;
            this.lbl_SubTitle.Location = new System.Drawing.Point(186, 62);
            this.lbl_SubTitle.Name = "lbl_SubTitle";
            this.lbl_SubTitle.Size = new System.Drawing.Size(124, 22);
            this.lbl_SubTitle.TabIndex = 4;
            this.lbl_SubTitle.Text = "ĐĂNG NHẬP";
            this.lbl_SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Title.Location = new System.Drawing.Point(3, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(570, 25);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "CHÀO MỪNG ĐẾN VỚI RẠP PHIM SỐ 1 VIỆT NAM";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1020, 410);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt_Logo)).EndInit();
            this.pnl_Right.ResumeLayout(false);
            this.pnl_Right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pt_Logo;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ImageList img_Icon;
        private System.Windows.Forms.Label lbl_SubTitle;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Panel pnl_Line;
        private System.Windows.Forms.Label lbl_l1;
        private System.Windows.Forms.Label lbl_l2;
        private System.Windows.Forms.Label lbl_l4;
        private System.Windows.Forms.Label lbl_l3;
        private System.Windows.Forms.Panel pnl_Line2;
        private System.Windows.Forms.TextBox txt_PassWord;
    }
}