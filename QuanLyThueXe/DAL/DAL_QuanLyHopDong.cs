using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.DTO;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyThueXe.DAL
{
    public class DAL_QuanLyHopDong : DBConnect
    {
        DBConnect db = new DBConnect();
        public DataTable getListHopDong()
        {
            string sqlGetListXe = "SELECT HOP_DONG_THUE_XE.MaHD, HOP_DONG_THUE_XE.NgayThue, HOP_DONG_THUE_XE.NgayTra, HOP_DONG_THUE_XE.HanTra, HOP_DONG_THUE_XE.GiaThue, HOP_DONG_THUE_XE.TinhTrang, HOP_DONG_THUE_XE.SoLuong, HOP_DONG_THUE_XE.PhiPhat, HOP_DONG_THUE_XE.TongTienThue, NHAN_VIEN.MaNV, KHACH_HANG.MaKH " +
            "FROM HOP_DONG_THUE_XE" +
            " JOIN NHAN_VIEN ON HOP_DONG_THUE_XE.MaNV = NHAN_VIEN.MaNV" +
            " JOIN KHACH_HANG ON HOP_DONG_THUE_XE.MaKH = KHACH_HANG.MaKH";

            DataTable dt = db.Execute(sqlGetListXe);
            return dt;
        }

        public bool KiemTraKhachHang(string maKH)
        {
            string SqlView = string.Format("SELECT * FROM KHACH_HANG WHERE MaKH = '{0}'", maKH);
            DataTable dt = db.Execute(SqlView);
            return dt.Rows.Count > 0;
        }


        public DataTable getSearchListXe(string key)
        {
            string sqlSearch = string.Format("SELECT XE.MaXe, Xe.TenXe, Xe.BienSo, Xe.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " +
                " FROM XE" +
                " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
                " WHERE TenXe LIKE N'%{0}%' OR MaXe = '{0}' OR LoaiXe = '{0}' OR HANG_XE.MaHX = '{0}'", key);
            DataTable dt = db.Execute(sqlSearch);
            return dt;
        }
        public DataTable getXeConSan()
        {
            string sqlGetListXe = "SELECT XE.MaXe, Xe.TenXe, Xe.BienSo, Xe.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " +
            " FROM XE" +
            " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
            " WHERE XE.TinhTrang = N'Có sẵn'";
            DataTable dt = db.Execute(sqlGetListXe);
            return dt;
        }
        public DataTable getSearchListKhachHang(string key)
        {
            string sqlSearch = string.Format("SELECT * FROM KHACH_HANG WHERE MaKH = '{0}' OR TenKH LIKE N'%{0}%'", key);
            DataTable dt = db.Execute(sqlSearch);
            return dt;
        }
        public DataTable getDSxeTheoIDhd(string key)
        {
            string sqlSearch = string.Format("SELECT XE.MaXe, Xe.TenXe, Xe.BienSo, Xe.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " +
                " FROM XE" +
                " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
                " JOIN CHI_TIET_HOP_DONG_THUE_XE ON XE.MaXe = CHI_TIET_HOP_DONG_THUE_XE.MaXe" +
                " WHERE CHI_TIET_HOP_DONG_THUE_XE.MaHD = '{0}'", key);
            DataTable dt = db.Execute(sqlSearch);
            return dt;
        }
        public DataTable getThongTinHopDongTheoMaHD(string maHD)
        {
            string sqlGetThongTinHopDong = string.Format(@"SELECT HOP_DONG_THUE_XE.MaHD, HOP_DONG_THUE_XE.NgayThue, HOP_DONG_THUE_XE.NgayTra, HOP_DONG_THUE_XE.HanTra, HOP_DONG_THUE_XE.GiaThue, HOP_DONG_THUE_XE.TinhTrang, HOP_DONG_THUE_XE.SoLuong, HOP_DONG_THUE_XE.PhiPhat, HOP_DONG_THUE_XE.TongTienThue, NHAN_VIEN.MaNV, KHACH_HANG.MaKH " +
                "FROM HOP_DONG_THUE_XE" +
                " JOIN NHAN_VIEN ON HOP_DONG_THUE_XE.MaNV = NHAN_VIEN.MaNV" +
                " JOIN KHACH_HANG ON HOP_DONG_THUE_XE.MaKH = KHACH_HANG.MaKH" +

                " WHERE HOP_DONG_THUE_XE.MaHD = '{0}'", maHD);
            DataTable dt = db.Execute(sqlGetThongTinHopDong);
            return dt;
        }

        public DataTable getChiTietThongTinHopDong(string maHD)
        {
            string sqlGetChiTietThongTinHopDong = string.Format(@"SELECT XE.MaXe, Xe.TenXe, Xe.BienSo, Xe.MauSac, XE.TinhTrang, XE.SoLuong, XE.GiaThue, XE.NamSanXuat, XE.LoaiXe, HANG_XE.MaHX " +
                " FROM XE" +
                " JOIN HANG_XE ON XE.MaHX = HANG_XE.MaHX" +
                " JOIN CHI_TIET_HOP_DONG_THUE_XE ON XE.MaXe = CHI_TIET_HOP_DONG_THUE_XE.MaXe" +
                " WHERE CHI_TIET_HOP_DONG_THUE_XE.MaHD = '{0}'", maHD);
            DataTable dt = db.Execute(sqlGetChiTietThongTinHopDong);
            return dt;
        }


        public DataTable PhanLoaiHopDong(string TinhTrang)
        {
            string strTinhTrang = string.Format(@"SELECT HOP_DONG_THUE_XE.MaHD, HOP_DONG_THUE_XE.NgayThue, HOP_DONG_THUE_XE.NgayTra, HOP_DONG_THUE_XE.HanTra, HOP_DONG_THUE_XE.GiaThue, HOP_DONG_THUE_XE.TinhTrang, HOP_DONG_THUE_XE.SoLuong, HOP_DONG_THUE_XE.PhiPhat, HOP_DONG_THUE_XE.TongTienThue, NHAN_VIEN.MaNV, KHACH_HANG.MaKH " +
            "FROM HOP_DONG_THUE_XE" +
            " JOIN NHAN_VIEN ON HOP_DONG_THUE_XE.MaNV = NHAN_VIEN.MaNV" +
            " JOIN KHACH_HANG ON HOP_DONG_THUE_XE.MaKH = KHACH_HANG.MaKH" +
            " WHERE HOP_DONG_THUE_XE.TinhTrang = N'{0}'", TinhTrang);

            DataTable dt = db.Execute(strTinhTrang);
            return dt;
        }

        public DataTable GetTrangThai()
        {
            string sqlGetTrangThai = "SELECT DISTINCT TinhTrang FROM HOP_DONG_THUE_XE";
            DataTable dt = db.Execute(sqlGetTrangThai);
            return dt;
        }

        public DataTable LayDSxeTheoMaHD(string key)
        {
            string sqlSearch = string.Format("SELECT XE.MaXe, Xe.TenXe, Xe.BienSo, Xe.MauSac, XE.TinhTrang, XE.SoLuong" +
                " FROM CHI_TIET_HOP_DONG_THUE_XE" +
                " JOIN XE ON CHI_TIET_HOP_DONG_THUE_XE.MaXe = XE.MaXe" +
                " WHERE CHI_TIET_HOP_DONG_THUE_XE.MaHD = '{0}'", key);
            DataTable dt = db.Execute(sqlSearch);
            return dt;
        }

        /*-----------------------------------Functions--------------------------------------*/


        public DataTable Search(string key)
        {
            string sqlSearch = string.Format(@"SELECT HOP_DONG_THUE_XE.MaHD, HOP_DONG_THUE_XE.NgayThue, HOP_DONG_THUE_XE.NgayTra, HOP_DONG_THUE_XE.HanTra, HOP_DONG_THUE_XE.GiaThue, HOP_DONG_THUE_XE.TinhTrang, HOP_DONG_THUE_XE.SoLuong, HOP_DONG_THUE_XE.PhiPhat, HOP_DONG_THUE_XE.TongTienThue, NHAN_VIEN.MaNV, KHACH_HANG.MaKH " +
            "FROM HOP_DONG_THUE_XE" +
            " JOIN NHAN_VIEN ON HOP_DONG_THUE_XE.MaNV = NHAN_VIEN.MaNV" +
            " JOIN KHACH_HANG ON HOP_DONG_THUE_XE.MaKH = KHACH_HANG.MaKH" +
            " WHERE HOP_DONG_THUE_XE.MaHD = '{0}' OR NHAN_VIEN.MaNV = '{0}' OR KHACH_HANG.MaKH = '{0}'", key);

            DataTable dt = db.Execute(sqlSearch);
            return dt;
        }
        public string TaoMaHoaDonMoi()
        {
            string prefix = "TT";
            string query = "SELECT MAX(MaTT) FROM THANH_TOAN";
            object result = db.ExecuteScalar(query);

            int nextNumber = 1; // Nếu bảng rỗng, bắt đầu từ TT001

            if (result != DBNull.Value && result != null)
            {
                string maxMa = result.ToString().Trim();
                if (maxMa.StartsWith(prefix))
                {
                    if (int.TryParse(maxMa.Substring(2), out int number))
                    {
                        nextNumber = number + 1;
                    }
                }
            }

            return prefix + nextNumber.ToString("D3");
        }

        public bool Add(HopDong hd, List<Xe> list)
        {
            try
            {
                // Thêm hợp đồng vào bảng HOP_DONG_THUE_XE
                string sqlAdd = string.Format(@"INSERT INTO HOP_DONG_THUE_XE (MaHD, NgayThue, NgayTra, HanTra, GiaThue, TinhTrang, SoLuong, PhiPhat, TongTienThue, MaKH, MaNV) " +
                " VALUES ('{0}', '{1:yyyy-MM-dd}', '{2:yyyy-MM-dd}', '{3:yyyy-MM-dd}', {4}, N'{5}', {6}, {7}, {8}, '{9}', '{10}')",
                    hd.MaHD, hd.NgayThue, hd.NgayTra, hd.HanTra, hd.GiaThue, hd.TinhTrang, hd.SoLuong, hd.PhiPhat, hd.TongTienThue, hd.MaKH, hd.MaNV);

                db.ExecuteNonQuery(sqlAdd);

                // Thêm vào bảng CHI_TIET_HOP_DONG_THUE_XE và cập nhật tình trạng xe
                foreach (Xe x in list)
                {
                    AddChiTietHopDong(hd.MaHD, x.getMaXe());

                }

                string maTT = TaoMaHoaDonMoi();
                // Thêm hóa đơn vào bảng THANH_TOÁN (Tự tạo MaTT)
                string sqlAddTT = string.Format(@"INSERT INTO THANH_TOAN (MaTT, MaHD, SoTien, TinhTrang)" +
                " VALUES ('{0}', '{1}', {2}, N'Chưa thanh toán')", maTT, hd.MaHD, hd.TongTienThue);
                db.ExecuteNonQuery(sqlAddTT);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hệ thống: " + ex.ToString());
                return false;
            }
        }

        public void AddChiTietHopDong(string MaHD, string MaXe)
        {
            try
            {
                string sqlAddCT = string.Format(@"INSERT INTO CHI_TIET_HOP_DONG_THUE_XE (MaHD, MaXe)" +
                " VALUES ('{0}', '{1}')", MaHD, MaXe);

                string sqlUpdate = string.Format(@"UPDATE XE SET TinhTrang = N'Được thuê' WHERE MaXe = '{0}'", MaXe);

                string sqlUpdateSL = string.Format(@"UPDATE XE SET SoLuong = SoLuong - 1 WHERE MaXe = '{0}'", MaXe);

                db.ExecuteNonQuery(sqlAddCT);
                db.ExecuteNonQuery(sqlUpdate);
                db.ExecuteNonQuery(sqlUpdateSL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Update(HopDong hd, List<Xe> listXe)
        {
            try
            {
                // 1. Cập nhật hợp đồng trong bảng HOP_DONG_THUE_XE
                string sqlUpdate = string.Format(@"UPDATE HOP_DONG_THUE_XE SET NgayThue = '{1:yyyy-MM-dd}', NgayTra = '{2:yyyy-MM-dd}', HanTra = '{3:yyyy-MM-dd}', GiaThue = {4}, TinhTrang = N'{5}', SoLuong = {6}, PhiPhat = {7}, TongTienThue = {8}, MaKH = '{9}', MaNV = '{10}' WHERE MaHD = '{0}'",
                    hd.MaHD, hd.NgayThue, hd.NgayTra, hd.HanTra, hd.GiaThue, hd.TinhTrang, hd.SoLuong, hd.PhiPhat, hd.TongTienThue, hd.MaKH, hd.MaNV);
                db.ExecuteNonQuery(sqlUpdate);
                // 2. Xóa chi tiết hợp đồng cũ
                string sqlDeleteCT = string.Format(@"DELETE FROM CHI_TIET_HOP_DONG_THUE_XE WHERE MaHD = '{0}'", hd.MaHD);
                db.ExecuteNonQuery(sqlDeleteCT);
                // 3. Thêm chi tiết hợp đồng mới
                foreach (var xe in listXe)
                {
                    string sqlAddCT = string.Format(@"INSERT INTO CHI_TIET_HOP_DONG_THUE_XE (MaHD, MaXe) 
                VALUES ('{0}', '{1}')", hd.MaHD, xe.MaXe);
                    db.ExecuteNonQuery(sqlAddCT);
                }

                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void UpdateTrangThaiHopDong(string MaHD)
        {
            string sqlUpdate = string.Format(@"UPDATE HOP_DONG_THUE_XE SET TinhTrang = N'Đã trả' WHERE MaHD = '{0}'", MaHD);
            db.ExecuteNonQuery(sqlUpdate);
        }
        public void UpdateTrangThaiXe(string MaXe)
        {
            string sqlUpdate = string.Format(@"UPDATE XE SET TinhTrang = N'Có sẵn' WHERE MaXe = '{0}'", MaXe);
            db.ExecuteNonQuery(sqlUpdate);
        }

        public bool Delete(string key)
        {
            try
            {
                // 1. Xóa dữ liệu trong bảng THANH_TOAN 
                string sqlDeleteThanhToan = string.Format(@"DELETE FROM THANH_TOAN WHERE MaHD = '{0}'", key);
                db.ExecuteNonQuery(sqlDeleteThanhToan);

                // 2. Xóa dữ liệu trong bảng CHI_TIET_HOP_DONG_THUE_XE
                string sqlDeleteCT = string.Format(@"DELETE FROM CHI_TIET_HOP_DONG_THUE_XE WHERE MaHD = '{0}'", key);
                db.ExecuteNonQuery(sqlDeleteCT);

                // 3. Xóa hợp đồng chính trong bảng HOP_DONG_THUE_XE
                string sqlDelete = string.Format(@"DELETE FROM HOP_DONG_THUE_XE WHERE MaHD = '{0}'", key);
                db.ExecuteNonQuery(sqlDelete);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public void DeleteChiTietHD(string MaHD)
        {
            try
            {
                string sqlDeleteCT = string.Format("DELETE FROM CHI_TIET_HOP_DONG_THUE_XE WHERE MaHD = '{0}'", MaHD);
                db.ExecuteNonQuery(sqlDeleteCT);
                string sqlUpdate = string.Format("UPDATE XE SET TinhTrang = N'Có sẵn' WHERE MaXe IN (SELECT MaXe FROM CHI_TIET_HOP_DONG_THUE_XE WHERE MaHD = '{0}')", MaHD);
                db.ExecuteNonQuery(sqlUpdate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
