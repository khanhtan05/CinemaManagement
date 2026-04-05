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
    public partial class frm_TheLoai : Form
    {
        public frm_TheLoai()
        {
            InitializeComponent();
            LoadListTheLoai();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (BUS_TheLoai.Instance.UpdateTheLoai(txt_MaTheLoai.Text, txt_TheLoai.Text))
            {
                MessageBox.Show("Thành công!");
                LoadListTheLoai();
            }
        }

        private void dvg_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_TheLoai.Rows[e.RowIndex];
                txt_MaTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                txt_TheLoai.Text = row.Cells["TenHienThi"].Value.ToString();
            }
        }
        void LoadListTheLoai()
        {
            dgv_TheLoai.DataSource = BUS_TheLoai.Instance.GetListTheLoai();
            dgv_TheLoai.Columns["MaTheLoai"].HeaderText = "Mã Thể Loại";
            dgv_TheLoai.Columns["TenHienThi"].HeaderText = "Tên Thể Loại";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (BUS_TheLoai.Instance.InsertTheLoai(txt_TheLoai.Text))
            {
                MessageBox.Show("Thành công!");
                LoadListTheLoai();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (BUS_TheLoai.Instance.DeleteTheLoai(txt_MaTheLoai.Text))
            {
                MessageBox.Show("Thành công!");
                LoadListTheLoai();
            }
        }
    }
}
