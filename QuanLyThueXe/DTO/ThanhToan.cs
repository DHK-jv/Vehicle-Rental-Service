using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.DTO
{
    public class ThanhToan
    {
        public string MaTT { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public Decimal SoTien { get; set; }
        public string PhuongThucTT { get; set; }
        public string MaHD { get; set; }
        public string TinhTrang { get; set; }

        public ThanhToan(string maTT, DateTime ngayThanhToan, Decimal soTien, string phuongThucTT, string maHD, string tinhTrang)
        {
            MaTT = maTT;
            NgayThanhToan = ngayThanhToan;
            SoTien = soTien;
            PhuongThucTT = phuongThucTT;
            MaHD = maHD;
            TinhTrang = tinhTrang;
        }

        public ThanhToan()
        {
            MaTT = string.Empty;
            NgayThanhToan = DateTime.Now;
            SoTien = Decimal.Zero;
            PhuongThucTT = string.Empty;
            MaHD = string.Empty;
            TinhTrang = string.Empty;
        }

    }
}
