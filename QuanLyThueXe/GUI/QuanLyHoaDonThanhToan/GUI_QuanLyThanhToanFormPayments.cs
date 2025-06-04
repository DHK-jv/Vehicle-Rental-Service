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

namespace QuanLyThueXe
{
    public partial class GUI_QuanLyThanhToanFormPayments : Form
    {
        BLL_QuanLyThanhToan bllTT = new BLL_QuanLyThanhToan();
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public GUI_QuanLyThanhToanFormPayments(string key)
        {
            InitializeComponent();
            DataTable dt = bllTT.LayThongTinThanhToan(key);
            HienThiThongTinTheoID(dt);
        }

        public void HienThiThongTinTheoID(DataTable dt)
        {
            txtMaTT.Text = dt.Rows[0]["MaTT"].ToString();
            dtpNgayTT.Text = dt.Rows[0]["NgayThanhToan"].ToString();
            txtSoTien.Text = dt.Rows[0]["SoTien"].ToString();
            cboTrangThai.Text = dt.Rows[0]["TinhTrang"].ToString();
            cboPhuongThucTT.Text = dt.Rows[0]["PhuongThucTT"].ToString();
        }
        public ThanhToan LayHoaDon()
        {
            ThanhToan tt = new ThanhToan();
            tt.MaTT = txtMaTT.Text;
            tt.NgayThanhToan = dtpNgayTT.Value;
            tt.PhuongThucTT = cboPhuongThucTT.Text;
            tt.TinhTrang = cboTrangThai.Text;
            tt.SoTien = Decimal.Parse(txtSoTien.Text);
            return tt;
        }

        public void refesh()
        {
            txtMaTT.Clear();
            dtpNgayTT.ResetText();
            cboPhuongThucTT.ResetText();
            cboTrangThai.ResetText();
            txtSoTien.Clear();
            txtMaTT.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ThanhToan tt = LayHoaDon();
            try
            {
                if (bllTT.CapNhatThanhToan(tt))
                {
                    // Giả sử bạn có phương thức lấy MaHD và MaXe từ tt hoặc từ cơ sở dữ liệu
                    string maHD = bllTT.LayMaHD(tt.MaTT); // Cần triển khai phương thức này
                    string maXe = bllTT.LayMaXe(tt.MaTT); // Cần triển khai phương thức này

                    if (!string.IsNullOrEmpty(maHD) && !string.IsNullOrEmpty(maXe))
                    {
                        bllTT.UpdateCTTT(maHD, maXe);
                    }

                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    sendData?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BLL_QuanLyXe.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
