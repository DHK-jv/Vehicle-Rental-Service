using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThueXe.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThueXe.DAL
{
    public class DAL_QuanLyXe : DBConnect
    {
        DBConnect db = new DBConnect();
        public DataTable getListXe()
        {
            string sqlGetListXe = "SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, CONVERT(VARCHAR(10), XE.NamSanXuat, 103) AS NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " +
            " FROM XE" +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
            " WHERE XE.MaHX = HANG_XE.MaHX";

            DataTable dt = db.Execute(sqlGetListXe);
            return dt;
        }
        public void CapnhatSoluongXe()
        {
            string sqlCapNhatSoLuong = "UPDATE XE SET SoLuong = (    SELECT COUNT(*)  FROM XE AS X  WHERE X.MaXe = XE.MaXe );";
            db.ExecuteNonQuery(sqlCapNhatSoLuong);
        }
        public DataTable getThongTinXe(string maXe)
        {
            string sqlGetThongTinXe = string.Format("SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.HinhAnh, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX, HANG_XE.TenHX " +
            " FROM XE" +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
            " WHERE XE.MaXe = '{0}'", maXe);
            DataTable dt = db.Execute(sqlGetThongTinXe);
            return dt;
        }

        public DataTable getListTheLoaiXe()
        {
            string sqlListTheLoai = "SELECT DISTINCT LoaiXe FROM XE";
            DataTable dt = db.Execute(sqlListTheLoai);
            return dt;
        }

        public DataTable LayThongTinTheoMaXe(string key)
        {
            string strSearchIDxe = string.Format(@"SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.HinhAnh, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX  " +
            " FROM XE " +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX " +
            " WHERE XE.MaXe = '{0}' ", key);

            DataTable dt = db.Execute(strSearchIDxe);
            return dt;
        }

        public DataTable PhanLoaiXe(string LoaiXe)
        {
            string strLoaiXe = string.Format(@"SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX" +
            " FROM XE " +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX " +
            " WHERE XE.LoaiXe = N'{0}' ", LoaiXe);

            DataTable dt = db.Execute(strLoaiXe);
            return dt;
        }

        /*-------------------------------------Functions--------------------------------------------*/

        public DataTable Search(string key)
        {

            string strSearch = string.Format(@"SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX" +
            " FROM XE" +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
            " WHERE MaXe LIKE '%{0}%'  OR  HANG_XE.MaHX = '{0}' OR XE.TenXe = '{0}' OR XE.LoaiXe = '{0}'", key);
            DataTable dt = db.Execute(strSearch);
            return dt;
        }


        public bool ThemXe(Xe x)
        {
            try
            {
                string sqlThemXe = string.Format("INSERT INTO XE (MaXe, TenXe, BienSo, MauSac, TinhTrang, SoLuong, HinhAnh, GiaThue, NamSanXuat, LoaiXe, MaHX ) " +
                " VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}', '{8}', N'{9}', '{10}');",
                x.getMaXe(), x.getTenXe(), x.getBienSo(), x.getMauSac(), x.getTinhTrang(), x.getSoLuong(), x.getHinhAnh(), x.getGiaThue(), x.getNamSanXuat(), x.getLoaiXe(), x.getMaHX());

                db.ExecuteNonQuery(sqlThemXe);
                try
                {
                    CapnhatSoluongXe();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool XoaXe(string key)
        {
            try
            {
                string sqlXoaXe = string.Format("BEGIN TRANSACTION;" +
                "\r\n\n\r\nDELETE FROM CHI_TIET_HOP_DONG_THUE_XE\r" +
                "\nWHERE MaXe IN (\r\n    SELECT MaXe FROM XE WHERE MaXe = '{0}'\r\n);" +
                "\r\nDELETE FROM HOP_DONG_THUE_XE\r\nWHERE MaHD IN (\r\n    SELECT DISTINCT MaHD\r\n    FROM CHI_TIET_HOP_DONG_THUE_XE\r\n    WHERE MaXe = '{0}'\r\n);" +
                "\r\n\r\n\r\nDELETE FROM XE\r\nWHERE MaXe = '{0}';\r\n\r\nCOMMIT;", key);
                db.ExecuteNonQuery(sqlXoaXe);
                CapnhatSoluongXe();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa xe: " + ex.Message);
                return false;
            }
        }

        public bool CapNhatXe(Xe x)
        {
            try
            {
                string sqlCapNhatXe = string.Format("UPDATE XE SET TenXe = N'{0}', BienSo = '{1}', MauSac = N'{2}', TinhTrang = N'{3}', SoLuong = '{4}', HinhAnh = '{5}', GiaThue = '{6}', NamSanXuat = '{7}', LoaiXe = N'{8}', MaHX = '{9}' " +
                    "WHERE MaXe = '{10}'; ",
                   x.getTenXe(), x.getBienSo(), x.getMauSac(), x.getTinhTrang(), x.getSoLuong(), x.getHinhAnh(), x.getGiaThue(), x.getNamSanXuat(), x.getLoaiXe(), x.getMaHX(), x.getMaXe());
                db.ExecuteNonQuery(sqlCapNhatXe);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật xe: " + ex.Message);
                return false;
            }
        }
    }
}
