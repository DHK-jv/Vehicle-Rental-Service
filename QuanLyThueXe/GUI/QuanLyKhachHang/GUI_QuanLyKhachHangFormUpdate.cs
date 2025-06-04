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
using QuanLyThueXe.DTO;


namespace QuanLyThueXe
{
    public partial class GUI_QuanLyKhachHangFormUpdate : Form
    {
        BLL_QuanLyKhachHang bllKhachHang = new BLL_QuanLyKhachHang();
        public delegate void LoadHandler();
        public event LoadHandler sendData;
        public GUI_QuanLyKhachHangFormUpdate(bool b)
        {

            InitializeComponent();
            SetButton(b);
        }
        public GUI_QuanLyKhachHangFormUpdate(bool b, string MaKH)
        {
            InitializeComponent();
            SetButton(b);
            DataTable dt = bllKhachHang.LayThongTinTheoMaKH(MaKH);
            HienThiThongTinTheoID(dt);
        }
        public void SetButton(bool b)
        {
            btnThem.Enabled = b;
            btnCapNhat.Enabled = !b;
            btnLamMoi.Enabled = b;
            btnThoat.Enabled = true;
        }
        public void HienThiThongTinTheoID(DataTable HD)
        {
            /*DataTable dt = bllKhachHang.LayThongTinTheoMaKH(key);*/
            txtMaKH.Text = HD.Rows[0]["MaKH"].ToString();
            txtTenKH.Text = HD.Rows[0]["TenKH"].ToString();
            txtCCCD.Text = HD.Rows[0]["CCCD"].ToString();
            txtSoDT.Text = HD.Rows[0]["SoDT"].ToString();
            cbbGioiTinh.Text = HD.Rows[0]["GioiTinh"].ToString();
            txtDiaChi.Text = HD.Rows[0]["DiaChi"].ToString();
            dtpNgaySinh.Text = HD.Rows[0]["NgaySinh"].ToString();
        }
        private KhachHang LayKhachHang()
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = txtMaKH.Text;
            khachHang.TenKH = txtTenKH.Text;
            khachHang.GioiTinh = cbbGioiTinh.Text;
            khachHang.CCCD = txtCCCD.Text;
            khachHang.SoDT = txtSoDT.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.NgaySinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
            
            return khachHang;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
        
            DialogResult dg = MessageBox.Show("Bạn muốn thoát khỏi trình thêm, sửa Khách Hàng ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void LamMoi()
        {
            txtMaKH.Text = "";
            cbbGioiTinh.Text = "";
            txtTenKH.Text = "";
            txtCCCD.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = "";
            
        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            KhachHang khachHang = LayKhachHang();
            try
            {

                if (bllKhachHang.ThemKhachHang(khachHang))
                {
                    MessageBox.Show("Thêm Khách Hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Không thể thêm Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BLL_QuanLyKhachHang.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            KhachHang khachHang = LayKhachHang();
            try
            {

                if (bllKhachHang.CapNhatKhachHang(khachHang))
                {
                    MessageBox.Show("Sửa Khách Hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Không thể thêm Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BLL_QuanLyKhachHang.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void GUI_QuanLyKhachHangFormUpdate_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
