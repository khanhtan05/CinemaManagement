using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLRP.DAO;

namespace QLRP.BUS
{
    public class BUS_PhongChieu
    {
        private static BUS_PhongChieu instance;
        public static BUS_PhongChieu Instance
        {
            get { if (instance == null) instance = new BUS_PhongChieu(); return instance; }
            private set { instance = value; }
        }

        private BUS_PhongChieu() { }

        public DataTable GetListPhongChieu()
        {
            return DAO_PhongChieu.Instance.GetListPhongChieu();
        }
    }
}
