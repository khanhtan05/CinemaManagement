namespace QLRP.GUI
{
    partial class frm_UpdatePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UpdatePass));
            this.btn_Update = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_l4 = new System.Windows.Forms.Label();
            this.lbl_l2 = new System.Windows.Forms.Label();
            this.lbl_l3 = new System.Windows.Forms.Label();
            this.lbl_l1 = new System.Windows.Forms.Label();
            this.pnl_Line2 = new System.Windows.Forms.Panel();
            this.pnl_Line = new System.Windows.Forms.Panel();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.txt_Pass2 = new System.Windows.Forms.TextBox();
            this.lbl_Pass2 = new System.Windows.Forms.Label();
            this.pnl_Line3 = new System.Windows.Forms.Panel();
            this.lbl_l5 = new System.Windows.Forms.Label();
            this.lbl_l6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.ImageIndex = 0;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(130, 339);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(102, 43);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "password.png");
            // 
            // lbl_l4
            // 
            this.lbl_l4.AutoSize = true;
            this.lbl_l4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l4.ForeColor = System.Drawing.Color.White;
            this.lbl_l4.Location = new System.Drawing.Point(245, 190);
            this.lbl_l4.Name = "lbl_l4";
            this.lbl_l4.Size = new System.Drawing.Size(20, 25);
            this.lbl_l4.TabIndex = 14;
            this.lbl_l4.Text = "]";
            // 
            // lbl_l2
            // 
            this.lbl_l2.AutoSize = true;
            this.lbl_l2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l2.ForeColor = System.Drawing.Color.White;
            this.lbl_l2.Location = new System.Drawing.Point(245, 91);
            this.lbl_l2.Name = "lbl_l2";
            this.lbl_l2.Size = new System.Drawing.Size(20, 25);
            this.lbl_l2.TabIndex = 15;
            this.lbl_l2.Text = "]";
            // 
            // lbl_l3
            // 
            this.lbl_l3.AutoSize = true;
            this.lbl_l3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l3.ForeColor = System.Drawing.Color.White;
            this.lbl_l3.Location = new System.Drawing.Point(105, 190);
            this.lbl_l3.Name = "lbl_l3";
            this.lbl_l3.Size = new System.Drawing.Size(20, 25);
            this.lbl_l3.TabIndex = 16;
            this.lbl_l3.Text = "[";
            // 
            // lbl_l1
            // 
            this.lbl_l1.AutoSize = true;
            this.lbl_l1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l1.ForeColor = System.Drawing.Color.White;
            this.lbl_l1.Location = new System.Drawing.Point(105, 91);
            this.lbl_l1.Name = "lbl_l1";
            this.lbl_l1.Size = new System.Drawing.Size(20, 25);
            this.lbl_l1.TabIndex = 17;
            this.lbl_l1.Text = "[";
            // 
            // pnl_Line2
            // 
            this.pnl_Line2.BackColor = System.Drawing.Color.Gray;
            this.pnl_Line2.Location = new System.Drawing.Point(110, 214);
            this.pnl_Line2.Name = "pnl_Line2";
            this.pnl_Line2.Size = new System.Drawing.Size(143, 2);
            this.pnl_Line2.TabIndex = 12;
            // 
            // pnl_Line
            // 
            this.pnl_Line.BackColor = System.Drawing.Color.Gray;
            this.pnl_Line.Location = new System.Drawing.Point(110, 111);
            this.pnl_Line.Name = "pnl_Line";
            this.pnl_Line.Size = new System.Drawing.Size(143, 2);
            this.pnl_Line.TabIndex = 13;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(91, 165);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(82, 22);
            this.lbl_Pass.TabIndex = 10;
            this.lbl_Pass.Text = "Mật khẩu";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(91, 66);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 22);
            this.lbl_User.TabIndex = 11;
            this.lbl_User.Text = "Tài khoản";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txt_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassWord.ForeColor = System.Drawing.Color.White;
            this.txt_PassWord.Location = new System.Drawing.Point(121, 194);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(132, 23);
            this.txt_PassWord.TabIndex = 1;
            this.txt_PassWord.UseSystemPasswordChar = true;
            this.txt_PassWord.Enter += new System.EventHandler(this.txt_PassWord_Enter);
            this.txt_PassWord.Leave += new System.EventHandler(this.txt_PassWord_Leave);
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txt_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Account.ForeColor = System.Drawing.Color.White;
            this.txt_Account.Location = new System.Drawing.Point(121, 91);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(132, 23);
            this.txt_Account.TabIndex = 0;
            this.txt_Account.TextChanged += new System.EventHandler(this.txt_Account_TextChanged);
            this.txt_Account.Enter += new System.EventHandler(this.txt_Account_Enter);
            this.txt_Account.Leave += new System.EventHandler(this.txt_Account_Leave);
            // 
            // txt_Pass2
            // 
            this.txt_Pass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txt_Pass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass2.ForeColor = System.Drawing.Color.White;
            this.txt_Pass2.Location = new System.Drawing.Point(121, 286);
            this.txt_Pass2.Name = "txt_Pass2";
            this.txt_Pass2.Size = new System.Drawing.Size(132, 23);
            this.txt_Pass2.TabIndex = 2;
            this.txt_Pass2.UseSystemPasswordChar = true;
            this.txt_Pass2.Enter += new System.EventHandler(this.txt_Pass2_Enter);
            this.txt_Pass2.Leave += new System.EventHandler(this.txt_Pass2_Leave);
            // 
            // lbl_Pass2
            // 
            this.lbl_Pass2.AutoSize = true;
            this.lbl_Pass2.Location = new System.Drawing.Point(91, 257);
            this.lbl_Pass2.Name = "lbl_Pass2";
            this.lbl_Pass2.Size = new System.Drawing.Size(82, 22);
            this.lbl_Pass2.TabIndex = 10;
            this.lbl_Pass2.Text = "Mật khẩu";
            // 
            // pnl_Line3
            // 
            this.pnl_Line3.BackColor = System.Drawing.Color.Gray;
            this.pnl_Line3.Location = new System.Drawing.Point(110, 306);
            this.pnl_Line3.Name = "pnl_Line3";
            this.pnl_Line3.Size = new System.Drawing.Size(143, 2);
            this.pnl_Line3.TabIndex = 12;
            // 
            // lbl_l5
            // 
            this.lbl_l5.AutoSize = true;
            this.lbl_l5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l5.ForeColor = System.Drawing.Color.White;
            this.lbl_l5.Location = new System.Drawing.Point(105, 282);
            this.lbl_l5.Name = "lbl_l5";
            this.lbl_l5.Size = new System.Drawing.Size(20, 25);
            this.lbl_l5.TabIndex = 16;
            this.lbl_l5.Text = "[";
            // 
            // lbl_l6
            // 
            this.lbl_l6.AutoSize = true;
            this.lbl_l6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l6.ForeColor = System.Drawing.Color.White;
            this.lbl_l6.Location = new System.Drawing.Point(245, 282);
            this.lbl_l6.Name = "lbl_l6";
            this.lbl_l6.Size = new System.Drawing.Size(20, 25);
            this.lbl_l6.TabIndex = 14;
            this.lbl_l6.Text = "]";
            // 
            // frm_UpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.lbl_l6);
            this.Controls.Add(this.lbl_l4);
            this.Controls.Add(this.lbl_l2);
            this.Controls.Add(this.lbl_l5);
            this.Controls.Add(this.lbl_l3);
            this.Controls.Add(this.lbl_l1);
            this.Controls.Add(this.pnl_Line3);
            this.Controls.Add(this.pnl_Line2);
            this.Controls.Add(this.pnl_Line);
            this.Controls.Add(this.lbl_Pass2);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_Pass2);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.btn_Update);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_UpdatePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frm_UpdatePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_l4;
        private System.Windows.Forms.Label lbl_l2;
        private System.Windows.Forms.Label lbl_l3;
        private System.Windows.Forms.Label lbl_l1;
        private System.Windows.Forms.Panel pnl_Line2;
        private System.Windows.Forms.Panel pnl_Line;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.TextBox txt_Pass2;
        private System.Windows.Forms.Label lbl_Pass2;
        private System.Windows.Forms.Panel pnl_Line3;
        private System.Windows.Forms.Label lbl_l5;
        private System.Windows.Forms.Label lbl_l6;
    }
}