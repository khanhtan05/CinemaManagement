namespace QLRP.GUI
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.pnl_Ticket = new System.Windows.Forms.Panel();
            this.pt_Logo = new System.Windows.Forms.PictureBox();
            this.btn_PrintTicket = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Staff = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Seat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MovieName = new System.Windows.Forms.Label();
            this.lbl_TicketID = new System.Windows.Forms.Label();
            this.pnl_Ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Ticket
            // 
            this.pnl_Ticket.Controls.Add(this.pt_Logo);
            this.pnl_Ticket.Controls.Add(this.btn_PrintTicket);
            this.pnl_Ticket.Controls.Add(this.lbl_Staff);
            this.pnl_Ticket.Controls.Add(this.label5);
            this.pnl_Ticket.Controls.Add(this.lbl_Price);
            this.pnl_Ticket.Controls.Add(this.label6);
            this.pnl_Ticket.Controls.Add(this.lbl_Seat);
            this.pnl_Ticket.Controls.Add(this.label4);
            this.pnl_Ticket.Controls.Add(this.lbl_Room);
            this.pnl_Ticket.Controls.Add(this.label3);
            this.pnl_Ticket.Controls.Add(this.lbl_Time);
            this.pnl_Ticket.Controls.Add(this.label2);
            this.pnl_Ticket.Controls.Add(this.lbl_Date);
            this.pnl_Ticket.Controls.Add(this.label1);
            this.pnl_Ticket.Controls.Add(this.lbl_MovieName);
            this.pnl_Ticket.Controls.Add(this.lbl_TicketID);
            this.pnl_Ticket.Location = new System.Drawing.Point(13, 13);
            this.pnl_Ticket.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Ticket.Name = "pnl_Ticket";
            this.pnl_Ticket.Size = new System.Drawing.Size(456, 537);
            this.pnl_Ticket.TabIndex = 2;
            // 
            // pt_Logo
            // 
            this.pt_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pt_Logo.Image")));
            this.pt_Logo.Location = new System.Drawing.Point(331, -1);
            this.pt_Logo.Name = "pt_Logo";
            this.pt_Logo.Size = new System.Drawing.Size(122, 86);
            this.pt_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Logo.TabIndex = 2;
            this.pt_Logo.TabStop = false;
            // 
            // btn_PrintTicket
            // 
            this.btn_PrintTicket.FlatAppearance.BorderSize = 0;
            this.btn_PrintTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_PrintTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_PrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintTicket.ImageIndex = 0;
            this.btn_PrintTicket.ImageList = this.imageList1;
            this.btn_PrintTicket.Location = new System.Drawing.Point(178, 489);
            this.btn_PrintTicket.Name = "btn_PrintTicket";
            this.btn_PrintTicket.Size = new System.Drawing.Size(67, 45);
            this.btn_PrintTicket.TabIndex = 1;
            this.btn_PrintTicket.UseVisualStyleBackColor = true;
            this.btn_PrintTicket.Click += new System.EventHandler(this.btn_PrintTicket_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "printer.png");
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.Location = new System.Drawing.Point(147, 13);
            this.lbl_Staff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(90, 22);
            this.lbl_Staff.TabIndex = 0;
            this.lbl_Staff.Text = "Nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá vé:";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(128, 448);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(63, 22);
            this.lbl_Price.TabIndex = 0;
            this.lbl_Price.Text = "Giá vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghế:";
            // 
            // lbl_Seat
            // 
            this.lbl_Seat.AutoSize = true;
            this.lbl_Seat.Location = new System.Drawing.Point(147, 331);
            this.lbl_Seat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seat.Name = "lbl_Seat";
            this.lbl_Seat.Size = new System.Drawing.Size(42, 22);
            this.lbl_Seat.TabIndex = 0;
            this.lbl_Seat.Text = "Ghế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phòng chiếu:";
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Location = new System.Drawing.Point(147, 262);
            this.lbl_Room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(105, 22);
            this.lbl_Room.TabIndex = 0;
            this.lbl_Room.Text = "Phòng chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suất Chiếu:";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(147, 186);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(103, 22);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "Giờ bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày chiếu:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(147, 113);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(98, 22);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Ngày chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name:";
            // 
            // lbl_MovieName
            // 
            this.lbl_MovieName.AutoSize = true;
            this.lbl_MovieName.Location = new System.Drawing.Point(147, 54);
            this.lbl_MovieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MovieName.Name = "lbl_MovieName";
            this.lbl_MovieName.Size = new System.Drawing.Size(113, 22);
            this.lbl_MovieName.TabIndex = 0;
            this.lbl_MovieName.Text = "Movie Name";
            // 
            // lbl_TicketID
            // 
            this.lbl_TicketID.AutoSize = true;
            this.lbl_TicketID.Location = new System.Drawing.Point(21, 13);
            this.lbl_TicketID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TicketID.Name = "lbl_TicketID";
            this.lbl_TicketID.Size = new System.Drawing.Size(36, 22);
            this.lbl_TicketID.TabIndex = 0;
            this.lbl_TicketID.Text = "ID:";
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 556);
            this.Controls.Add(this.pnl_Ticket);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.pnl_Ticket.ResumeLayout(false);
            this.pnl_Ticket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Ticket;
        private System.Windows.Forms.Label lbl_TicketID;
        private System.Windows.Forms.Label lbl_Staff;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Seat;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_MovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PrintTicket;
        private System.Windows.Forms.PictureBox pt_Logo;
        private System.Windows.Forms.ImageList imageList1;
    }
}