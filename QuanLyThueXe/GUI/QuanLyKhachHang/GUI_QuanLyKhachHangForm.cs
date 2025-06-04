using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.BLL;
using QuanLyThueXe.DTO;

namespace QuanLyThueXe.GUI
{
    public partial class GUI_QuanLyKhachHangForm : Form
    {
        BLL_QuanLyKhachHang bllKhachHang = new BLL_QuanLyKhachHang();
        public GUI_QuanLyKhachHangForm()
        {
            DataTable dt = bllKhachHang.getListKhachHang();

            InitializeComponent();

            LoadlistKhachHang(dt);
            HienThiListKhachHang();
        }
        public void LoadlistKhachHang(DataTable dt)
        {
            lsvKhachHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvKhachHang.Items.Add(dt.Rows[i][0].ToString());
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
        public void HienThiListKhachHang()
        {
            DataTable dt = bllKhachHang.getListKhachHang();
            LoadlistKhachHang(dt);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = bllKhachHang.Search(txtTim.Text);
            HienThiTimKiem(dt);
        }
        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedItems.Count == 1)
            {
                GUI_QuanLyKhachHangFormUpdate qlKhachHangUpdate = new GUI_QuanLyKhachHangFormUpdate(false, lsvKhachHang.SelectedItems[0].SubItems[0].Text);
                qlKhachHangUpdate.TopLevel = false; // Không tạo cửa sổ riêng
                qlKhachHangUpdate.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
                qlKhachHangUpdate.Dock = DockStyle.Fill;
                this.Controls.Add(qlKhachHangUpdate);
                qlKhachHangUpdate.BringToFront();
                qlKhachHangUpdate.sendData += HienThiListKhachHang;
                qlKhachHangUpdate.Show();
            }
            else
            {
                MessageBox.Show("Chọn Khách Hàng cần sửa thông tin!!!", "Lỗi sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            GUI_QuanLyKhachHangFormUpdate qlKhachHangAdd = new GUI_QuanLyKhachHangFormUpdate(true);
            qlKhachHangAdd.TopLevel = false; // Không tạo cửa sổ riêng
            qlKhachHangAdd.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            qlKhachHangAdd.Dock = DockStyle.Fill;
            this.Controls.Add(qlKhachHangAdd);
            qlKhachHangAdd.BringToFront();
            //qlKhachHangAdd.sendData += HienThiListKhachHang;
            qlKhachHangAdd.Show(); 
        }

        public void HienThiTimKiem(DataTable dt)
        {
            lsvKhachHang.Items.Clear();     // Xóa dữ liệu cũ trên ListView
            for (int i = 0; i < dt.Rows.Count; i++)     // Duyệt qua tất cả các dòng của DataTable
            {
                ListViewItem item = lsvKhachHang.Items.Add(dt.Rows[i][0].ToString()); // Lấy dữ liệu từ cột đầu tiên của DataTable
                for (int j = 1; j < dt.Columns.Count; j++) // Duyệt theo số lượng cột có trong DataTable
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());    // Lấy dữ liệu từ các cột còn lại của DataTable
                }
            }

        }


        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        
            DataTable dt = bllKhachHang.DanhSachTheoKhachHang(cbbGioiTinh.SelectedValue.ToString());
            LoadlistKhachHang(dt);
        
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý Khách hàng?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin khách hàng này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string MaKH = lsvKhachHang.SelectedItems[0].SubItems[0].Text;
                    if (bllKhachHang.XoaKhachHang(MaKH))
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiListKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn khách hàng cần xóa thông tin!!!", "Lỗi xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
            lsvKhachHang.Text = string.Empty;
            HienThiListKhachHang();
        }
    }
}
