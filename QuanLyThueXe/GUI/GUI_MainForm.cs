
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.BLL;
using QuanLyThueXe.DTO;

namespace QuanLyThueXe.GUI
{

    public partial class GUI_MainForm : Form
    {

        public string MaNhanVienDangSuDungHeThong { get; set; }

        public GUI_MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            MainStart();
            setButton(true, true);
        }
        public GUI_MainForm(string quyen, string maNhanVien)
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Đảm bảo MainForm là MDI Container
            MainStart();

            if (quyen == "Admin")
            {
                setButton(true, true);
            }
            else if (quyen == "Nhân viên")
            {
                setButton(false, true);
            }
            MaNhanVienDangSuDungHeThong = maNhanVien;
        }

        private void MainStart()
        {
            try
            {
                Form frm = new GUI_BackgroundMain();
                //MessageBox.Show("Tạo form thành công!"); // Kiểm tra xem form có thể khởi tạo không
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo GUI_BackgroundMain: " + ex.Message);
            }
        }

        private void setButton(bool Admin, bool NhanVien)
        {
            btnMoFormXe.Enabled = NhanVien;
            btnMoFormHopDong.Enabled = NhanVien;
            btnMoFormNhanVien.Enabled = Admin;
            btnMoFormKhachHang.Enabled = NhanVien;
            btnMoFormThongKe.Enabled = Admin;
            btnMoFormThanhToan.Enabled = NhanVien;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnMoFormThongKe_Click(object sender, EventArgs e)
        {
            btnMoFormThongKe.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyThongkeForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyThongKeForm frmTK = new GUI_QuanLyThongKeForm();

            frmTK.MdiParent = this;

            frmTK.Dock = DockStyle.Fill;
            frmTK.Show();
            frmTK.FormClosed += (s, args) =>
            {
                btnMoFormThongKe.BackColor = Color.CornflowerBlue;
            };
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formlogin = new GUI_LoginForm();
            formlogin.ShowDialog();
            this.Close();
        }

        private void btnMoFormXe_Click(object sender, EventArgs e)
        {
            btnMoFormXe.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyXeForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }

            GUI_QuanLyXeForm frmXe = new GUI_QuanLyXeForm();

            frmXe.MdiParent = this;

            frmXe.Dock = DockStyle.Fill;
            frmXe.Show();
            frmXe.FormClosed += (s, args) =>
            {
                btnMoFormXe.BackColor = Color.CornflowerBlue;
            };

        }

        private void btnMoFormHopDong_Click(object sender, EventArgs e)
        {
            btnMoFormHopDong.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyHopDongForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyHopDongForm frmHD = new GUI_QuanLyHopDongForm(MaNhanVienDangSuDungHeThong);

            frmHD.MdiParent = this;

            frmHD.Dock = DockStyle.Fill;
            frmHD.Show();
            frmHD.FormClosed += (s, args) =>
            {
                btnMoFormHopDong.BackColor = Color.CornflowerBlue;
            };

        }

        private void btnMoFormNhanVien_Click(object sender, EventArgs e)
        {
            btnMoFormNhanVien.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyNhanVienForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyNhanVienForm frmNV = new GUI_QuanLyNhanVienForm();

            frmNV.MdiParent = this;

            frmNV.Dock = DockStyle.Fill;
            frmNV.Show();
            frmNV.FormClosed += (s, args) =>
            {
                btnMoFormNhanVien.BackColor = Color.CornflowerBlue;
            };
        }

        private void btnMoFormKhachHang_Click(object sender, EventArgs e)
        {
            btnMoFormKhachHang.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyKhachHangForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyKhachHangForm frmKH = new GUI_QuanLyKhachHangForm();

            frmKH.MdiParent = this;

            frmKH.Dock = DockStyle.Fill;
            frmKH.Show();
            frmKH.FormClosed += (s, args) =>
            {
                btnMoFormKhachHang.BackColor = Color.CornflowerBlue;
            };

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GUI_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMoFormThanhToan_Click(object sender, EventArgs e)
        {
            btnMoFormThanhToan.BackColor = Color.LightBlue;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "QuanLyThanhToanForm")
                {
                    frm.Activate();
                    return;
                }
                else if (frm.Name != "GUI_BackgroundMain")
                {
                    frm.Close();
                }
            }
            GUI_QuanLyThanhToanForm frmTT = new GUI_QuanLyThanhToanForm();

            frmTT.MdiParent = this;

            frmTT.Dock = DockStyle.Fill;
            frmTT.Show();
            frmTT.FormClosed += (s, args) =>
            {
                btnMoFormThanhToan.BackColor = Color.CornflowerBlue;
            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
