namespace QuanLyThueXe.GUI
{
    partial class GUI_QuanLyHopDongForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFeresh = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboPhanLoai = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsvHopDong = new System.Windows.Forms.ListView();
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHanTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhiPhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.groupBox1.Location = new System.Drawing.Point(20, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 189);
            this.groupBox1.TabIndex = 11;
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
            this.btnView.Text = "Xem chi tiết hợp đồng";
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
            this.btnDelete.Text = "Xóa hợp đồng";
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
            this.btnUpdate.Text = "Sửa hợp đồng";
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
            this.btnAdd.Text = "Thêm hợp đồng";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboPhanLoai
            // 
            this.cboPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanLoai.FormattingEnabled = true;
            this.cboPhanLoai.Location = new System.Drawing.Point(20, 27);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size = new System.Drawing.Size(252, 33);
            this.cboPhanLoai.TabIndex = 12;
            this.cboPhanLoai.SelectedIndexChanged += new System.EventHandler(this.cboPhanLoai_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(546, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 30);
            this.txtSearch.TabIndex = 9;
            // 
            // lsvHopDong
            // 
            this.lsvHopDong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHD,
            this.colNgayThue,
            this.colNgayTra,
            this.colHanTra,
            this.colGiaThue,
            this.colTinhTrang,
            this.colSoLuong,
            this.colPhiPhat,
            this.colTongTien,
            this.colMaNV,
            this.colMaKH});
            this.lsvHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvHopDong.FullRowSelect = true;
            this.lsvHopDong.GridLines = true;
            this.lsvHopDong.HideSelection = false;
            this.lsvHopDong.Location = new System.Drawing.Point(20, 83);
            this.lsvHopDong.Name = "lsvHopDong";
            this.lsvHopDong.Size = new System.Drawing.Size(900, 334);
            this.lsvHopDong.TabIndex = 13;
            this.lsvHopDong.UseCompatibleStateImageBehavior = false;
            this.lsvHopDong.View = System.Windows.Forms.View.Details;
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã hợp đồng";
            this.colMaHD.Width = 80;
            // 
            // colNgayThue
            // 
            this.colNgayThue.Text = "Ngày thuê";
            this.colNgayThue.Width = 80;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Text = "Ngày trả";
            this.colNgayTra.Width = 80;
            // 
            // colHanTra
            // 
            this.colHanTra.Text = "Hạn trả";
            // 
            // colGiaThue
            // 
            this.colGiaThue.Text = "Giá thuê";
            this.colGiaThue.Width = 80;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình trạng";
            this.colTinhTrang.Width = 80;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 70;
            // 
            // colPhiPhat
            // 
            this.colPhiPhat.Text = "Phí phạt";
            this.colPhiPhat.Width = 80;
            // 
            // colTongTien
            // 
            this.colTongTien.Text = "Tổng tiền";
            this.colTongTien.Width = 80;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã nhân viên";
            this.colMaNV.Width = 100;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã khách hàng";
            this.colMaKH.Width = 100;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLyThueXe.Properties.Resources.magnifier;
            this.btnSearch.Location = new System.Drawing.Point(852, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GUI_QuanLyHopDongForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPhanLoai);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsvHopDong);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyHopDongForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFeresh;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboPhanLoai;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lsvHopDong;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colNgayThue;
        private System.Windows.Forms.ColumnHeader colNgayTra;
        private System.Windows.Forms.ColumnHeader colHanTra;
        private System.Windows.Forms.ColumnHeader colGiaThue;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colPhiPhat;
        private System.Windows.Forms.ColumnHeader colTongTien;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colMaKH;
    }
}