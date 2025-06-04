using QuanLyThueXe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXe
{
    public partial class GUI_QuanLyHopDongFormDetail : Form
    {
        BLL_QuanLyHopDong bllHD = new BLL_QuanLyHopDong();
        public GUI_QuanLyHopDongFormDetail(string key)
        {
            InitializeComponent();
            DataTable dtHD = bllHD.LayThongTinHopDongTheoID(key);
            DataTable X = bllHD.LayDSxeTheoMaHD(key);
            
            HienThiThongTinHD(dtHD);
            HienThiThongTinXe(X);
        }

        public void HienThiThongTinHD(DataTable dtHD)
        {
            txtMaHD.Text = dtHD.Rows[0]["MaHD"].ToString();
            dtpNgayThue.Text = dtHD.Rows[0]["NgayThue"].ToString();
            dtpNgayTra.Text = dtHD.Rows[0]["NgayTra"].ToString();
            dtpHanTra.Text = dtHD.Rows[0]["HanTra"].ToString();
            txtGiaThue.Text = dtHD.Rows[0]["GiaThue"].ToString();
            cbbTinhTrang.Text = dtHD.Rows[0]["TinhTrang"].ToString();
            nudSoLuong.Text = dtHD.Rows[0]["SoLuong"].ToString();
            txtPhiPhat.Text = dtHD.Rows[0]["PhiPhat"].ToString();
            txtTongTien.Text = dtHD.Rows[0]["TongTienThue"].ToString();
            txtMaKH.Text = dtHD.Rows[0]["MaKH"].ToString();
            txtMaNV.Text = dtHD.Rows[0]["MaNV"].ToString();
        }

        void HienThiThongTinXe(DataTable X)
        {
            lsvXe.Items.Clear();
            for (int i = 0; i < X.Rows.Count; i++)
            {
                ListViewItem lvi = lsvXe.Items.Add(X.Rows[i][0  ].ToString());
                for (int j = 1; j < X.Columns.Count; j++)
                {
                    lvi.SubItems.Add(X.Rows[i][j].ToString());
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
