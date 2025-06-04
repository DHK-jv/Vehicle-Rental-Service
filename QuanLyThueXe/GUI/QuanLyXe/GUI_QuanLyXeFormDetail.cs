using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.BLL;

namespace QuanLyThueXe
{
    public partial class GUI_QuanLyXeFormDetail : Form
    {
        BLL_QuanLyXe bllXe = new BLL_QuanLyXe();
        private string PATH = AppDomain.CurrentDomain.BaseDirectory; //Lấy đường dẫn thư mục chứa file exe
        public GUI_QuanLyXeFormDetail(string key)
        {
            InitializeComponent();
            DataTable dtX = bllXe.LayThongTinXe(key);
            HienThiThongTinXe(dtX);
        }
        public void HienThiThongTinXe(DataTable dtX)
        {
            txtLoaiXe.Text = dtX.Rows[0]["LoaiXe"].ToString();
            txtTenXe.Text = dtX.Rows[0]["TenXe"].ToString();
            txtGiaThue.Text = dtX.Rows[0]["GiaThue"].ToString();
            txtBienSo.Text = dtX.Rows[0]["BienSo"].ToString();
            txtMauSac.Text = dtX.Rows[0]["MauSac"].ToString();
            dtpNamSX.Text = dtX.Rows[0]["NamSanXuat"].ToString();
            txtSoLuong.Text = dtX.Rows[0]["SoLuong"].ToString();
            if (!string.IsNullOrEmpty(dtX.Rows[0]["HinhAnh"].ToString()))
            {
                picHinhAnhXe.Image = Image.FromFile(PATH + dtX.Rows[0]["HinhAnh"].ToString());
            }
            cbbTinhTrang.Text = dtX.Rows[0]["TinhTrang"].ToString();
            txtMaXe.Text = dtX.Rows[0]["MaXe"].ToString();
            txtTenHX.Text = dtX.Rows[0]["TenHX"].ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picHinhAnhXe_Click(object sender, EventArgs e)
        {
                

        }
    }
}
