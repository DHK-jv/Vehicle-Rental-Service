
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

namespace QuanLyThueXe.GUI
{
    public partial class GUI_QuanLyHopDongForm : Form
    {
        
        BLL_QuanLyHopDong bllHD = new BLL_QuanLyHopDong();

        string MaNV = string.Empty;
        public GUI_QuanLyHopDongForm(string manhanvien)
        {
            MaNV = manhanvien;   
            DataTable dt = bllHD.getListHopDong();
            InitializeComponent();
            HienComboBoxTrangThai();
            LoadlistHopDong(dt);
        }

        public void LoadlistHopDong(DataTable dt)
        {
            lsvHopDong.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvHopDong.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }
            }
        }
        public void HienThiListHopDong()
        {
            DataTable dt = bllHD.getListHopDong();
            LoadlistHopDong(dt);
        }
        public void HienComboBoxTrangThai()
        {
            DataTable dt = bllHD.GetTrangThai();
            cboPhanLoai.DataSource = dt;
            cboPhanLoai.DisplayMember = "TinhTrang";
            cboPhanLoai.ValueMember = "TinhTrang";
        }
        

        /*-------------------------------------Events--------------------------------------------*/
        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý hợp đồng ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnFeresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cboPhanLoai.SelectedIndex = 0;
            HienThiListHopDong();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = bllHD.Search(txtSearch.Text);
            LoadlistHopDong(dt);
        }

        private void cboPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = bllHD.DanhSachTheoTinhTrang(cboPhanLoai.SelectedValue.ToString());
            LoadlistHopDong(dt);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_QuanLyHopDongFormUpdate frmAdd = new GUI_QuanLyHopDongFormUpdate(MaNV, true);

            frmAdd.TopLevel = false; // Không tạo cửa sổ riêng
            frmAdd.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            frmAdd.Dock = DockStyle.Fill;
            this.Controls.Add(frmAdd);
            frmAdd.BringToFront();
            frmAdd.sendData += HienThiListHopDong;
            frmAdd.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lsvHopDong.SelectedItems.Count == 1)
            {
                GUI_QuanLyHopDongFormUpdate frm = new GUI_QuanLyHopDongFormUpdate(false, lsvHopDong.SelectedItems[0].SubItems[0].Text);

                frm.TopLevel = false; // Không tạo cửa sổ riêng
                frm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
                frm.Dock = DockStyle.Fill;
                this.Controls.Add(frm);
                frm.BringToFront();
                frm.sendData += HienThiListHopDong;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Chọn hợp đồng cần sửa thông tin!!!", "Lỗi sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvHopDong.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string MaHD = lsvHopDong.SelectedItems[0].Text;
                    Console.WriteLine("Mã hợp đồng cần xóa: " + MaHD);

                    if (bllHD.Delete(MaHD)) // Truyền trực tiếp MaHD thay vì SelectedItems[0].Text
                    {
                        MessageBox.Show("Xóa hợp đồng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThiListHopDong();
                    }
                    else
                    {
                        MessageBox.Show("Xóa hợp đồng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn hợp đồng cần xóa!!!", "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lsvHopDong.SelectedItems.Count == 1)
            {
                GUI_QuanLyHopDongFormDetail frm = new GUI_QuanLyHopDongFormDetail(lsvHopDong.SelectedItems[0].SubItems[0].Text);
                frm.TopLevel = false; // Không tạo cửa sổ riêng
                frm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
                frm.Dock = DockStyle.Fill;
                this.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Chọn xe cần xem chi tiết!!!", "Lỗi xem chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
