using QuanLyThueXe;
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
    public partial class GUI_QuanLyThongKeForm : Form
    {
        BLL_QuanLyThongKe bllThongKe = new BLL_QuanLyThongKe();
        public GUI_QuanLyThongKeForm()
        {
            DataTable dt = new DataTable();
            InitializeComponent();
            //LoadlistXe(dt);
            HienThiListXe();
            HienThiTongSoLuong();
        }


        public void LoadlistXe(DataTable dt)
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

        public void HienThiListXe()
        {
            DataTable dt = bllThongKe.getListXe();
            LoadlistXe(dt);
        }

        private void HienThiTongSoLuong()
        {
            DataTable dt = bllThongKe.getTongSoLuong();

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                txtTongSoLuong.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                txtTongSoLuong.Text = "0"; // Nếu không có dữ liệu, hiển thị 0
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI_DoanhThu qlDoanhThu = new GUI_DoanhThu();

            qlDoanhThu.TopLevel = false; // Không tạo cửa sổ riêng
            qlDoanhThu.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            qlDoanhThu.Dock = DockStyle.Fill;
            this.Controls.Add(qlDoanhThu);
            qlDoanhThu.BringToFront();
            qlDoanhThu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_ThongKeXeDSD qlXeDSD = new GUI_ThongKeXeDSD();
            
                qlXeDSD.TopLevel = false;
                qlXeDSD.FormBorderStyle = FormBorderStyle.None;
                qlXeDSD.Dock = DockStyle.Fill;
                this.Controls.Add(qlXeDSD);
                qlXeDSD.BringToFront();
                qlXeDSD.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_XeThueNhieuNhat qlXeTNN = new GUI_XeThueNhieuNhat();

            qlXeTNN.TopLevel = false; // Không tạo cửa sổ riêng
            qlXeTNN.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            qlXeTNN.Dock = DockStyle.Fill;
            this.Controls.Add(qlXeTNN);
            qlXeTNN.BringToFront();
            qlXeTNN.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý thống kê ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
