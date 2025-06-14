﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.DTO;


namespace QuanLyThueXe.DAL
{
    internal class DAL_Login
    {
        DBConnect db = new DBConnect();

        public TaiKhoan checkLogin(string us, string pw)
        {
            string sqlGetAccount = string.Format("select UserName , PassWord, PhanQuyen from TAI_KHOAN where TAI_KHOAN.UserName = '{0}' and TAI_KHOAN.PassWord = '{1}' ;", us, pw);
            DataTable dt = db.Execute(sqlGetAccount);
            if (dt.Rows.Count > 0 && dt != null)
            {
                if (dt.Rows[0][0].ToString() == us)
                {
                    if (dt.Rows[0][1].ToString() == pw)
                    {

                        TaiKhoan tk = new TaiKhoan(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                        return tk;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public string LayMaNhanVien(string key)
        {
            string manv = string.Empty;
            string sql = string.Format("Select NHAN_VIEN.MaNV from NHAN_VIEN where NHAN_VIEN.UserName ='{0}';", key);

            DataTable dt = db.Execute(sql);
            if (dt.Rows.Count > 0)
            {
                manv = dt.Rows[0]["MaNV"].ToString();
            }
            return manv;
        }
    }
}
