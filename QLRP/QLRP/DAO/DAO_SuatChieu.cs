using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DAO
{
    public class DAO_SuatChieu
    {
        // Thêm 3 dòng này để tạo Instance
        private static DAO_SuatChieu instance;
        public static DAO_SuatChieu Instance
        {
            get { if (instance == null) instance = new DAO_SuatChieu(); return instance; }
            private set { instance = value; }
        }

        private DAO_SuatChieu() { } // Hàm khởi tạo private

        public DataTable GetSuatChieuByMaPhim(int maPhim)
        {// Lấy cả các cột lẻ (cho DataGridView) và cột gộp (cho ComboBox)
            string query = "SELECT SC.MaSuatChieu, P.TenPhong, SC.GioBatDau, SC.GiaVe, " +
                           "FORMAT(SC.GioBatDau, 'HH:mm') + ' - ' + P.TenPhong AS ThongTinSuatChieu " +
                           "FROM SuatChieu SC JOIN PhongChieu P ON SC.MaPhong = P.MaPhong " +
                           "WHERE SC.MaPhim = " + maPhim;

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertSuatChieu(int maPhim, int maPhong, DateTime gioBatDau, float giaVe)
        {
            // Sử dụng tham số (Parameters) để tránh lỗi định dạng ngày tháng và SQL Injection
            string query = "INSERT INTO SuatChieu (MaPhim, MaPhong, GioBatDau, GiaVe) VALUES ( @maPhim , @maPhong , @gioBatDau , @giaVe )";

            // Nếu DataProvider của bạn hỗ trợ truyền mảng object:
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maPhim, maPhong, gioBatDau, giaVe });
            return result > 0;
        }
    }
}
