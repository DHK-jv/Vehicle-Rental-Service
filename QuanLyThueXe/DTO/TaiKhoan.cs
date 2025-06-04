using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyThueXe.DTO
{
    public class TaiKhoan
    {
        private string UserName;
        private string PassWord;
        private string PhanQuyen;

        public string getUserName()
        {

            return UserName;
        }
        public void setUserName(string value)
        {
            UserName = value;
        }
        public string getPassWord()
        {

            return PassWord;
        }
        public void setPassWord(string value)
        {
            PassWord = value;
        }

        public string getPhanQuyen()
        {

            return PhanQuyen;
        }
        public void setPhanQuyen(string value)
        {
            PhanQuyen = value;
        }

        public TaiKhoan()
        {
            UserName = string.Empty;
            PassWord = string.Empty;
            PhanQuyen = string.Empty;
        }
        public TaiKhoan(string userName, string passWord, string phanQuyen)
        {
            UserName = userName;
            PassWord = passWord;
            PhanQuyen = phanQuyen;
        }


    }
}
