using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLRP.DAO; // Thay bằng namespace DataProvider của bạn

namespace QLRP.DAO
{
    public class DAO_PhongChieu
    {
        private static DAO_PhongChieu instance;
        public static DAO_PhongChieu Instance
        {
            get { if (instance == null) instance = new DAO_PhongChieu(); return instance; }
            private set { instance = value; }
        }

        private DAO_PhongChieu() { }

        public DataTable GetListPhongChieu()
        {
            // Truy vấn đúng tên bảng PhongChieu trong DB của bạn
            string query = "SELECT MaPhong, TenPhong FROM PhongChieu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
