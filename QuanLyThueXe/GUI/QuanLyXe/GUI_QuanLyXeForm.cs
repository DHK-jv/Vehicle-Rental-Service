using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThueXe.BLL;
using QuanLyThueXe.DTO;


namespace QuanLyThueXe.GUI
{
    public partial class GUI_QuanLyXeForm : Form
    {
        BLL_QuanLyXe bllXe = new BLL_QuanLyXe();

        public GUI_QuanLyXeForm()
        {
            DataTable dt = bllXe.getListXe();
            InitializeComponent();
            HienComboBoxPhanLoai();
            LoadlistXe(dt);
        }

        public void LoadlistXe(DataTable dt)
        {
            lsvXe.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvXe.Items.Add(dt.Rows[i][0].ToString());
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }
            }
        }

        public void HienThiListXe()
        {
            DataTable dt = bllXe.getListXe();
            LoadlistXe(dt);
        }


        public void HienComboBoxPhanLoai()
        {
            DataTable dt = bllXe.GetTheLoai();
            cboPhanLoaiXe.DataSource = dt;
            cboPhanLoaiXe.DisplayMember = "LoaiXe";
            cboPhanLoaiXe.ValueMember = "LoaiXe";
        }


        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFeresh = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboPhanLoaiXe = new System.Windows.Forms.ComboBox();
            this.lsvXe = new System.Windows.Forms.ListView();
            this.colMaXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBienSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMauSac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNamXS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiXe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFeresh);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnOut);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnFeresh
            // 
            this.btnFeresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFeresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeresh.Location = new System.Drawing.Point(655, 40);
            this.btnFeresh.Name = "btnFeresh";
            this.btnFeresh.Size = new System.Drawing.Size(235, 57);
            this.btnFeresh.TabIndex = 5;
            this.btnFeresh.Text = "Làm mới";
            this.btnFeresh.UseVisualStyleBackColor = false;
            this.btnFeresh.Click += new System.EventHandler(this.btnFeresh_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(342, 114);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(235, 57);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Xem chi tiết xe";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(655, 114);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(235, 57);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(17, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa thông tin xe";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(342, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(235, 57);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa thông tin xe";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(17, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 57);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm xe mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(558, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(269, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // cboPhanLoaiXe
            // 
            this.cboPhanLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanLoaiXe.FormattingEnabled = true;
            this.cboPhanLoaiXe.Location = new System.Drawing.Point(32, 35);
            this.cboPhanLoaiXe.Name = "cboPhanLoaiXe";
            this.cboPhanLoaiXe.Size = new System.Drawing.Size(235, 33);
            this.cboPhanLoaiXe.TabIndex = 2;
            this.cboPhanLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cboPhanLoaiXe_SelectedIndexChanged);
            this.cboPhanLoaiXe.SelectionChangeCommitted += new System.EventHandler(this.cboPhanLoaiXe_SelectionChangeCommitted);
            // 
            // lsvXe
            // 
            this.lsvXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaXe,
            this.colTenXe,
            this.colBienSo,
            this.colMauSac,
            this.colTinhTrang,
            this.colSoLuong,
            this.colGiaThue,
            this.colNamXS,
            this.colLoaiXe,
            this.colMaHX});
            this.lsvXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvXe.FullRowSelect = true;
            this.lsvXe.GridLines = true;
            this.lsvXe.HideSelection = false;
            this.lsvXe.Location = new System.Drawing.Point(15, 81);
            this.lsvXe.Name = "lsvXe";
            this.lsvXe.Size = new System.Drawing.Size(900, 334);
            this.lsvXe.TabIndex = 3;
            this.lsvXe.UseCompatibleStateImageBehavior = false;
            this.lsvXe.View = System.Windows.Forms.View.Details;
            this.lsvXe.SelectedIndexChanged += new System.EventHandler(this.lsvXe_SelectedIndexChanged);
            // 
            // colMaXe
            // 
            this.colMaXe.Text = "Mã xe";
            this.colMaXe.Width = 80;
            // 
            // colTenXe
            // 
            this.colTenXe.Text = "Tên xe";
            this.colTenXe.Width = 150;
            // 
            // colBienSo
            // 
            this.colBienSo.Text = "Biển số";
            this.colBienSo.Width = 100;
            // 
            // colMauSac
            // 
            this.colMauSac.Text = "Màu sắc";
            this.colMauSac.Width = 70;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình trạng";
            this.colTinhTrang.Width = 80;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 80;
            // 
            // colGiaThue
            // 
            this.colGiaThue.Text = "Giá thuê";
            this.colGiaThue.Width = 100;
            // 
            // colNamXS
            // 
            this.colNamXS.Text = "Năm sản xuất";
            this.colNamXS.Width = 100;
            // 
            // colLoaiXe
            // 
            this.colLoaiXe.Text = "Loại xe";
            // 
            // colMaHX
            // 
            this.colMaHX.Text = "Mã hãng xe";
            this.colMaHX.Width = 120;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLyThueXe.Properties.Resources.magnifier;
            this.btnSearch.Location = new System.Drawing.Point(833, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GUI_QuanLyXeForm
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.lsvXe);
            this.Controls.Add(this.cboPhanLoaiXe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyXeForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_QuanLyXeForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }  // Hệ thống tự tạo

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát trình quản lý xe ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            QuanLyXeFormUpdate qlXeAdd = new QuanLyXeFormUpdate(true);

            qlXeAdd.TopLevel = false; // Không tạo cửa sổ riêng
            qlXeAdd.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
            qlXeAdd.Dock = DockStyle.Fill;
            this.Controls.Add(qlXeAdd);
            qlXeAdd.BringToFront();
            qlXeAdd.sendData += HienThiListXe;
            qlXeAdd.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( lsvXe.SelectedItems.Count == 1)
            {
                QuanLyXeFormUpdate qlXeUpdate = new QuanLyXeFormUpdate(false, lsvXe.SelectedItems[0].SubItems[0].Text);
                qlXeUpdate.TopLevel = false; // Không tạo cửa sổ riêng
                qlXeUpdate.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền
                qlXeUpdate.Dock = DockStyle.Fill;
                this.Controls.Add(qlXeUpdate);
                qlXeUpdate.BringToFront();
                qlXeUpdate.sendData += HienThiListXe;
                qlXeUpdate.Show();
            }
            else
            {
                MessageBox.Show("Chọn xe cần sửa thông tin!!!", "Lỗi sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lsvXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void HienThiTimKiem(DataTable dt)
        {
            lsvXe.Items.Clear();     // Xóa dữ liệu cũ trên ListView
            for (int i = 0; i < dt.Rows.Count; i++)     // Duyệt qua tất cả các dòng của DataTable
            {
                ListViewItem item = lsvXe.Items.Add(dt.Rows[i][0].ToString()); // Lấy dữ liệu từ cột đầu tiên của DataTable
                for (int j = 1; j < dt.Columns.Count; j++) // Duyệt theo số lượng cột có trong DataTable
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());    // Lấy dữ liệu từ các cột còn lại của DataTable
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = bllXe.Search(txtSearch.Text);
            HienThiTimKiem(dt);
        }

        private void cboPhanLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = bllXe.DanhSachTheoLoaiXe(cboPhanLoaiXe.SelectedValue.ToString());
            LoadlistXe(dt);
        }


        private void btnFeresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cboPhanLoaiXe.Text = string.Empty;
            HienThiListXe();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lsvXe.SelectedItems.Count == 1)
            {
                GUI_QuanLyXeFormDetail frm = new GUI_QuanLyXeFormDetail(lsvXe.SelectedItems[0].SubItems[0].Text);
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

        private void cboPhanLoaiXe_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvXe.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin xe này?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bllXe.XoaXe(lsvXe.SelectedItems[0].Text))
                    {
                        HienThiListXe();
                        MessageBox.Show("Xóa thông tin xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin xe thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn xe cần xóa thông tin!!!", "Lỗi xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GUI_QuanLyXeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                txtSearch.Focus();
            }
        }
    }
}
