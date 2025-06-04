using QuanLyThueXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using QuanLyThueXe.BLL;

namespace QuanLyThueXe
{
    public partial class QuanLyNhanVienFormUpdate: Form
    {
        BLL_QuanLyNhanVien BLL_NhanVien = new BLL_QuanLyNhanVien();
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public QuanLyNhanVienFormUpdate(bool b)
        {
            InitializeComponent();
            SetButton(b);
            
        }
        public QuanLyNhanVienFormUpdate(bool b, string MaNV)
        {
            InitializeComponent();
            SetButton(b);
            HienThiThongTinTheoID(MaNV);
        }

        public void SetButton(bool b)
        {
            btnThem.Enabled = b;
            btnCapNhat.Enabled = !b;
            /*btnRefesh.Enabled = b;*/
            btnThoat.Enabled = true;
        }
        public void HienThiThongTinTheoID(string key)
        {
            DataTable dt = BLL_NhanVien.LayThongTinTheoMaNV(key);
            txtMaNV.Text = dt.Rows[0][0].ToString();
            txtTenNV.Text = dt.Rows[0][1].ToString();
            dtpNgaySinh.Text = dt.Rows[0][2].ToString();
            cbbGioiTinh.Text = dt.Rows[0][3].ToString();
            txtSoDT.Text = dt.Rows[0][4].ToString();
            txtDiaChi.Text = dt.Rows[0][5].ToString();
            txtUserName.Text = dt.Rows[0][6].ToString();
            
        }
        
        private NhanVien LayNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = txtMaNV.Text;
            nhanVien.GioiTinh = cbbGioiTinh.Text;
            nhanVien.TenNV = txtTenNV.Text;
            nhanVien.SoDT = txtSoDT.Text;
            nhanVien.DiaChi = txtDiaChi.Text;
            nhanVien.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            nhanVien.UserName = txtUserName.Text;
            return nhanVien;
        }

        private TaiKhoan LayTaiKhoan()
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.setUserName(txtUserName.Text);
            taiKhoan.setPassWord(txtPassWord.Text);
            return taiKhoan;
        }




        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            NhanVien nhanVien = LayNhanVien();
            TaiKhoan taiKhoan = LayTaiKhoan();
            try
            {
                if (BLL_NhanVien.CapNhatNhanVien(nhanVien, taiKhoan))
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sendData?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể sửa nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BLL_QuanLyNhanVien.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý Nhân Viên?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = LayNhanVien();
            TaiKhoan taiKhoan = LayTaiKhoan();
            try
            {

                if (BLL_NhanVien.ThemNhanVien(nhanVien, taiKhoan))
                {
                    MessageBox.Show("Thêm nhân viên và tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BLL_QuanLyNhanVien.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSoDT_Click(object sender, EventArgs e)
        {

        }

        private void lbGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lbMaNV_Click(object sender, EventArgs e)
        {

        }
    }
}
