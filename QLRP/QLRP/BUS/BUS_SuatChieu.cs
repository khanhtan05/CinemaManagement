using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLRP.DAO; // Thay bằng namespace thực tế của bạn

namespace QLRP.BUS
{
    public class BUS_SuatChieu
    {
        private static BUS_SuatChieu instance;
        public static BUS_SuatChieu Instance
        {
            get { if (instance == null) instance = new BUS_SuatChieu(); return instance; }
            private set { instance = value; }
        }

        private BUS_SuatChieu() { }

        public DataTable GetSuatChieuByMaPhim(int maPhim)
        {
            // Tầng BUS gọi tầng DAO
            return DAO_SuatChieu.Instance.GetSuatChieuByMaPhim(maPhim);
        }
        public bool AddSuatChieu(int maPhim, int maPhong, DateTime gioBatDau, float giaVe)
        {
            return DAO_SuatChieu.Instance.InsertSuatChieu(maPhim, maPhong, gioBatDau, giaVe);
        }
    }
}
