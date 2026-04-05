using QLRP.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.BUS
{
    public class BUS_Phim
    {
        private static BUS_Phim instance;
        public static BUS_Phim Instance
        {
            get { if (instance == null) instance = new BUS_Phim(); return instance; }
            private set { instance = value; }
        }

        private BUS_Phim() { }

        public DataTable GetListPhim()
        {
            return PhimDAO.Instance.GetListPhim();
        }

        public bool InsertPhim(string tenPhim, int thoiLuong, DateTime ngay, string moTa, string poster, int maTL)
        {
            // Kiểm tra logic: Thời lượng phải > 0
            if (thoiLuong <= 0) return false;
            return PhimDAO.Instance.InsertPhim(tenPhim, thoiLuong, ngay, moTa, poster, maTL);
        }

        public bool UpdatePhim(int maPhim, string tenPhim, int thoiLuong, DateTime ngay, string moTa, string poster, int maTL)
        {
            if (thoiLuong <= 0) return false;
            return PhimDAO.Instance.UpdatePhim(maPhim, tenPhim, thoiLuong, ngay, moTa, poster, maTL);
        }

        public bool DeletePhim(int maPhim)
        {
            return PhimDAO.Instance.DeletePhim(maPhim);
        }
    }
}
