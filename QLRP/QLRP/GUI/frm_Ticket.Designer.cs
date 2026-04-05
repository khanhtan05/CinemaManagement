namespace QLRP.GUI
{
    partial class frm_Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket));
            this.rpt_TK = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dt_DsCinema = new QLRP.Dt_DsCinema();
            this.dtDsCinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dt_DsCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDsCinemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpt_TK
            // 
            this.rpt_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_TK.LocalReport.ReportEmbeddedResource = "QLRP.rpt_Ticket.rdlc";
            this.rpt_TK.Location = new System.Drawing.Point(0, 0);
            this.rpt_TK.Name = "rpt_TK";
            this.rpt_TK.ServerReport.BearerToken = null;
            this.rpt_TK.Size = new System.Drawing.Size(436, 628);
            this.rpt_TK.TabIndex = 1;
            this.rpt_TK.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // dt_DsCinema
            // 
            this.dt_DsCinema.DataSetName = "Dt_DsCinema";
            this.dt_DsCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDsCinemaBindingSource
            // 
            this.dtDsCinemaBindingSource.DataSource = this.dt_DsCinema;
            this.dtDsCinemaBindingSource.Position = 0;
            // 
            // frm_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 628);
            this.Controls.Add(this.rpt_TK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VÉ";
            this.Load += new System.EventHandler(this.frm_Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_DsCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDsCinemaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtDsCinemaBindingSource;
        private Dt_DsCinema dt_DsCinema;
        public Microsoft.Reporting.WinForms.ReportViewer rpt_TK;
    }
}