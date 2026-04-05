using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLRP.DTO
{
    internal class DTO_KhachHang
    {
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set;}
        public string DienThoai { get;set;}

        public DTO_KhachHang()
        {
            MaKhachHang = 0;
            TenKhachHang = string.Empty;
            DienThoai = string.Empty;
        }
    }
}
