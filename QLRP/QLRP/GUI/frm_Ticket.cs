using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP.GUI
{
    public partial class frm_Ticket : Form
    {
        public frm_Ticket()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void frm_Ticket_Load(object sender, EventArgs e)
        {

            this.rpt_TK.RefreshReport();
        }
    }
}
