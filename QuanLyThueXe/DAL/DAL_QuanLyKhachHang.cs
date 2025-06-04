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
    public class DAL_QuanLyKhachHang : DBConnect
    {
        DBConnect db = new DBConnect();
        public DataTable getListKhachHang()
        {
            string sqlGetListKhachHang = "SELECT KHACH_HANG.MaKH, KHACH_HANG.TenKH, KHACH_HANG.NgaySinh, KHACH_HANG.GioiTinh, KHACH_HANG.CCCD, KHACH_HANG.SoDT, KHACH_HANG.DiaChi " +
            " FROM KHACH_HANG";
            

            DataTable dt = db.Execute(sqlGetListKhachHang);
            return dt;
        }
        public DataTable getThongTinKhachHang(string maKH)
        {
            string sqlGetThongTinKhachHang = string.Format("SELECT KHACH_HANG.MaKH, KHACH_HANG.TenKH, KHACH_HANG.NgaySinh, KHACH_HANG.GioiTinh, KHACH_HANG.CCCD, KHACH_HANG.SoDT, KHACH_HANG.DiaChi " +
            " FROM KHACH_HANG" +
            " WHERE KHACH_HANG.MaKH = '{0}'", maKH);
            DataTable dt = db.Execute(sqlGetThongTinKhachHang);
            return dt;
        }
        public DataTable PhanLoaiGioiTinh(string LoaiXe)
        {
            string strLoaiXe = string.Format(@"SELECT XE.MaXe, XE.TenXe, XE.BienSo, XE.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, [HANG XE].MaHX" +
            " FROM XE " +
            " JOIN [HANG XE] ON XE.MaHX = [HANG XE].MaHX " +
            " WHERE XE.LoaiXe = N'{0}' ", LoaiXe);

            DataTable dt = db.Execute(strLoaiXe);
            return dt;
        }
        public DataTable PhanLoaiKhachHang(string GioiTinh)
        {
            string strGioiTinh = string.Format(@"SELECT KHACH_HANG.MaKH, KHACH_HANG.TenKH, KHACH_HANG.NgaySinh, KHACH_HANG.GioiTinh, KHACH_HANG.CCCD, KHACH_HANG.SoDT, KHACH_HANG.DiaChi" +
            " FROM XE " +

            " WHERE KHACH_HANG.GioiTinh = N'{0}' ", GioiTinh);

            DataTable dt = db.Execute(strGioiTinh);
            return dt;
        }
        public DataTable LayThongTinTheoMaKH(string key)
        {
            string strSearchIDKhachHang = string.Format(@"SELECT KHACH_HANG.MaKH, KHACH_HANG.TenKH, KHACH_HANG.NgaySinh, KHACH_HANG.GioiTinh, KHACH_HANG.CCCD, KHACH_HANG.SoDT, KHACH_HANG.DiaChi " +
            " FROM KHACH_HANG" +
            " WHERE KHACH_HANG.MaKH = '{0}'", key);

            DataTable dt = db.Execute(strSearchIDKhachHang);
            return dt;
        }
        public DataTable Search(string key)
        {

            string strSearch = string.Format(@"SELECT KHACH_HANG.MaKH, KHACH_HANG.TenKH, KHACH_HANG.NgaySinh, KHACH_HANG.GioiTinh, KHACH_HANG.CCCD, KHACH_HANG.SoDT, KHACH_HANG.DiaChi " +
            " FROM KHACH_HANG" +

            " WHERE MaKH LIKE '%{0}%' OR KHACH_HANG.TenKH = '{0}'", key);
            DataTable dt = db.Execute(strSearch);
            return dt;
        }
        public bool ThemKhachHang(KhachHang x)
        {
            try
            {
                string sqlThemKhachHang = string.Format(
                "INSERT INTO KHACH_HANG (MaKH, TenKH, NgaySinh, GioiTinh, CCCD, SoDT, DiaChi) " +
                "VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}', N'{6}');",
                x.MaKH, x.TenKH, x.NgaySinh, x.GioiTinh, x.CCCD, x.SoDT, x.DiaChi);

                db.ExecuteNonQuery(sqlThemKhachHang);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool XoaKhachHang(string maKH)
        {
            try
            {
                string sqlXoaKhachHang = string.Format("DELETE FROM KHACH_HANG WHERE MaKH = '{0}'", maKH);
                db.ExecuteNonQuery(sqlXoaKhachHang);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool CapNhatKhacHang(KhachHang x)
        {
            try
            {
                string sqlCapNhatKhachHang = string.Format("UPDATE KHACH_HANG SET TenKH = N'{1}', NgaySinh = '{2}', GioiTinh = N'{3}', SoDT = '{4}', DiaChi = N'{5}', CCCD = '{6}' WHERE MaKH = '{0}';",
                    x.MaKH, x.TenKH, x.NgaySinh, x.GioiTinh, x.SoDT, x.DiaChi, x.CCCD);

                db.ExecuteNonQuery(sqlCapNhatKhachHang);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        

    }
}
