using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DTO;

namespace QLRP.DAO
{
    internal  class DAO_KhachHang
    {
        public List<DTO_KhachHang> InfoKhachHang()
        {
            List<DTO_KhachHang> Ls = new List<DTO_KhachHang>();
            string StrConnect = @"Data Source = .\SQLEXPRESS; Initial Catalog = CinemaManagement; Integrated Security = true;";
            //string StrConnect = @"Data Source = .; Initial Catalog = CinemaManagement; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(StrConnect);
            conn.Open();
            string StrSelect = "Select * From KhachHang";
            SqlCommand cmd = new SqlCommand(StrSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DTO_KhachHang Customer = new DTO_KhachHang();
                Customer.MaKhachHang = int.Parse(dr[0].ToString());
                Customer.TenKhachHang = dr[1].ToString();
                if (dr[2] != DBNull.Value)
                    Customer.DienThoai = dr[2].ToString();
                else
                    Customer.DienThoai = "";
                    Ls.Add(Customer);
            }
            dr.Close();
            conn.Close();
            return Ls;
        }
    }
}
