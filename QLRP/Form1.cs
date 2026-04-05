using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_main_Load(object sender, EventArgs e)
        {
           
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLKhachHang frm_KH = new frm_QLKhachHang();
            frm_KH.MdiParent = this;
            frm_KH.Show();
        }
    }
}
