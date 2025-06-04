using QuanLyThueXe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.BLL
{
    public class BLL_QuanLyThongKe
    {
        public class BusinessLogicException : Exception
        {
            public BusinessLogicException(string message) : base(message) { }
        }
        DAL_QuanLyThongKe dalThongKe = new DAL_QuanLyThongKe();

        public DataTable getListXe()
        {
            return dalThongKe.getListXe();
        }
        public DataTable getTongSoLuong()
        {
            return dalThongKe.getTongSoLuong();
        }
        // THONG KE XE DUOC SU DUNG
        public DataTable getListXeDuocSuDung()
        {
            return dalThongKe.getListXeDuocSuDung();
        }

        public DataTable PhanLoaiXe()
        {
            return dalThongKe.PhanLoaiXe();
        }

        public DataTable HienThiPhanLoaiXe(string LoaiXe)
        {
            return dalThongKe.HienThiPhanLoaiXe(LoaiXe);
        }
        //XE THUE NHIEU NHAT
        public DataTable getXeThueNhieu(string filter)
        {
            return dalThongKe.getXeThueNhieu(filter);
        }

        // DOANH THU 
        public DataTable GetDoanhThuTungXe()
        {
            return dalThongKe.GetDoanhThuTungXe();
        }
    }
}
