using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.DTO
{
    public class Xe
    {
        public string MaXe;
        public string TenXe;
        public string BienSo;
        public string MauSac;
        public string TinhTrang;
        public int SoLuong;
        public string HinhAnh;
        public Decimal GiaThue;
        public DateTime NamSanXuat; 
        public string LoaiXe;
        public string MaHX;

        public string getMaXe()
        {
            return MaXe;
        }
        public void setMaXe(string value)
        {
            this.MaXe = value;
        }

        public string getTenXe()
        {
            return TenXe;
        }
        public void setTenXe(string value)
        {
            this.TenXe = value;
        }

        public string getBienSo()
        {
            return BienSo;
        }
        public void setBienSo(string value)
        {
            this.BienSo = value;
        }

        public string getMauSac()
        {
            return MauSac;
        }
        public void setMauSac(string value)
        {
            this.MauSac = value;
        }

        public string getTinhTrang()
        {
            return TinhTrang;
        }

        public void setTinhTrang(string value)
        {
            this.TinhTrang = value;
        }

        public int getSoLuong()
        {
            return SoLuong;
        }

        public void setSoLuong(int value)
        {
            this.SoLuong = value;
        }

        public string getHinhAnh()
        {
            return HinhAnh;
        }

        public void setHinhAnh(string value)
        {
            this.HinhAnh = value;
        }

        public Decimal getGiaThue()
        {
            return GiaThue;
        }

        public void setGiaThue(Decimal value)
        {
            this.GiaThue = value;
        }

        public DateTime getNamSanXuat()
        {
            return NamSanXuat;
        }

        public void setNamSanXuat(DateTime value)
        {
            this.NamSanXuat = value;
        }

        public string getLoaiXe()
        {
            return LoaiXe;
        }

        public void setLoaiXe(string value)
        {
            this.LoaiXe = value;
        }

        public string getMaHX()
        {
            return MaHX;
        }

        public void setMaHX(string value)
        {
            this.MaHX = value;
        }



        public Xe(string maXe, string tenXe, string bienSo, string mauSac, string tinhTrang, int soLuong, string hinhAnh, Decimal giaThue, DateTime namSanXuat, string loaiXe, string maHX)
        {
            MaXe = maXe;
            TenXe = tenXe;
            BienSo = bienSo;
            MauSac = mauSac;
            TinhTrang = tinhTrang;
            SoLuong = soLuong;
            HinhAnh = hinhAnh;
            GiaThue = giaThue;
            NamSanXuat = namSanXuat;
            LoaiXe = loaiXe;
            MaHX = maHX;
        }

        public Xe()
        {
            MaXe = string.Empty;
            TenXe = string.Empty;
            BienSo = string.Empty;
            MauSac = string.Empty;
            TinhTrang = string.Empty;
            SoLuong = 0;
            HinhAnh = string.Empty;
            GiaThue = Decimal.Zero;
            NamSanXuat = DateTime.Now;
            LoaiXe = string.Empty;
            MaHX = string.Empty;
        }
    }
}
