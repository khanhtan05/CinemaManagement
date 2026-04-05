namespace QLRP.GUI
{
    partial class frm_DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoanhThu));
            this.rpt_DoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtReportDailytBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt_ReportDailyt = new QLRP.dt_ReportDailyt();
            ((System.ComponentModel.ISupportInitialize)(this.dtReportDailytBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ReportDailyt)).BeginInit();
            this.SuspendLayout();
            // 
            // rpt_DoanhThu
            // 
            this.rpt_DoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_DoanhThu.LocalReport.ReportEmbeddedResource = "QLRP.rpt_BaoCaoTheoNgay.rdlc";
            this.rpt_DoanhThu.Location = new System.Drawing.Point(0, 0);
            this.rpt_DoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpt_DoanhThu.Name = "rpt_DoanhThu";
            this.rpt_DoanhThu.ServerReport.BearerToken = null;
            this.rpt_DoanhThu.Size = new System.Drawing.Size(442, 583);
            this.rpt_DoanhThu.TabIndex = 0;
            // 
            // dtReportDailytBindingSource
            // 
            this.dtReportDailytBindingSource.DataSource = this.dt_ReportDailyt;
            this.dtReportDailytBindingSource.Position = 0;
            // 
            // dt_ReportDailyt
            // 
            this.dt_ReportDailyt.DataSetName = "dt_ReportDailyt";
            this.dt_ReportDailyt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 583);
            this.Controls.Add(this.rpt_DoanhThu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DOANH THU";
            this.Load += new System.EventHandler(this.frm_DoanhThuTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtReportDailytBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ReportDailyt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_DoanhThu;
        private System.Windows.Forms.BindingSource dtReportDailytBindingSource;
        private dt_ReportDailyt dt_ReportDailyt;
    }
}