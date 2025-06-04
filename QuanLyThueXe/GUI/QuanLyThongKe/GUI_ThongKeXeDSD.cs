using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.BLL;
using QuanLyThueXe.DAL;

namespace QuanLyThueXe
{
    public partial class GUI_ThongKeXeDSD : Form
    {
        BLL_QuanLyThongKe bllThongKe = new BLL_QuanLyThongKe();
        public GUI_ThongKeXeDSD()
        {
            InitializeComponent();
            DataTable dt = bllThongKe.getListXeDuocSuDung();
            
            LoadlistXeDuocSuDung(dt);
            HienComboBoxPhanLoai();
        }

        public void LoadlistXeDuocSuDung(DataTable dt)
        {
            lsvXe.Items.Clear();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvXe.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }
            }
        }


        public void HienComboBoxPhanLoai()
        {
            DataTable dt = bllThongKe.PhanLoaiXe();
            cbbTinhTrang.DataSource = dt;
            cbbTinhTrang.DisplayMember = "TinhTrang";
            cbbTinhTrang.ValueMember = "TinhTrang";
        }

        private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = bllThongKe.HienThiPhanLoaiXe(cbbTinhTrang.SelectedValue.ToString());
            LoadlistXeDuocSuDung(dt);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
