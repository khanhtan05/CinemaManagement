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

namespace QLRP.GUI
{
    public partial class frm_Login : Form
    {
        BUS_NhanVien bus = new BUS_NhanVien();

        public frm_Login()
        {
            InitializeComponent();
            this.AcceptButton = btn_Login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Account = txt_Account.Text.Trim();
            string PassWord = txt_PassWord.Text.Trim();
            var NhanVien = bus.DangNhap(Account, PassWord);
            if (NhanVien != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                frm_main fm = new frm_main(NhanVien);
                fm.Show();
              
            }    
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                txt_PassWord.Focus();
            }    
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_Account.Focus();
        }

        private void txt_PassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Account_Enter(object sender, EventArgs e)
        {
            pnl_Line.BackColor = Color.Cyan;
            lbl_User.Location = new Point(lbl_User.Location.X, lbl_User.Location.Y - 15);
            lbl_l1.ForeColor = Color.Cyan;
            lbl_l2.ForeColor = Color.Cyan;
        }

        private void txt_Account_Leave(object sender, EventArgs e)
        {
            pnl_Line.BackColor = Color.Gray;
            lbl_User.Location = new Point(lbl_User.Location.X, lbl_User.Location.Y + 15);
            lbl_l1.ForeColor = Color.White;
            lbl_l2.ForeColor = Color.White;
        }

        private void txt_PassWord_Enter(object sender, EventArgs e)
        {
            pnl_Line2.BackColor = Color.Cyan;
            lbl_Pass.Location = new Point(lbl_Pass.Location.X, lbl_Pass.Location.Y - 15);
            lbl_l3.ForeColor = Color.Cyan;
            lbl_l4.ForeColor = Color.Cyan;
        }

        private void txt_PassWord_Leave(object sender, EventArgs e)
        {
            pnl_Line2.BackColor = Color.Gray;
            lbl_Pass.Location = new Point(lbl_Pass.Location.X, lbl_Pass.Location.Y + 15);
            lbl_l3.ForeColor = Color.White;
            lbl_l4.ForeColor = Color.White;
        }
    }
    
}
