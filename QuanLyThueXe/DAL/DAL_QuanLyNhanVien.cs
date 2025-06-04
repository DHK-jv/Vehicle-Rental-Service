using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThueXe.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace QuanLyThueXe.DAL
{
    public class DAL_QuanLyNhanVien : DBConnect
    {
        DBConnect db = new DBConnect();
        public DataTable getListNhanVien()
        {
            string sqlGetListNhanVien = "SELECT NHAN_VIEN.MaNV, NHAN_VIEN.TenNV, NHAN_VIEN.NgaySinh, NHAN_VIEN.GioiTinh, NHAN_VIEN.SoDT, NHAN_VIEN.DiaChi, TAI_KHOAN.UserName " +
            " FROM NHAN_VIEN" +
            " JOIN TAI_KHOAN ON NHAN_VIEN.UserName = TAI_KHOAN.UserName";

            DataTable dt = db.Execute(sqlGetListNhanVien);
            return dt;
        }
        public DataTable getThongTinNhanVien(string maNV)
        {
            string sqlGetThongTinNhanVien = string.Format("SELECT NHAN_VIEN.MaNV, NHAN_VIEN.TenNV, NHAN_VIEN.NgaySinh, NHAN_VIEN.GioiTinh, NHAN_VIEN.SoDT, NHAN_VIEN.DiaChi, TAI_KHOAN.UserName " +
            " FROM NHAN_VIEN" +
            " JOIN TAI_KHOAN ON NHAN_VIEN.UserName = TAI_KHOAN.UserName" +
            " WHERE NHAN_VIEN.MaNV = '{0}'", maNV);
            DataTable dt = db.Execute(sqlGetThongTinNhanVien);
            return dt;
        }
        public DataTable LayThongTinTheoMaNV(string key)
        {
            string strSearchIDNhanVien = string.Format(@"SELECT NHAN_VIEN.MaNV, NHAN_VIEN.TenNV, NHAN_VIEN.NgaySinh, NHAN_VIEN.GioiTinh, NHAN_VIEN.SoDT, NHAN_VIEN.DiaChi, TAI_KHOAN.UserName " +
            " FROM NHAN_VIEN" +
            " JOIN TAI_KHOAN ON NHAN_VIEN.UserName = TAI_KHOAN.UserName" +
            " WHERE NHAN_VIEN.MaNV = '{0}'", key);

            DataTable dt = db.Execute(strSearchIDNhanVien);
            return dt;
        }
        public DataTable Search(string key)
        {

            string strSearch = string.Format(@"SELECT NHAN_VIEN.MaNV, NHAN_VIEN.TenNV, NHAN_VIEN.NgaySinh, NHAN_VIEN.GioiTinh, NHAN_VIEN.SoDT, NHAN_VIEN.DiaChi, TAI_KHOAN.UserName " +
            " FROM NHAN_VIEN" +
            " JOIN TAI_KHOAN ON NHAN_VIEN.UserName = TAI_KHOAN.UserName" +
            " WHERE MaNV LIKE '%{0}%'  OR  TAI_KHOAN.UserName = '{0}' OR NHAN_VIEN.TenNV = '{0}'", key);
            DataTable dt = db.Execute(strSearch);
            return dt;
        }
        public bool ThemNhanVien(NhanVien x, TaiKhoan tk)
        {
            try
            {
                string sqlThemTaiKhoan = string.Format("INSERT INTO TAI_KHOAN(UserName, PassWord, PhanQuyen) VALUES('{0}', '{1}', N'{2}'); ", tk.getUserName(), tk.getPassWord(), "Nhân viên");

                string sqlThemNhanVien = string.Format("INSERT INTO NHAN_VIEN (MaNV, TenNV, NgaySinh, GioiTinh, SoDT, DiaChi, UserName) " +
                "VALUES ('{0}', N'{1}', '{2}', N'{3}', '{4}', N'{5}', '{6}'); " ,
                x.MaNV, x.TenNV, x.NgaySinh, x.GioiTinh, x.SoDT, x.DiaChi, x.UserName);

                db.ExecuteNonQuery(sqlThemTaiKhoan);
                db.ExecuteNonQuery(sqlThemNhanVien);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool XoaNhanVien(string key)
        {
            try
            {
                string sqlXoaTaiKhoan = string.Format("DELETE FROM TAI_KHOAN WHERE UserName = (SELECT UserName FROM NHAN_VIEN WHERE MaNV = '{0}');", key);
                db.ExecuteNonQuery(sqlXoaTaiKhoan);

                // Xóa nhân viên
                string sqlXoaNhanVien = string.Format("DELETE FROM NHAN_VIEN WHERE MaNV = '{0}';", key);
                db.ExecuteNonQuery(sqlXoaNhanVien);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa nhân viên: " + ex.Message);
                return false;
            }
        }



        public bool CapNhatNhanVien(NhanVien x, TaiKhoan tk)
        {
            try
            {   //Cập nhật thông tin tài khoản
                string sqlCapNhatTaiKhoan = string.Format("UPDATE TAI_KHOAN SET UserName = '{0}', PassWord = '{1}' WHERE UserName = (SELECT UserName FROM NHAN_VIEN WHERE MaNV = '{2}');",
                tk.getUserName(), tk.getPassWord(), x.MaNV);

                // Cập nhật thông tin nhân viên
                string sqlCapNhatNhanVien = string.Format("UPDATE NHAN_VIEN SET TenNV = N'{1}', NgaySinh = '{2}', GioiTinh = N'{3}', SoDT = '{4}', DiaChi = N'{5}', UserName = '{6}' WHERE MaNV = '{0}';",
                    x.MaNV, x.TenNV, x.NgaySinh, x.GioiTinh, x.SoDT, x.DiaChi, x.UserName);

                db.ExecuteNonQuery(sqlCapNhatTaiKhoan);
                db.ExecuteNonQuery(sqlCapNhatNhanVien);
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
