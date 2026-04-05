using QLRP.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP.BUS
{
    public class BUS_TheLoai
    {
        private static BUS_TheLoai instance;
        public static BUS_TheLoai Instance
        {
            get { if (instance == null) instance = new BUS_TheLoai(); return instance; }
            private set { instance = value; }
        }

        private BUS_TheLoai() { }

        public DataTable GetListTheLoai()
        {
            // Gọi hàm từ DAO lên
            return DAO_TheLoai.Instance.GetListTheLoai();
        }

        public bool InsertTheLoai(string ten)
        {
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập Tên thể loại!");
                return false;
            }
            return DAO_TheLoai.Instance.InsertTheLoai(ten);
        }
        public bool UpdateTheLoai(string ma, string ten)
        {
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên thể loại không được để trống!");
                return false;
            }
            return DAO_TheLoai.Instance.UpdateTheLoai(ma, ten);
        }

        // Nghiệp vụ Xóa
        public bool DeleteTheLoai(string ma)
        {
            if (string.IsNullOrEmpty(ma)) return false;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return DAO_TheLoai.Instance.DeleteTheLoai(ma);
            }
            return false;
        }
    }
}