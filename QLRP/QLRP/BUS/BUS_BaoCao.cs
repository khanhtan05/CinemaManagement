using QLRP.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.BUS
{
    public class BUS_BaoCao
    {
        DAO_BaoCao dao = new DAO_BaoCao();

        public DataTable Ngay(DateTime ngay)
        {
            return dao.GetDoanhThuNgay(ngay);
        }

        public DataTable Thang(int nam)
        {
            return dao.GetDoanhThuTuDauNam(nam);
        }

        public DataTable Phim()
        {
            return dao.GetDoanhThuPhim();
        }
    }
}
