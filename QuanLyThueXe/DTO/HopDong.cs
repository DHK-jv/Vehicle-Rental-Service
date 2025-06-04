using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.DTO
{
    public class HopDong
    {
        public string MaHD { get; set; }
        public DateTime NgayThue { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime HanTra { get; set; }
        public Decimal GiaThue { get; set; }
        public string TinhTrang { get; set; }
        public int SoLuong { get; set; }
        public Decimal PhiPhat { get; set; }
        public Decimal TongTienThue { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }

        public HopDong(string maHD, DateTime ngayThue, DateTime ngayTra, DateTime hanTra, Decimal giaThue, string tinhTrang, int soLuong, Decimal phiPhat, Decimal tongTienThue, string maKH, string maNV)
        {
            MaHD = maHD;
            NgayThue = ngayThue;
            NgayTra = ngayTra;
            HanTra = hanTra;
            GiaThue = giaThue;
            TinhTrang = tinhTrang;
            SoLuong = soLuong;
            PhiPhat = phiPhat;
            TongTienThue = tongTienThue;
            MaKH = maKH;
            MaNV = maNV;
        }

        public HopDong()
        {
            MaHD = string.Empty;
            NgayThue = DateTime.Now;
            NgayTra = DateTime.Now;
            HanTra = DateTime.Now;
            GiaThue = Decimal.Zero;
            TinhTrang = string.Empty;
            SoLuong = 0;
            PhiPhat = Decimal.Zero;
            TongTienThue = Decimal.Zero;
            MaKH = string.Empty;
            MaNV = string.Empty;
        }

    }
}
