using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThueXe.DTO;
using System.Windows.Forms;

namespace QuanLyThueXe.DAL
{
    public class DAL_QuanLyThongKe : DBConnect
    {
        DBConnect db = new DBConnect();
        public DataTable getListXe()
        {
            string sqlGetListXe = "SELECT XE.MaXe, Xe.TenXe, Xe.BienSo, Xe.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " +
            " FROM XE" +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
            " WHERE XE.MaHX = HANG_XE.MaHX";

            DataTable dt = db.Execute(sqlGetListXe);
            return dt;
        }
        public DataTable getTongSoLuong()
        {
            string query = "SELECT SUM(SoLuong) FROM XE";
            DataTable dt = db.Execute(query);
            return dt;
        }

        // THONG KE XE DUOC SU DUNG

        public DataTable getListXeDuocSuDung()
        {
            string sql = @"SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " + 
                  " FROM XE " +
                  " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX " +
                  " WHERE XE.TinhTrang LIKE N'%Đang thuê%' OR XE.TinhTrang LIKE N'%Có sẵn%' ";

            DataTable dt = db.Execute(sql);
            return dt;
        }



        public DataTable PhanLoaiXe()
        {
            string strTinhTrang = string.Format(@"SELECT DISTINCT TinhTrang FROM XE" +
            " WHERE XE.TinhTrang  LIKE N'%thuê%' OR XE.TinhTrang LIKE N'%Có%'");

            DataTable dt = db.Execute(strTinhTrang);
            return dt;
        }

        public DataTable HienThiPhanLoaiXe(string LoaiXe)
        {
            string strLoaiXe = string.Format(@"SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX" +
            " FROM XE " +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX " +
            " WHERE XE.TinhTrang = N'{0}' ", LoaiXe);

            DataTable dt = db.Execute(strLoaiXe);
            return dt;
        }


        //XE THUE NHIEU NHAT
        public DataTable getXeThueNhieu(string filter)
        {
            string condition = "";

            if (filter == "Ngày")
                condition = "WHERE CAST(HD.NgayThue AS DATE) = CAST(GETDATE() AS DATE)";
            else if (filter == "Tuần")
                condition = "WHERE DATEPART(WEEK, HD.NgayThue) = DATEPART(WEEK, GETDATE()) AND DATEPART(YEAR, HD.NgayThue) = DATEPART(YEAR, GETDATE())";
            else if (filter == "Tháng")
                condition = "WHERE MONTH(HD.NgayThue) = MONTH(GETDATE()) AND YEAR(HD.NgayThue) = YEAR(GETDATE())\r\n";

            string sql = $@"
        SELECT XE.MaXe, XE.TenXe, COUNT(CTHD.MaHD) AS SoLanThue
        FROM XE
        JOIN CHI_TIET_HOP_DONG_THUE_XE CTHD ON XE.MaXe = CTHD.MaXe
        JOIN HOP_DONG_THUE_XE HD ON CTHD.MaHD = HD.MaHD
        {condition}
        GROUP BY XE.MaXe, XE.TenXe
        ORDER BY SoLanThue DESC;";

            return db.Execute(sql);
        }

        // DOANH THU

        public DataTable GetDoanhThuTungXe()
        {
            string sql = @"
        SELECT 
            XE.TenXe, 
            SUM(DATEDIFF(DAY, HD.NgayThue, HD.NgayTra) * XE.GiaThue + 
                CASE 
                    WHEN HD.NgayTra > HD.HanTra THEN DATEDIFF(DAY, HD.HanTra, HD.NgayTra) * 10000 
                    ELSE 0 
                END
            ) AS DoanhThu
        FROM CHI_TIET_HOP_DONG_THUE_XE CTHD
        JOIN HOP_DONG_THUE_XE HD ON CTHD.MaHD = HD.MaHD
        JOIN XE ON CTHD.MaXe = XE.MaXe
        GROUP BY XE.TenXe
        ORDER BY DoanhThu DESC";

            return db.Execute(sql);
        }




    }
}
