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
    public class DAL_QuanLyThanhToan : DBConnect
    {
        DBConnect db = new DBConnect();

        public DataTable getListThanhToan()
        {
            string sqlGetListThanhToan = "SELECT THANH_TOAN.MaTT, THANH_TOAN.NgayThanhToan, THANH_TOAN.SoTien, THANH_TOAN.TinhTrang, THANH_TOAN.PhuongThucTT, THANH_TOAN.MaHD " +
                " FROM THANH_TOAN " +
                " JOIN HOP_DONG_THUE_XE ON THANH_TOAN.MaHD = HOP_DONG_THUE_XE.MaHD ";

            DataTable dt = db.Execute(sqlGetListThanhToan);
            return dt;
        }

        public string LayMaHD(string maTT)
        {
            string query = $"SELECT MaHD FROM THANH_TOAN WHERE MaTT = '{maTT}'";
            return db.ExecuteScalar(query)?.ToString();
        }

        public string LayMaXe(string maTT)
        {
            string query = $"SELECT MaXe FROM CHI_TIET_HOP_DONG_THUE_XE WHERE MaHD = (SELECT MaHD FROM THANH_TOAN WHERE MaTT = '{maTT}')";
            return db.ExecuteScalar(query)?.ToString();
        }


        public DataTable getThongTinTheoMaTT(string key)
        {
            string sqlGetThongTinThanhToan = string.Format(@"SELECT THANH_TOAN.MaTT, THANH_TOAN.NgayThanhToan, THANH_TOAN.PhuongThucTT, THANH_TOAN.TinhTrang, THANH_TOAN.SoTien " +
                " FROM THANH_TOAN " +
                " WHERE THANH_TOAN.MaTT = '{0}'", key);
            DataTable dt = db.Execute(sqlGetThongTinThanhToan);
            return dt;
        }

        public DataTable getThongTinTheoMaHD(string key)
        {
            string sqlGetThongTinThanhToan = string.Format(@"SELECT THANH_TOAN.MaTT, THANH_TOAN.NgayThanhToan, THANH_TOAN.PhuongThucTT, THANH_TOAN.TinhTrang, THANH_TOAN.SoTien " +
                " FROM THANH_TOAN " +
                " WHERE THANH_TOAN.MaHD = '{0}'", key);
            DataTable dt = db.Execute(sqlGetThongTinThanhToan);
            return dt;
        }

        public DataTable getListTheLoai()
        {
            string sqlListTheLoai = "SELECT DISTINCT TinhTrang FROM THANH_TOAN";
            DataTable dt = db.Execute(sqlListTheLoai);
            return dt;
        }



        /*-----------------------------------Functions--------------------------------------*/

        public bool CapNhatPayments(ThanhToan tt)
        {
            try
            {
                string sqlCapNhatThanhToan = string.Format(@"UPDATE THANH_TOAN SET NgayThanhToan = '{1}', PhuongThucTT = N'{2}', TinhTrang = N'{3}', SoTien = {4} WHERE THANH_TOAN.MaTT = '{0}';",tt.MaTT,tt.NgayThanhToan, tt.PhuongThucTT,tt.TinhTrang,tt.SoTien);
                db.ExecuteNonQuery(sqlCapNhatThanhToan);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật thanh toán: " + ex.ToString());
                return false;
            }
        }

        public void UpdateCTTT(string MaHD, string MaXe)
        {
            try
            {
                string sqlUpdateCT = string.Format("UPDATE CHI_TIET_HOP_DONG_THUE_XE SET MaXe = '{1}' WHERE MaHD = '{0}'", MaHD, MaXe);
                db.ExecuteNonQuery(sqlUpdateCT);
                string sqlUpdate = string.Format("UPDATE XE SET TinhTrang = N'Có sẵn' WHERE MaXe = '{0}'", MaXe);
                db.ExecuteNonQuery(sqlUpdate);
                string sqlUpdateSL = string.Format("UPDATE XE SET SoLuong = SoLuong + 1 WHERE MaXe = '{0}'", MaXe);
                db.ExecuteNonQuery(sqlUpdateSL);
                string sqlUpdateSLHD = string.Format("UPDATE HOP_DONG_THUE_XE SET SoLuong = SoLuong - 1 WHERE MaHD = '{0}'", MaHD);
                db.ExecuteNonQuery(sqlUpdateSLHD);
                string sqlUpdateTT = string.Format("UPDATE HOP_DONG_THUE_XE SET TinhTrang = N'Đã trả' WHERE MaHD = '{0}'", MaHD);
                db.ExecuteNonQuery(sqlUpdateTT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public DataTable Search(string key)
        {
            string strSearch = string.Format(@"SELECT THANH_TOAN.MaTT, THANH_TOAN.NgayThanhToan, THANH_TOAN.SoTien, THANH_TOAN.TinhTrang, THANH_TOAN.PhuongThucTT, THANH_TOAN.MaHD " +
                " FROM THANH_TOAN " +
                " JOIN HOP_DONG_THUE_XE ON THANH_TOAN.MaHD = HOP_DONG_THUE_XE.MaHD " +
                " WHERE THANH_TOAN.MaTT LIKE '%{0}%' OR THANH_TOAN.MaHD LIKE '%{0}%' OR THANH_TOAN.TinhTrang LIKE N'%{0}%' OR THANH_TOAN.PhuongThucTT LIKE N'%{0}%'", key);
            DataTable dt = db.Execute(strSearch);
            return dt;
        }

        public DataTable DanhSachThanhToan(string LoaiHoaDon)
        {
            string strSearchIDTT = string.Format(@"SELECT THANH_TOAN.MaTT, THANH_TOAN.NgayThanhToan, THANH_TOAN.SoTien, THANH_TOAN.PhuongThucTT, THANH_TOAN.TinhTrang, THANH_TOAN.MaHD " +
                " FROM THANH_TOAN " +
                " JOIN HOP_DONG_THUE_XE ON THANH_TOAN.MaHD = HOP_DONG_THUE_XE.MaHD " +
                " WHERE THANH_TOAN.TinhTrang = N'{0}'", LoaiHoaDon);
            DataTable dt = db.Execute(strSearchIDTT);
            return dt;
        }


    }
}


