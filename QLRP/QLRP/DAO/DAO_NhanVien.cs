using QLRP.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DAO
{
    public class DAO_NhanVien
    {
        string StrConnect = @"Data Source = .\SQLEXPRESS; Initial Catalog = CinemaManagement; Integrated Security = true;";
        private static DAO_NhanVien instance;
        public static DAO_NhanVien Instance
        {
            get
            {
                // Nếu chưa có đối tượng nào được tạo, thì tạo mới
                if (instance == null)
                    instance = new DAO_NhanVien();
                return instance;
            }
        }

        //string StrConnect = @"Data Source = .; Initial Catalog = CinemaManagement; Integrated Security = true;";
        public DTO_NhanVien Login(string Account, string PassWord)
        {
            SqlConnection conn = new SqlConnection(StrConnect);
            conn.Open();
            string StrQuery = "SELECT * FROM NhanVien WHERE TaiKhoan=@tk AND MatKhau=@mk";
            SqlCommand cmd = new SqlCommand(StrQuery, conn);
            cmd.Parameters.AddWithValue("@tk", Account);
            cmd.Parameters.AddWithValue("@mk", PassWord);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return new DTO_NhanVien()
                {
                    MaNhanVien = (int)dr["MaNhanVien"],
                    TenNhanVien = dr["TenNhanVien"].ToString(),
                    TaiKhoan = dr["TaiKhoan"].ToString(),
                    VaiTro = dr["VaiTro"].ToString(),
                };
            }
            return null;
        }

        public bool CheckMatKhau(string user, string pass)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @user AND MatKhau = @pass";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { user, pass });
            return (int)result > 0;
        }

        // Cập nhật mật khẩu
        public bool UpdateMatKhau(string user, string newPass)
        {
            string query = "UPDATE NhanVien SET MatKhau = @newPass WHERE TaiKhoan = @user";

            int result = DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[] { newPass, user }
            );

            return result > 0;
        }
        public DataTable GetListNhanVien()
        {
            // Lấy danh sách nhân viên, đặt tên cột tiếng Việt cho dgv
            string query = "SELECT MaNhanVien as [Mã NV], TenNhanVien as [Họ Tên], DienThoai as [SĐT], TaiKhoan as [Tài khoản], VaiTro as [Vai trò], HinhAnh as [HinhAnh] FROM NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertNhanVien(string ten, string sdt, string tk, string mk, string vt, string hinh)
        {
            // 1. Bỏ biến 'ma' vì SQL tự sinh ID.
            // 2. Liệt kê rõ tên cột để tránh nhầm lẫn.
            // 3. Đảm bảo đủ các vị trí {0} đến {5} cho 6 tham số.
            string query = string.Format(
                "INSERT INTO NhanVien (TenNhanVien, DienThoai, TaiKhoan, MatKhau, VaiTro, HinhAnh) " +
                "VALUES (N'{0}', '{1}', '{2}', '{3}', N'{4}', '{5}')",
                ten, sdt, tk, mk, vt, hinh);

            try
            {
                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex)
            {
                // Giúp bạn nhìn thấy lỗi chính xác nếu vẫn còn sai sót
                System.Windows.Forms.MessageBox.Show("Lỗi SQL: " + ex.Message);
                return false;
            }
        }
        public bool UpdateNhanVien(string ma, string ten, string sdt, string tk, string mk, string vt, string hinh)
        {
            // Sử dụng N'...' cho các cột chứa tiếng Việt (Họ tên, Vai trò)
            string query = string.Format("UPDATE NhanVien SET TenNhanVien = N'{1}', DienThoai = '{2}', TaiKhoan = '{3}', MatKhau = '{4}', VaiTro = N'{5}', HinhAnh = '{6}' WHERE MaNhanVien = '{0}'",
                                          ma, ten, sdt, tk, mk, vt, hinh);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // Hàm Xóa nhân viên
        public bool DeleteNhanVien(string ma)
        {
            string query = string.Format("DELETE FROM NhanVien WHERE MaNhanVien = '{0}'", ma);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
