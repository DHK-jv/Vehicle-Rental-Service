
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
    public partial class GUI_QuanLyHopDongFormUpdate : Form
    {
        BLL_QuanLyHopDong bllHD = new BLL_QuanLyHopDong();
        public delegate void LoadHandler();
        public event LoadHandler sendData;

        public GUI_QuanLyHopDongFormUpdate(string MaNV, bool b)
        {
            InitializeComponent();
            txtMaNV.Text = MaNV;
            SetButton(b);
            LoadDSXe(bllHD.getXeConSan());
            LoadDSKhachHang(bllHD.getSearchListKhachHang(txtMaKH.Text));
        }
        public GUI_QuanLyHopDongFormUpdate(bool b, string MaHD)
        {
            InitializeComponent();
            SetButton(b);
            DataTable dt = bllHD.LayThongTinHopDongTheoID(MaHD);
            DataTable dtt = bllHD.LayChiTietThongTinHopDong(MaHD);
            HienThiThongTinHopDong(dt);
            HienThiChiTietHopDong(dtt);
        }

        public void SetButton(bool b)
        {
            btnAdd.Enabled = b;
            btnUpdate.Enabled = !b;
            btnRefesh.Enabled = b;
            btnOut.Enabled = true;
        }
        private HopDong LayHopDong()
        {
            HopDong hd = new HopDong();
            hd.MaHD = txtMaHD.Text;
            hd.NgayThue = dtpNgayThue.Value;
            hd.NgayTra = dtpNgayTra.Value;
            hd.HanTra = dtpHanTra.Value;
            hd.GiaThue = Decimal.Parse(txtGiaThue.Text);
            hd.TinhTrang = cbbTinhTrang.Text;
            hd.SoLuong = int.Parse(nudSoLuong.Text);
            hd.PhiPhat = Decimal.Parse(txtPhiPhat.Text);
            hd.TongTienThue = Decimal.Parse(txtTongTien.Text);
            hd.MaNV = txtMaNV.Text;
            hd.MaKH = txtMaKH.Text;
            return hd;
        }

        public List<Xe> LayXe()
        {
            List<Xe> list = new List<Xe>();
            for (int i = 0; i < lsvXe.Items.Count; i++)
            {
                Xe xe = new Xe();
                xe.MaXe = lsvXe.Items[i].SubItems[0].Text;
                list.Add(xe);
            }
            return list;

        }

        public void LoadDSXe(DataTable dsX)
        {
            lsvSearchXe.Items.Clear();
            for (int i = 0; i < dsX.Rows.Count; i++)
            {
                ListViewItem item = lsvSearchXe.Items.Add(dsX.Rows[i][0].ToString());
                for (int j = 1; j < dsX.Columns.Count; j++)
                {
                    item.SubItems.Add(dsX.Rows[i][j].ToString());
                }
            }
        }

        public void LoadDSKhachHang(DataTable dsKH)
        {
            lsvSearchKH.Items.Clear();
            for (int i = 0; i < dsKH.Rows.Count; i++)
            {
                ListViewItem item = lsvSearchKH.Items.Add(dsKH.Rows[i][0].ToString());
                for (int j = 1; j < dsKH.Columns.Count; j++)
                {
                    if (j == 3)
                    {
                        string gender = dsKH.Rows[i][j].ToString();
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
                        item.SubItems.Add(dsKH.Rows[i][j].ToString());
                    }
                    
                }
            }
        }

        public void HienThiThongTinHopDong(DataTable dt)
        {
            txtMaHD.Text = dt.Rows[0]["MaHD"].ToString();
            dtpNgayThue.Value = DateTime.Parse(dt.Rows[0]["NgayThue"].ToString());
            dtpNgayTra.Value = DateTime.Parse(dt.Rows[0]["NgayTra"].ToString());
            dtpHanTra.Value = DateTime.Parse(dt.Rows[0]["HanTra"].ToString());
            txtGiaThue.Text = dt.Rows[0]["GiaThue"].ToString();
            cbbTinhTrang.Text = dt.Rows[0]["TinhTrang"].ToString();
            nudSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
            txtPhiPhat.Text = dt.Rows[0]["PhiPhat"].ToString();
            txtTongTien.Text = dt.Rows[0]["TongTienThue"].ToString();
            txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
            txtMaNV.Text = dt.Rows[0]["MaNV"].ToString();

        }

        public void HienThiChiTietHopDong(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvXe.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }
            }
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình thêm, sửa hợp đồng ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HopDong hd = LayHopDong();
            
            List<Xe> list = LayXe();
            try
            {
                if (bllHD.Add(hd, list))
                {
                    MessageBox.Show("Thêm hợp đồng thành công");
                    this.Close();
                    sendData?.Invoke();
                }
                else
                {
                    MessageBox.Show("Không thể thêm hợp đồng");
                }

            }
            catch (BLL_QuanLyHopDong.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lsvSearchXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSearchXe.SelectedItems.Count > 0) // Kiểm tra xem có được chọn hay không
            {
                ListViewItem selectedItem = lsvSearchXe.SelectedItems[0];

                // Tạo một bản sao của item được chọn và thêm vào lsvListSach
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone(); // Clone item được chọn để thêm vào listview
                lsvXe.Items.Add(clonedItem); // Thêm Xe vào listview xe

                lsvSearchXe.Items.Remove(selectedItem); // Xóa xe được chọn khỏi listview tìm kiếm
                nudSoLuong.Value = lsvXe.Items.Count;    // vì bắt đầu từ 1 nên dùng đếm số lượng xe trong listview để gán vào số lượng
                //nudSoluong.Value += 1;
            }
        }

        private void btnDeleteListXe_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có xe được chọn hay không
                if (lsvXe.SelectedItems.Count > 0)
                {
                    // Xóa xe đang chọn trong danh xe xe
                    lsvXe.SelectedItems[0].Remove();

                    //Cập nhật số lượng xe
                    nudSoLuong.Value = lsvXe.Items.Count;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Chọn xe cần xóa khỏi danh xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                DialogResult result = MessageBox.Show("Lỗi khi xóa xe khỏi danh xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            lsvSearchKH.Items.Clear();
            DataTable dsKH = bllHD.getSearchListKhachHang(txtSearchKH.Text); //Lấy danh xe độc giả từ database theo từ khóa tìm kiếm
            LoadDSKhachHang(dsKH); //Hiển thị danh xe độc giả lên listview
        }

        private void lsvSearchKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dsKH = bllHD.getSearchListKhachHang(txtSearchKH.Text);
            if (lsvSearchKH.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvSearchKH.SelectedItems[0];
                txtMaKH.Text = selectedItem.SubItems[0].Text;
            }
        }

        private void Refesh()
        {
            txtMaHD.Text = string.Empty;
            dtpNgayThue.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            dtpHanTra.Value = DateTime.Now;
            txtGiaThue.Text = string.Empty;
            cbbTinhTrang.Text = string.Empty;
            nudSoLuong.Text = string.Empty;
            txtPhiPhat.Text = string.Empty;
            txtTongTien.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtMaNV.Text = string.Empty;
            txtSearchKH.Text = string.Empty;
            txtMaHD.Text = string.Empty;
            lsvXe.Items.Clear();
            lsvSearchKH.Items.Clear();
            lsvSearchXe.Items.Clear();
            lsvXe.Items.Clear();
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            Refesh();
        }

        private void btnSearchXe_Click(object sender, EventArgs e)
        {
            lsvSearchXe.Items.Clear();
            BLL_QuanLyHopDong bllHD = new BLL_QuanLyHopDong();
            DataTable dsX = bllHD.getSearchListXe(txtSearchXe.Text);
            //LoadDSXe(dsX);
            foreach (DataRow row in dsX.Rows)
            {
                if (row["TinhTrang"].ToString() == "Có sẵn") // Dieu kien de hien thi sach
                {
                    ListViewItem item = new ListViewItem(row["MaXe"].ToString());
                    item.SubItems.Add(row["TenXe"].ToString());
                    item.SubItems.Add(row["BienSo"].ToString());
                    item.SubItems.Add(row["MauSac"].ToString());
                    item.SubItems.Add(row["TinhTrang"].ToString());
                    item.SubItems.Add(row["SoLuong"].ToString());
                    item.SubItems.Add(row["GiaThue"].ToString());
                    item.SubItems.Add(row["NamSanXuat"].ToString());
                    item.SubItems.Add(row["LoaiXe"].ToString());
                    item.SubItems.Add(row["MaHX"].ToString());

                    // Thêm xe vào ListView
                    lsvSearchXe.Items.Add(item);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HopDong hd = LayHopDong();
            List<Xe> listXe = LayXe();
            try
            {
                if (hd.TinhTrang == "Đang thuê" || hd.TinhTrang == "Quá hạn")
                {
                    bllHD.Update(hd, listXe);
                    try
                    {
                        bllHD.DeleteChiTietHopDong(hd.MaHD);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa chi tiết hợp đồng: " + ex.Message);
                    }

                    foreach (Xe x in listXe)
                    {
                        try
                        {
                            bllHD.AddChiTietHopDong(hd.MaHD, x.MaXe);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi thêm chi tiết hợp đồng: " + ex.Message);
                        }
                        
                    }
                    MessageBox.Show("Cập nhật hợp đồng thành công");
                }
                else if (hd.TinhTrang == "Đã trả")
                {
                    bllHD.UpdateTrangThaiHopDong(hd.MaHD);
                    foreach (Xe x in listXe)
                    {
                        bllHD.UpdateTinhTrangXe(x.MaXe);
                    }
                    MessageBox.Show("Cập nhật hợp đồng thành công");
                }
                    this.Close();
                    sendData?.Invoke();
            }
            catch (BLL_QuanLyHopDong.BusinessLogicException ex)
            {
                MessageBox.Show("Lỗi nghiệp vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhiPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // nếu không phải là số và không phải là phím control
            {
                e.Handled = true; // Không cho nhập
            }
            TinhTongTien();
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayTra.Value > dtpHanTra.Value)
            {
                float giaphat = 10000;
                TimeSpan ngaytre = dtpNgayTra.Value - dtpHanTra.Value;
                int songaytre = Convert.ToInt32(ngaytre.Days);
                int soluong = Convert.ToInt32(nudSoLuong.Value);
                cbbTinhTrang.SelectedIndex = 2;
                txtPhiPhat.Text = (songaytre * giaphat * soluong).ToString();
            }
            else
            {
                cbbTinhTrang.SelectedIndex = 1;
                txtPhiPhat.Text = "0";
            }
        }

        private void TinhTongTien()
        {
            decimal giaThue = 0, phiPhat = 0;
            int soLuong = Convert.ToInt32(nudSoLuong.Value);

            // Chuyển đổi giá trị từ TextBox sang số
            decimal.TryParse(txtGiaThue.Text, out giaThue);
            decimal.TryParse(txtPhiPhat.Text, out phiPhat);

            // Tính tổng tiền (giá thuê + phí phạt) * số lượng
            decimal tongTien = (giaThue + phiPhat) * soLuong;

            // Hiển thị tổng tiền
            txtTongTien.Text = tongTien.ToString();
        }



        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtGiaThue_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
    }
}
