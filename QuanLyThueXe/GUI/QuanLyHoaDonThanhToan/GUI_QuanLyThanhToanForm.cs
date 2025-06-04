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
using QuanLyThueXe.DTO;
using System.Data.SqlClient;

namespace QuanLyThueXe.GUI
{
    public partial class GUI_QuanLyThanhToanForm : Form
    {
        BLL_QuanLyThanhToan bllTT = new BLL_QuanLyThanhToan();
        public GUI_QuanLyThanhToanForm()
        {
            DataTable dt = bllTT.getListThanhToan();
            InitializeComponent();
            HienComboBoxPhanLoai();
            LoadlistThanhToan();
        }

        public void LoadlistThanhToan()
        {
            DataTable dt = bllTT.getListThanhToan();
            lsvThanhToan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvThanhToan.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }
            }
        }

        public void HienThiThanhToan()
        {
            DataTable dt = bllTT.getListThanhToan();
            LoadlistThanhToan();
        }

        public void HienThiTimKiem(DataTable dt)
        {
            lsvThanhToan.Items.Clear();     // Xóa dữ liệu cũ trên ListView
            for (int i = 0; i < dt.Rows.Count; i++)     // Duyệt qua tất cả các dòng của DataTable
            {
                ListViewItem item = lsvThanhToan.Items.Add(dt.Rows[i][0].ToString()); // Lấy dữ liệu từ cột đầu tiên của DataTable
                for (int j = 1; j < dt.Columns.Count; j++) // Duyệt theo số lượng cột có trong DataTable
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());    // Lấy dữ liệu từ các cột còn lại của DataTable
                }
            }
        }

        public void HienComboBoxPhanLoai()
        {
            DataTable dt = bllTT.GetTheLoai();
            cboPhanLoaiTT.DataSource = dt;
            cboPhanLoaiTT.DisplayMember = "TinhTrang";
            cboPhanLoaiTT.ValueMember = "TinhTrang";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = bllTT.Search(txtSearch.Text);
            HienThiTimKiem(dt);
        }

        private void cboPhanLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = bllTT.DanhSachThanhToan(cboPhanLoaiTT.SelectedValue.ToString());
            HienThiTimKiem(dt);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lsvThanhToan.SelectedItems.Count == 1)
            {
                GUI_QuanLyThanhToanFormPayments frm = new GUI_QuanLyThanhToanFormPayments(lsvThanhToan.SelectedItems[0].SubItems[0].Text);
                frm.TopLevel = false; // Không tạo cửa sổ riêng
                frm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
                frm.Dock = DockStyle.Fill;
                this.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Chọn hóa đơn cần thanh toán!!!", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý thanh toán ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
            cboPhanLoaiTT.Text = string.Empty;
            HienThiThanhToan();
        }

        
    }
}
