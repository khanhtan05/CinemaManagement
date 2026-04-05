using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DTO
{
    public class PhimDTO
    {
        public int MaPhim { get; set; }
        public string TenPhim { get; set; }
        public int ThoiLuong { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public string MoTa { get; set; }
        public string Poster { get; set; }
        public int MaTheLoai { get; set; }

        public PhimDTO(int maPhim, string tenPhim, int thoiLuong, DateTime ngayKhoiChieu, string moTa, string poster, int maTheLoai)
        {
            this.MaPhim = maPhim;
            this.TenPhim = tenPhim;
            this.ThoiLuong = thoiLuong;
            this.NgayKhoiChieu = ngayKhoiChieu;
            this.MoTa = moTa;
            this.Poster = poster;
            this.MaTheLoai = maTheLoai;
        }

        public PhimDTO(DataRow row)
        {
            this.MaPhim = (int)row["MaPhim"];
            this.TenPhim = row["TenPhim"].ToString();
            this.ThoiLuong = (int)row["ThoiLuong"];
            this.NgayKhoiChieu = Convert.ToDateTime(row["NgayKhoiChieu"]);
            this.MoTa = row["MoTa"].ToString();
            this.Poster = row["Poster"].ToString();
            this.MaTheLoai = (int)row["MaTheLoai"];
        }
    }
}
