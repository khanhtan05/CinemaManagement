using System;
using System.Windows.Forms;
using System.Drawing;

namespace QLRP
{
  
    partial class ucMovie
    {
        private void ucMovie_Load(object sender, EventArgs e)
        {
            // Để trống cũng được, mục đích là để file Designer không báo lỗi
        }
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pt_Movie = new System.Windows.Forms.PictureBox();
            this.lbl_movie1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Movie)).BeginInit();
            this.SuspendLayout();
            // 
            // pt_Movie
            // 
            this.pt_Movie.Dock = System.Windows.Forms.DockStyle.Top;
            this.pt_Movie.Location = new System.Drawing.Point(0, 0);
            this.pt_Movie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pt_Movie.Name = "pt_Movie";
            this.pt_Movie.Size = new System.Drawing.Size(181, 230);
            this.pt_Movie.TabIndex = 1;
            this.pt_Movie.TabStop = false;
            // 
            // lbl_movie1
            // 
            this.lbl_movie1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_movie1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_movie1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movie1.Location = new System.Drawing.Point(0, 234);
            this.lbl_movie1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_movie1.Name = "lbl_movie1";
            this.lbl_movie1.Size = new System.Drawing.Size(181, 22);
            this.lbl_movie1.TabIndex = 2;
            this.lbl_movie1.Text = "label1";
            this.lbl_movie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_movie1.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // ucMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_movie1);
            this.Controls.Add(this.pt_Movie);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucMovie";
            this.Size = new System.Drawing.Size(181, 258);
            this.Load += new System.EventHandler(this.ucMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt_Movie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pt_Movie;
        private System.Windows.Forms.Label lbl_movie1;
    }
}
