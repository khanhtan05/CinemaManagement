using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLRP.DTO
{
    public class DTO_NhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }

    }
}
