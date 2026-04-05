using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DAO
{
    public class DAO_BaoCao
    {
        // Doanh thu theo ngày
        public DataTable GetDoanhThuNgay(DateTime ngay)
        {
            string query = "EXEC USP_DoanhThu_Ngay @Ngay";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ngay });
        }

        // Doanh thu theo tháng
        public DataTable GetDoanhThuTuDauNam(int nam)
        {
            string query = "EXEC USP_DoanhThu_TuDauNam @Nam";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { nam });
        }

        // Doanh thu theo phim
        public DataTable GetDoanhThuPhim()
        {
            string query = "EXEC USP_DoanhThu_Phim";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
