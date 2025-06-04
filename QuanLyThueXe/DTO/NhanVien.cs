using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string UserName { get; set; }

        public NhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string soDT, string diaChi, string userName)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDT = soDT;
            DiaChi = diaChi;
            UserName = userName;
        }
        public NhanVien()
        {
            MaNV = string.Empty;
            TenNV = string.Empty;
            NgaySinh = DateTime.Now;
            GioiTinh = string.Empty;
            SoDT = string.Empty;
            DiaChi = string.Empty;
            UserName = string.Empty;
        }
    }
}