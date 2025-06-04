using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThueXe.DAL;
using QuanLyThueXe.DTO;

namespace QuanLyThueXe.BLL
{
    internal class BLL_Login
    {
        DAL_Login dal = new DAL_Login();
        public TaiKhoan Login(string us, string pw)
        {
            return dal.checkLogin(us, pw);
        }
        public string LayMaNhanVien(string key)
        {
            return dal.LayMaNhanVien(key);
        }
    }
}
