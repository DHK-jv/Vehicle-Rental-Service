using QuanLyThueXe.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThueXe.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThueXe.BLL
{
    public class BLL_QuanLyThanhToan
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }

        DAL_QuanLyThanhToan dalTT = new DAL_QuanLyThanhToan();

        public DataTable getListThanhToan()
        {
            return dalTT.getListThanhToan();
        }

        public DataTable LayThongTinThanhToan(string maTT)
        {
            return dalTT.getThongTinTheoMaTT(maTT);
        }

        public DataTable LayThongTinTheoMaHD(string key)
        {
            return dalTT.getThongTinTheoMaHD(key);
        }

        public string LayMaHD(string maTT)
        {
            return dalTT.LayMaHD(maTT);
        }

        public string LayMaXe(string maTT)
        {
            return dalTT.LayMaXe(maTT);
        }

        public bool CapNhatThanhToan(ThanhToan tt)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(tt.MaTT))
            {
                throw new BusinessLogicException("Mã thanh toán không được để trống");
            }
            if (string.IsNullOrWhiteSpace(tt.PhuongThucTT))
            {
                throw new BusinessLogicException("Phương thức thanh toán không được để trống");
            }
            if (tt.TinhTrang != "Đã thanh toán")
            {
                throw new BusinessLogicException("Tình trạng không hợp lệ");
            }
            if (tt.SoTien <= 0)
            {
                throw new BusinessLogicException("Số tiền thanh toán không hợp lệ");
            }
            if (tt.NgayThanhToan.Date > DateTime.Today)
            {
                throw new BusinessLogicException("Ngày thanh toán không hợp lệ");
            }
            return dalTT.CapNhatPayments(tt);
        }

        public void UpdateCTTT(string MaHD, string MaXe)
        {
            dalTT.UpdateCTTT(MaHD, MaXe);
        }

        public DataTable Search(string key)
        {
            return dalTT.Search(key);
        }

        public DataTable DanhSachThanhToan(string key)
        {
            return dalTT.DanhSachThanhToan(key);
        }

        public DataTable GetTheLoai()
        {
            return dalTT.getListTheLoai();
        }


    }
}
