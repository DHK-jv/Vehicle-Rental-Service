using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThueXe.DAL;
using QuanLyThueXe.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThueXe.BLL
{
    public class BLL_QuanLyKhachHang
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        DAL_QuanLyKhachHang dalKhachHang = new DAL_QuanLyKhachHang();

        public DataTable getListKhachHang()
        {
            return dalKhachHang.getListKhachHang();
        }

        public DataTable LayThongTinKhachHang(string maKH)
        {
            return dalKhachHang.getThongTinKhachHang(maKH);
        }
        public DataTable LayThongTinTheoMaKH(string key)
        {
            return dalKhachHang.LayThongTinTheoMaKH(key);
        }
        public DataTable DanhSachTheoKhachHang(string maGioiTinh)
        {
            return dalKhachHang.PhanLoaiKhachHang(maGioiTinh);
        }


        public DataTable Search(string key)
        {
            return dalKhachHang.Search(key);
        }
        public bool ThemKhachHang(KhachHang x)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(x.MaKH))
            {
                throw new BusinessLogicException("Mã Khách hàng không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TenKH))
            {
                throw new BusinessLogicException("Tên Khách hàng không được để trống");
            }
            if (x.NgaySinh == null && x.NgaySinh < DateTime.Today)
            {
                throw new BusinessLogicException("Ngày sinh không hợp lệ");
            }
            if (string.IsNullOrWhiteSpace(x.GioiTinh))
            {
                throw new BusinessLogicException("CCCD không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.CCCD))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.SoDT))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.DiaChi))
            {
                throw new BusinessLogicException("Địa chỉ không được để trống");
            }
            
            return dalKhachHang.ThemKhachHang(x);
        }
        public bool CapNhatKhachHang(KhachHang x)
        {
            if (string.IsNullOrWhiteSpace(x.MaKH))
            {
                throw new BusinessLogicException("Mã khách hàng không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TenKH))
            {
                throw new BusinessLogicException("Tên khách hàng không được để trống");
            }
            if (x.NgaySinh == null && x.NgaySinh < DateTime.Today)
            {
                throw new BusinessLogicException("Ngày sinh không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.GioiTinh))
            {
                throw new BusinessLogicException("Giới tính không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.GioiTinh))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.SoDT))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.DiaChi))
            {
                throw new BusinessLogicException("Địa chỉ không được để trống");
            }
            
            return dalKhachHang.CapNhatKhacHang(x);
        }
        public bool XoaKhachHang(string maKH)
        {
            return dalKhachHang.XoaKhachHang(maKH);
        }
        
    }
}
