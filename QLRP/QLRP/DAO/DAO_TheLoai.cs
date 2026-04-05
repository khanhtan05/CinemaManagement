using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLRP.DAO
{
    public class DAO_TheLoai
    {
        // Tạo Singleton để gọi hàm dễ dàng mà không cần new nhiều lần
        private static DAO_TheLoai instance;
        public static DAO_TheLoai Instance
        {
            get { if (instance == null) instance = new DAO_TheLoai(); return instance; }
            private set { instance = value; }
        }

        private DAO_TheLoai() { }

        // Hàm lấy danh sách Thể loại (Đã nối sẵn chuỗi Mã - Tên)
        public DataTable GetListTheLoai()
        {
            string query = "SELECT MaTheLoai, CONCAT(MaTheLoai, ' - ', TenTheLoai) AS TenHienThi FROM TheLoai";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool InsertTheLoai(string ten)
        {
            string query = string.Format("INSERT INTO TheLoai (TenTheLoai) VALUES (N'{0}')", ten);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Sửa thể loại
        public bool UpdateTheLoai(string ma, string ten)
        {
            string query = string.Format("UPDATE TheLoai SET TenTheLoai = N'{0}' WHERE MaTheLoai = '{1}'", ten, ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Xóa thể loại
        public bool DeleteTheLoai(string ma)
        {
            // Lưu ý: Cần kiểm tra ràng buộc khóa ngoại với bảng Phim trước khi xóa
            string query = string.Format("DELETE FROM TheLoai WHERE MaTheLoai = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}