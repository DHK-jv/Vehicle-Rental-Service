using QuanLyThueXe.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThueXe.DTO;
using System.Windows.Forms;

namespace QuanLyThueXe.BLL
{
    public class BLL_QuanLyHopDong
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        DAL_QuanLyHopDong dalHD = new DAL_QuanLyHopDong();

        public DataTable getListHopDong()
        {
            return dalHD.getListHopDong();
        }

        public DataTable DanhSachTheoTinhTrang(string tinhTrang)
        {
            return dalHD.PhanLoaiHopDong(tinhTrang);
        }

        public DataTable GetTrangThai()
        {
            return dalHD.GetTrangThai();
        }

        public DataTable LayThongTinHopDongTheoID(string maHD)
        {
            return dalHD.getThongTinHopDongTheoMaHD(maHD);
        }

        public DataTable LayChiTietThongTinHopDong(string maHD)
        {
            return dalHD.getChiTietThongTinHopDong(maHD);
        }


        public DataTable getXeConSan()
        {
            return dalHD.getXeConSan();
        }

        public DataTable getSearchListKhachHang(string key)
        {
            return dalHD.getSearchListKhachHang(key);
        }

        public DataTable getSearchListXe(string key)
        {
            return dalHD.getSearchListXe(key);
        }

        public DataTable LayDSxeTheoMaHD(string maHD)
        {
            return dalHD.LayDSxeTheoMaHD(maHD);
        }

        /*-----------------------------------Functions--------------------------------------*/

        public DataTable Search(string key)
        {
            return dalHD.Search(key);
        }

        public bool Add(HopDong hd, List<Xe> X)
        {
            if (string.IsNullOrWhiteSpace(hd.MaHD))
            {
                throw new BusinessLogicException("Mã hợp đồng không được để trống");
            }
            if (!dalHD.KiemTraKhachHang(hd.MaKH))
            {
                throw new BusinessLogicException("Khách hàng không tồn tại");
            }
            if (hd.NgayThue.Date > DateTime.Today)
            {
                throw new BusinessLogicException("Ngày thuê không hợp lệ");
            }
            if (hd.NgayTra < hd.NgayThue)
            {
                throw new BusinessLogicException("Ngày trả không hợp lệ");
            }
            if (hd.HanTra < hd.NgayThue)
            {
                throw new BusinessLogicException("Hạn trả không hợp lệ");
            }
            if (hd.GiaThue <= 0)
            {
                throw new BusinessLogicException("Giá thuê không hợp lệ");
            }
            if (hd.SoLuong <= 0)
            {
                throw new BusinessLogicException("Số lượng không hợp lệ");
            }
            if (hd.PhiPhat < 0)
            {
                throw new BusinessLogicException("Phí phạt không hợp lệ");
            }
            if (hd.TongTienThue < 0)
            {
                throw new BusinessLogicException("Tổng tiền thuê không hợp lệ");
            }
            if (string.IsNullOrWhiteSpace(hd.MaNV))
            {
                throw new BusinessLogicException("Mã nhân viên không được để trống");
            }
            if (string.IsNullOrWhiteSpace(hd.MaKH))
            {
                throw new BusinessLogicException("Mã khách hàng không được để trống");
            }
            if (X == null || X.Count == 0)
            {
                throw new BusinessLogicException("Danh sách xe trống");
            }

            // Gọi DAL để thêm hợp đồng
            try
            {
                return dalHD.Add(hd, X);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException("Lỗi khi thêm hợp đồng: " + ex.Message);
            }
        }

        public void AddChiTietHopDong(string maHD, string maXe)
        {
            try
            {
                dalHD.AddChiTietHopDong(maHD, maXe);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException("Lỗi khi thêm chi tiết hợp đồng: " + ex.Message);
            }
        }

        public void Update(HopDong hd, List<Xe> listXe)
        {
            if (string.IsNullOrWhiteSpace(hd.MaHD))
            {
                throw new BusinessLogicException("Mã hợp đồng không được để trống");
            }
            if (hd.NgayThue == null || hd.NgayThue.Date > DateTime.Today)
            {
                throw new BusinessLogicException("Ngày thuê không hợp lệ");
            }
            if (hd.NgayTra == null || hd.NgayTra < hd.NgayThue)
            {
                throw new BusinessLogicException("Ngày trả không hợp lệ");
            }
            if (hd.HanTra == null || hd.HanTra < hd.NgayThue)
            {
                throw new BusinessLogicException("Hạn trả không hợp lệ");
            }
            if (hd.GiaThue <= 0)
            {
                throw new BusinessLogicException("Giá thuê không hợp lệ");
            }
            if (hd.SoLuong <= 0)
            {
                throw new BusinessLogicException("Số lượng không hợp lệ");
            }
            if (hd.PhiPhat < 0)
            {
                throw new BusinessLogicException("Phí phạt không hợp lệ");
            }
            if (hd.TongTienThue < 0)
            {
                throw new BusinessLogicException("Tổng tiền thuê không hợp lệ");
            }
            if (string.IsNullOrWhiteSpace(hd.MaNV))
            {
                throw new BusinessLogicException("Mã nhân viên không được để trống");
            }
            if (string.IsNullOrWhiteSpace(hd.MaKH))
            {
                throw new BusinessLogicException("Mã khách hàng không được để trống");
            }
            
            // Gọi DAL để cập nhật hợp đồng
            try
            {
                dalHD.Update(hd, listXe);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException("Lỗi khi cập nhật hợp đồng: " + ex.Message);
            }
        }
        public void UpdateTrangThaiHopDong(string maHD)
        {
            try
            {
                dalHD.UpdateTrangThaiHopDong(maHD);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException("Lỗi khi cập nhật chi tiết hợp đồng: " + ex.Message);
            }
        }

        public void UpdateTinhTrangXe(string maXe)
        {
            try
            {
                dalHD.UpdateTrangThaiXe(maXe);
            }
            catch (Exception ex)
            {
                throw new BusinessLogicException("Lỗi khi cập nhật chi tiết hợp đồng: " + ex.Message);
            }
        }

        public bool Delete(string key)
        {
                return dalHD.Delete(key);
        }

        public void DeleteChiTietHopDong(string maHD)
        {
           dalHD.DeleteChiTietHD(maHD);
        }
    }
}
