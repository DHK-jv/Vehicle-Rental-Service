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
using System.IO;


namespace QuanLyThueXe
{
    
    public partial class QuanLyXeFormUpdate : Form
    {

        BLL_QuanLyXe bllXe = new BLL_QuanLyXe();
        private string PATH = AppDomain.CurrentDomain.BaseDirectory;
        private string linkanh = string.Empty;
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public QuanLyXeFormUpdate(bool b)
        {
            InitializeComponent();
            SetButton(b);
        }

        public QuanLyXeFormUpdate(bool b, string MaXe)
        {
            InitializeComponent();
            SetButton(b);
            HienThiThongTinTheoID(MaXe);
        }

        public void SetButton(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = !b;
            btnRefesh.Enabled = b;
            btnOut.Enabled = true;
        }

        public void HienThiThongTinTheoID(string key)
        {
            DataTable dt = bllXe.LayThongTinTheoMaXe(key);
            txtMaXe.Text = dt.Rows[0][0].ToString();
            txtTenXe.Text = dt.Rows[0][1].ToString();
            txtBienSo.Text = dt.Rows[0][2].ToString();
            txtMauSac.Text = dt.Rows[0][3].ToString();
            cbbTinhTrang.Text = dt.Rows[0][4].ToString();
            nudSoLuong.Text = dt.Rows[0][5].ToString();
            if (!string.IsNullOrEmpty(dt.Rows[0][6].ToString()))
            {
                picAnh.Image = Image.FromFile(dt.Rows[0][6].ToString());
                linkanh = dt.Rows[0][6].ToString();
            }
            txtGiaThue.Text = dt.Rows[0][7].ToString();
            dtpNamSX.Text = dt.Rows[0][8].ToString();
            cbbLoaiXe.Text = dt.Rows[0][9].ToString();
            txtMaHX.Text = dt.Rows[0][10].ToString();
        }

        private Xe LayXe()
        {
            Xe xe = new Xe();
            xe.setMaXe(txtMaXe.Text);
            xe.setTenXe(txtTenXe.Text);
            xe.setBienSo(txtBienSo.Text);
            xe.setMauSac(txtMauSac.Text);
            xe.setTinhTrang(cbbTinhTrang.Text);
            xe.setSoLuong(Convert.ToInt32(nudSoLuong.Value));
            xe.setHinhAnh(linkanh);
            xe.setGiaThue(decimal.Parse(txtGiaThue.Text));
            xe.setNamSanXuat(dtpNamSX.Value);
            xe.setLoaiXe(cbbLoaiXe.Text);
            xe.setMaHX(txtMaHX.Text);
            return xe;
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát khỏi trình thêm, sửa xe ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void refesh()
        {
            txtMaXe.Text = "";
            cbbLoaiXe.Text = "";
            txtTenXe.Text = "";
            txtGiaThue.Text = "";
            txtBienSo.Text = "";
            txtMauSac.Text = "";
            dtpNamSX.Text = "";
            nudSoLuong.Text = "";
            cbbTinhTrang.Text = "";
            txtMaHX.Text = "";
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            refesh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Xe xe = LayXe();
            try
            {
                
                if (bllXe.ThemXe(xe))
                {
                    MessageBox.Show("Thêm xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Không thể thêm Xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Xe xe = LayXe();
            try
            {
                if (bllXe.CapNhatXe(xe))
                {

                    MessageBox.Show("Sửa xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    sendData?.Invoke();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể sửa Xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.InitialDirectory = PATH + "Access\\Image Vihisless";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    picAnh.Image = Image.FromFile(openfile.FileName);
                    linkanh = "Access\\Image Vehicles\\" + Path.GetFileName(openfile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
