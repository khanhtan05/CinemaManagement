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
    public partial class frm_UpdatePass : Form
    {
        BUS_NhanVien bus = new BUS_NhanVien();
        string currentUser;

        public frm_UpdatePass()
        {
            InitializeComponent();
        }

        private void frm_UpdatePass_Load(object sender, EventArgs e)
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

        private void txt_Pass2_Enter(object sender, EventArgs e)
        {
            pnl_Line3.BackColor = Color.Cyan;
            lbl_Pass2.Location = new Point(lbl_Pass2.Location.X, lbl_Pass2.Location.Y - 15);
            lbl_l5.ForeColor = Color.Cyan;
            lbl_l6.ForeColor = Color.Cyan;
        }

        private void txt_Pass2_Leave(object sender, EventArgs e)
        {
            pnl_Line3.BackColor = Color.Gray;
            lbl_Pass2.Location = new Point(lbl_Pass2.Location.X, lbl_Pass2.Location.Y + 15);
            lbl_l5.ForeColor = Color.White;
            lbl_l6.ForeColor = Color.White;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string newPass = txt_PassWord.Text.Trim();
            string confirm = txt_Pass2.Text.Trim();
            currentUser = txt_Account.Text.Trim();

            // Validate
            if (newPass == "" || confirm == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải >= 6 ký tự!");
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!");
                return;
            }

            // Gọi BUS
            bool result = bus.DoiMatKhau(currentUser, newPass);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }

    
        }

        private void txt_Account_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
