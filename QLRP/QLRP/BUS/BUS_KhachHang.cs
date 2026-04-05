using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DTO;
using QLRP.DAO;

namespace QLRP.BUS
{
    internal class BUS_KhachHang
    {
        DAO_KhachHang ListKhachHang = new DAO_KhachHang();
        public List<DTO_KhachHang> GetInfoCustomer()
        {
            return ListKhachHang.InfoKhachHang();
        }
    }
}
