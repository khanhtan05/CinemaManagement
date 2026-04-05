using QLRP.DTO; // Nhớ using namespace của bạn
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DAO
{
    public class PhimDAO
    {
        private static PhimDAO instance;
        public static PhimDAO Instance
        {
            get { if (instance == null) instance = new PhimDAO(); return instance; }
            private set { instance = value; }
        }

        private PhimDAO() { }

        // Lấy danh sách phim
        public DataTable GetListPhim()
        {
            string query = "SELECT * FROM Phim";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        
        // Thêm phim
        public bool InsertPhim(string tenPhim, int thoiLuong, DateTime ngay, string moTa, string poster, int maTL)
        {
            string query = string.Format("INSERT INTO Phim (TenPhim, ThoiLuong, NgayKhoiChieu, MoTa, Poster, MaTheLoai) VALUES (N'{0}', {1}, '{2}', N'{3}', N'{4}', {5})",
                tenPhim, thoiLuong, ngay.ToString("yyyy-MM-dd"), moTa, poster, maTL);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Sửa phim
        public bool UpdatePhim(int maPhim, string tenPhim, int thoiLuong, DateTime ngay, string moTa, string poster, int maTL)
        {
            string query = string.Format("UPDATE Phim SET TenPhim = N'{0}', ThoiLuong = {1}, NgayKhoiChieu = '{2}', MoTa = N'{3}', Poster = N'{4}', MaTheLoai = {5} WHERE MaPhim = {6}",
                tenPhim, thoiLuong, ngay.ToString("yyyy-MM-dd"), moTa, poster, maTL, maPhim);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Xóa phim
        public bool DeletePhim(int maPhim)
        {
            string query = "DELETE FROM Phim WHERE MaPhim = " + maPhim;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
