using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyThueXe.DTO
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public KhachHang(string maKH, string tenKH, DateTime ngaySinh, string gioiTinh, string cCCD, string soDT, string diaChi)
        {
            MaKH = maKH;
            TenKH = tenKH;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            CCCD = cCCD;
            SoDT = soDT;
            DiaChi = diaChi;

        }
        public KhachHang()
        {
            MaKH = string.Empty;
            TenKH = string.Empty;
            NgaySinh = DateTime.Now;
            GioiTinh = string.Empty;
            CCCD = string.Empty;
            SoDT = string.Empty;
            DiaChi = string.Empty;
        }
    }
}
        