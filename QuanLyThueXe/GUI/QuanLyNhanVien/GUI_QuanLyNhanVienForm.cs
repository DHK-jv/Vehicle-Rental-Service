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

namespace QuanLyThueXe
{
    public partial class GUI_QuanLyNhanVienForm : Form
    {
        BLL_QuanLyNhanVien bllNhanVien = new BLL_QuanLyNhanVien();

        public GUI_QuanLyNhanVienForm()
        {
            DataTable dt = bllNhanVien.getListNhanVien();
            InitializeComponent();

            LoadlistNhanVien(dt);
        }

        public void LoadlistNhanVien(DataTable dt)
        {
            lsvNhanVien.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvNhanVien.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    if (j == 3)
                    {
                        string gender = dt.Rows[i][j].ToString();
                        if (gender == "True")
                        {
                            item.SubItems.Add("Nam"); // Nếu giới tính là "true", hiển thị "Nam"
                        }
                        else if (gender == "False")
                        {
                            item.SubItems.Add("Nữ"); // Nếu giới tính là "false", hiển thị "Nữ"
                        }
                    }
                    else
                    {
                        item.SubItems.Add(dt.Rows[i][j].ToString());
                    }

                }
            }
        }

        public void HienThiListNhanVien()
        {
            DataTable dt = bllNhanVien.getListNhanVien();
            LoadlistNhanVien(dt);
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienFormUpdate qlNhanVienThem = new QuanLyNhanVienFormUpdate(true);
            
            qlNhanVienThem.TopLevel = false; // Không tạo cửa sổ riêng
            qlNhanVienThem.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            qlNhanVienThem.Dock = DockStyle.Fill;
            this.Controls.Add(qlNhanVienThem);
            qlNhanVienThem.BringToFront();
            qlNhanVienThem.sendData += HienThiListNhanVien;
            qlNhanVienThem.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count == 1)
            {
                QuanLyNhanVienFormUpdate qlNhanVienUpdate = new QuanLyNhanVienFormUpdate(false, lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                qlNhanVienUpdate.TopLevel = false; // Không tạo cửa sổ riêng
                qlNhanVienUpdate.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
                qlNhanVienUpdate.Dock = DockStyle.Fill;
                this.Controls.Add(qlNhanVienUpdate);
                qlNhanVienUpdate.BringToFront();
                qlNhanVienUpdate.sendData += HienThiListNhanVien;                           
                qlNhanVienUpdate.Show();
            }
            else
            {
                MessageBox.Show("Chọn xe cần sửa thông tin!!!", "Lỗi sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    if (bllNhanVien.XoaNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text))
                    {
                        MessageBox.Show("Xóa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiListNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần xóa thông tin!!!", "Lỗi xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void HienThiTimKiem(DataTable dt)
        {
            lsvNhanVien.Items.Clear();     // Xóa dữ liệu cũ trên ListView
            for (int i = 0; i < dt.Rows.Count; i++)     // Duyệt qua tất cả các dòng của DataTable
            {
                ListViewItem item = lsvNhanVien.Items.Add(dt.Rows[i][0].ToString()); // Lấy dữ liệu từ cột đầu tiên của DataTable
                for (int j = 1; j < dt.Columns.Count; j++) // Duyệt theo số lượng cột có trong DataTable
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());    // Lấy dữ liệu từ các cột còn lại của DataTable
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = bllNhanVien.Search(txtTim.Text);
            HienThiTimKiem(dt);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý Nhân Viên?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lsvNhanVien.Text = string.Empty;
            txtTim.Text = string.Empty;
            HienThiListNhanVien();
        }
    }
}
