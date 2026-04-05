using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRP.BUS;
using QLRP.DTO;

namespace QLRP
{
    public partial class frm_QLKhachHang : Form
    {
        public frm_QLKhachHang()
        {
            InitializeComponent();
        }

        private void grp_ThongTinKhachHang_Enter(object sender, EventArgs e)
        {

        }

        private void frm_QLKhachHang_Load(object sender, EventArgs e)
        {
            BUS_KhachHang InfoCustomerList = new BUS_KhachHang();
            dgv_KhachHang.DataSource = InfoCustomerList.GetInfoCustomer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
