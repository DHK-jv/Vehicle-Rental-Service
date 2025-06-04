namespace QuanLyThueXe.GUI
{
    partial class GUI_QuanLyThanhToanForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lsvThanhToan = new System.Windows.Forms.ListView();
            this.colMaTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhuongThucTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPay = new System.Windows.Forms.Button();
            this.cboPhanLoaiTT = new System.Windows.Forms.ComboBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(581, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 30);
            this.txtSearch.TabIndex = 4;
            // 
            // lsvThanhToan
            // 
            this.lsvThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaTT,
            this.colNgayTT,
            this.colSoTien,
            this.colTinhTrang,
            this.colPhuongThucTT,
            this.colMaHD});
            this.lsvThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvThanhToan.FullRowSelect = true;
            this.lsvThanhToan.GridLines = true;
            this.lsvThanhToan.HideSelection = false;
            this.lsvThanhToan.Location = new System.Drawing.Point(42, 118);
            this.lsvThanhToan.Name = "lsvThanhToan";
            this.lsvThanhToan.Size = new System.Drawing.Size(856, 388);
            this.lsvThanhToan.TabIndex = 8;
            this.lsvThanhToan.UseCompatibleStateImageBehavior = false;
            this.lsvThanhToan.View = System.Windows.Forms.View.Details;
            // 
            // colMaTT
            // 
            this.colMaTT.Text = "Mã hóa đơn";
            this.colMaTT.Width = 103;
            // 
            // colNgayTT
            // 
            this.colNgayTT.Text = "Ngày thanh toán";
            this.colNgayTT.Width = 122;
            // 
            // colSoTien
            // 
            this.colSoTien.Text = "Số tiền";
            this.colSoTien.Width = 96;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.Text = "Tình trạng";
            this.colTinhTrang.Width = 130;
            // 
            // colPhuongThucTT
            // 
            this.colPhuongThucTT.Text = "Phương thức thanh toán";
            this.colPhuongThucTT.Width = 269;
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã hợp đồng";
            this.colMaHD.Width = 182;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(661, 559);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(237, 57);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cboPhanLoaiTT
            // 
            this.cboPhanLoaiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanLoaiTT.FormattingEnabled = true;
            this.cboPhanLoaiTT.Location = new System.Drawing.Point(44, 53);
            this.cboPhanLoaiTT.Name = "cboPhanLoaiTT";
            this.cboPhanLoaiTT.Size = new System.Drawing.Size(266, 33);
            this.cboPhanLoaiTT.TabIndex = 9;
            this.cboPhanLoaiTT.SelectedIndexChanged += new System.EventHandler(this.cboPhanLoaiHD_SelectedIndexChanged);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(42, 559);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(225, 57);
            this.btnOut.TabIndex = 11;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::QuanLyThueXe.Properties.Resources.reload;
            this.btnRefresh.Location = new System.Drawing.Point(332, 51);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 33);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLyThueXe.Properties.Resources.magnifier;
            this.btnSearch.Location = new System.Drawing.Point(815, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GUI_QuanLyThanhToanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cboPhanLoaiTT);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lsvThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyThanhToanForm";
            this.Text = "GUI_QuanLyThanhToanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListView lsvThanhToan;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cboPhanLoaiTT;
        private System.Windows.Forms.ColumnHeader colMaTT;
        private System.Windows.Forms.ColumnHeader colNgayTT;
        private System.Windows.Forms.ColumnHeader colSoTien;
        private System.Windows.Forms.ColumnHeader colPhuongThucTT;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnRefresh;
    }
}