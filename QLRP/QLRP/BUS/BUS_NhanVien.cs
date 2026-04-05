using QLRP.DAO;
using QLRP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP.BUS
{
    internal class BUS_NhanVien
    {

        DAO_NhanVien NhanVien = new DAO_NhanVien();
        private static BUS_NhanVien instance;
        public static BUS_NhanVien Instance => instance ?? (instance = new BUS_NhanVien());

        // Sử dụng biến cục bộ để gọi DAO cho các hàm không dùng Static Instance
        DAO_NhanVien daoNV = new DAO_NhanVien();

        // 2. Lấy danh sách nhân viên
        public DataTable GetList() => DAO_NhanVien.Instance.GetListNhanVien();

        // 3. Thêm nhân viên (Sửa lỗi gọi sai tên NhanVienDAO -> DAO_NhanVien)
        public bool ThemNV(string ma, string ten, string sdt, string tk, string mk, string vt, string hinh)
        {
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(tk))
                return false;

            return DAO_NhanVien.Instance.InsertNhanVien(ten, sdt, tk, mk, vt, hinh);
        }
        public bool SuaNV(string ma, string ten, string sdt, string tk, string mk, string vt, string hinh)
        {
            if (string.IsNullOrEmpty(ten)) return false;
            return DAO_NhanVien.Instance.UpdateNhanVien(ma, ten, sdt, tk, mk, vt, hinh);
        }

        public bool XoaNV(string ma)
        {
            if (string.IsNullOrEmpty(ma)) return false;
            return DAO_NhanVien.Instance.DeleteNhanVien(ma);
        }

        public DTO_NhanVien DangNhap(string StrTaiKhoan, string StrPassWord)
        {
            if (string.IsNullOrEmpty(StrTaiKhoan) || string.IsNullOrEmpty(StrPassWord))
            {
                return null;
            }
            return NhanVien.Login(StrTaiKhoan, StrPassWord);


        }
        public bool DoiMatKhau(string user, string newPass)
        {
            return NhanVien.UpdateMatKhau(user, newPass);
        }
    }
}
