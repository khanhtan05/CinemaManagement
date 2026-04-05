
using Microsoft.Reporting.WinForms;
using QLRP.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace QLRP.GUI
{
    public partial class frm_DoanhThu : Form
    {
        BUS_BaoCao bus = new BUS_BaoCao();

        public frm_DoanhThu()
        {
            InitializeComponent();
        }

        private void frm_DoanhThuTheoNgay_Load(object sender, EventArgs e)
        {
            // Load mặc định theo ngày hôm nay

            //LoadReport("Ngay", ngay: DateTime.Now);
        }

        public void LoadReport(string loaiBaoCao, int? thang = null, int? nam = null, DateTime? ngay = null)
        {
            try
            {
                DataTable dt = new DataTable();

                string rdlcPath = Application.StartupPath + @"\rpt_BaoCao.rdlc";
                string dsName = "DS_DoanhThu";
                string tieuDeHienThi = "";
                string Header = "";


                // 1. Lấy dữ liệu
                if (loaiBaoCao == "Phim")
                {
                    dt = bus.Phim();
                    tieuDeHienThi = "BÁO CÁO DOANH THU THEO PHIM";
                    Header = "Phim";
                }
                else if (loaiBaoCao == "Thang")
                {
                    if (nam == null)
                    {
                        MessageBox.Show("Thiếu tháng hoặc năm!");
                        return;
                    }

                    dt = bus.Thang(nam.Value);
                    tieuDeHienThi = $"BÁO CÁO DOANH THU THÁNG {thang}/{nam}";
                    Header = "Tháng";
                }
                else
                {
                    dt = bus.Ngay(ngay ?? DateTime.Now);
                    tieuDeHienThi = "BÁO CÁO DOANH THU THEO NGÀY";
                    Header = "Ngày";
                }

                // 2. Gán report
                rpt_DoanhThu.LocalReport.ReportPath = rdlcPath;
                rpt_DoanhThu.LocalReport.DataSources.Clear();

                // 3. Parameter tiêu đề
                ReportParameter p = new ReportParameter("paTieuDe", tieuDeHienThi);
                rpt_DoanhThu.LocalReport.SetParameters(p);

                ReportParameter p2 = new ReportParameter("paCot1", Header);
                rpt_DoanhThu.LocalReport.SetParameters(p2);

                // 4. DataSource
                ReportDataSource rds = new ReportDataSource(dsName, dt);
                rpt_DoanhThu.LocalReport.DataSources.Add(rds);

                // 5. Refresh
                rpt_DoanhThu.RefreshReport();
       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }

    }
}
