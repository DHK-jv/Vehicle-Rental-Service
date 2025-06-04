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
    public class BLL_QuanLyNhanVien
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        DAL_QuanLyNhanVien dalNhanVien = new DAL_QuanLyNhanVien();

        public DataTable getListNhanVien()
        {
            return dalNhanVien.getListNhanVien();
        }

        public DataTable LayThongTinNhanVien(string maNV)
        {
            return dalNhanVien.getThongTinNhanVien(maNV);
        }
        public DataTable LayThongTinTheoMaNV(string key)
        {
            return dalNhanVien.LayThongTinTheoMaNV(key);
        }
        public DataTable Search(string key)
        {
            return dalNhanVien.Search(key);
        }
        public bool ThemNhanVien(NhanVien x, TaiKhoan tk)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(x.MaNV))
            {
                throw new BusinessLogicException("Mã nhân viên không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TenNV))
            {
                throw new BusinessLogicException("Tên nhân viên không được để trống");
            }
            if (x.NgaySinh == null && x.NgaySinh < DateTime.Today)
            {
                throw new BusinessLogicException("Ngày sinh không hợp lệ");
            }
            if (string.IsNullOrWhiteSpace(x.GioiTinh))
            {
                throw new BusinessLogicException("Giới tính không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.SoDT))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.DiaChi))
            {
                throw new BusinessLogicException("Địa chỉ không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.UserName))
            {
                throw new BusinessLogicException("Tên người dùng không được để trống");
            }
            return dalNhanVien.
                ThemNhanVien(x, tk);
        }
        public bool CapNhatNhanVien(NhanVien x, TaiKhoan tk)
        {
            if (string.IsNullOrWhiteSpace(x.MaNV))
            {
                throw new BusinessLogicException("Mã nhân viên không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TenNV))
            {
                throw new BusinessLogicException("Tên nhân viên không được để trống");
            }
            if (x.NgaySinh == null && x.NgaySinh < DateTime.Today)
            {
                throw new BusinessLogicException("Ngày sinh không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.GioiTinh))
            {
                throw new BusinessLogicException("Giới tính không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.SoDT))
            {
                throw new BusinessLogicException("Số điện thoại không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.DiaChi))
            {
                throw new BusinessLogicException("Địa chỉ không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.UserName))
            {
                throw new BusinessLogicException("Tên người dùng không được để trống");
            }
            return dalNhanVien.CapNhatNhanVien(x, tk);
        }
        public bool XoaNhanVien(string key)
        {
            return dalNhanVien.XoaNhanVien(key);
        }
    }
}
