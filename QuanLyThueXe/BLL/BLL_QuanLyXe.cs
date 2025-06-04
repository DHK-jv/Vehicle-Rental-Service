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
    public class BLL_QuanLyXe
    {   
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        DAL_QuanLyXe dalXe = new DAL_QuanLyXe();

        public DataTable getListXe()
        {
            return dalXe.getListXe();
        }

        public DataTable LayThongTinXe(string maXe)
        {
            return dalXe.getThongTinXe(maXe);
        }
        public DataTable DanhSachTheoLoaiXe(string maLoaiXe)
        {
            return dalXe.PhanLoaiXe(maLoaiXe);
        }

        public DataTable GetTheLoai()
        {
            return dalXe.getListTheLoaiXe();
        }

        public DataTable LayThongTinTheoMaXe(string key)
        {
            return dalXe.LayThongTinTheoMaXe(key);
        }

        /*-------------------------------------Functions--------------------------------------------*/

        public DataTable Search(string key)
        {
            return dalXe.Search(key);
        }

        public bool ThemXe(Xe x)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(x.MaXe))
            {
                throw new BusinessLogicException("Mã xe không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TenXe))
            {
                throw new BusinessLogicException("Tên xe không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.MauSac))
            {
                throw new BusinessLogicException("Màu sắc không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TinhTrang))
            {
                throw new BusinessLogicException("Tình trạng không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.LoaiXe))
            {
                throw new BusinessLogicException("Loại xe không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.MaHX))
            {
                throw new BusinessLogicException("Mã hãng xe không được để trống");
            }
            if (x.NamSanXuat == null || x.NamSanXuat.Date > DateTime.Today)
            {
                throw new BusinessLogicException("Năm sản xuất không hợp lệ");
            }
            if (x.GiaThue <= 0)
            {
                throw new BusinessLogicException("Giá thuê không hợp lệ");
            }
            if (x.SoLuong <= 0)
            {
                throw new BusinessLogicException("Số lượng phải lớn hơn 0");
            }

            // Nếu kiểm tra thành công, thêm vào cơ sở dữ liệu
            return dalXe.ThemXe(x);
        }

        public bool CapNhatXe(Xe x)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(x.MaXe))
            {
                throw new BusinessLogicException("Mã xe không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TenXe))
            {
                throw new BusinessLogicException("Tên xe không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.MauSac))
            {
                throw new BusinessLogicException("Màu sắc không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.TinhTrang))
            {
                throw new BusinessLogicException("Tình trạng không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.LoaiXe))
            {
                throw new BusinessLogicException("Loại xe không được để trống");
            }
            if (string.IsNullOrWhiteSpace(x.MaHX))
            {
                throw new BusinessLogicException("Mã hãng xe không được để trống");
            }
            if (x.NamSanXuat == null && x.NamSanXuat.Date > DateTime.Today)
            {
                throw new BusinessLogicException("Năm sản xuất không hợp lệ");
            }
            if (x.GiaThue <= 0)
            {
                throw new BusinessLogicException("Giá thuê không hợp lệ");
            }
            if (x.SoLuong < 0)
            {
                throw new BusinessLogicException("Số lượng không hợp lệ");
            }
            // Nếu kiểm tra thành công, thêm vào cơ sở dữ liệu
            return dalXe.CapNhatXe(x);
        }

        public bool XoaXe(string key)
        {
            return dalXe.XoaXe(key);
        }
    }

}
