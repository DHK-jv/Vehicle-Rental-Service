namespace QuanLyThueXe.GUI
{
    partial class GUI_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMoFormXe = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormHopDong = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormNhanVien = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormKhachHang = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormThongKe = new System.Windows.Forms.ToolStripButton();
            this.btnMoFormThanhToan = new System.Windows.Forms.ToolStripButton();
            this.btnDangXuat = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNameAccount = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoFormXe,
            this.btnMoFormHopDong,
            this.btnMoFormNhanVien,
            this.btnMoFormKhachHang,
            this.btnMoFormThongKe,
            this.btnMoFormThanhToan,
            this.btnDangXuat,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(340, 668);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnMoFormXe
            // 
            this.btnMoFormXe.AutoSize = false;
            this.btnMoFormXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoFormXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormXe.Image = global::QuanLyThueXe.Properties.Resources.electric_bike;
            this.btnMoFormXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormXe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormXe.Margin = new System.Windows.Forms.Padding(0, 150, 0, 2);
            this.btnMoFormXe.Name = "btnMoFormXe";
            this.btnMoFormXe.Size = new System.Drawing.Size(290, 50);
            this.btnMoFormXe.Text = "Quản lý Xe";
            this.btnMoFormXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormXe.Click += new System.EventHandler(this.btnMoFormXe_Click);
            // 
            // btnMoFormHopDong
            // 
            this.btnMoFormHopDong.AutoSize = false;
            this.btnMoFormHopDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoFormHopDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormHopDong.Image = global::QuanLyThueXe.Properties.Resources.contract;
            this.btnMoFormHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormHopDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormHopDong.Name = "btnMoFormHopDong";
            this.btnMoFormHopDong.Size = new System.Drawing.Size(290, 50);
            this.btnMoFormHopDong.Text = "Quản lý Hợp đồng thuê xe";
            this.btnMoFormHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormHopDong.Click += new System.EventHandler(this.btnMoFormHopDong_Click);
            // 
            // btnMoFormNhanVien
            // 
            this.btnMoFormNhanVien.AutoSize = false;
            this.btnMoFormNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoFormNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormNhanVien.Image = global::QuanLyThueXe.Properties.Resources.nhanvien;
            this.btnMoFormNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormNhanVien.Name = "btnMoFormNhanVien";
            this.btnMoFormNhanVien.Size = new System.Drawing.Size(288, 50);
            this.btnMoFormNhanVien.Text = "Quản lý Nhân viên";
            this.btnMoFormNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormNhanVien.Click += new System.EventHandler(this.btnMoFormNhanVien_Click);
            // 
            // btnMoFormKhachHang
            // 
            this.btnMoFormKhachHang.AutoSize = false;
            this.btnMoFormKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMoFormKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormKhachHang.Image = global::QuanLyThueXe.Properties.Resources.khachhang;
            this.btnMoFormKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormKhachHang.Name = "btnMoFormKhachHang";
            this.btnMoFormKhachHang.Size = new System.Drawing.Size(288, 50);
            this.btnMoFormKhachHang.Text = "Quản lý Khách hàng";
            this.btnMoFormKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormKhachHang.Click += new System.EventHandler(this.btnMoFormKhachHang_Click);
            // 
            // btnMoFormThongKe
            // 
            this.btnMoFormThongKe.AutoSize = false;
            this.btnMoFormThongKe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormThongKe.Image = global::QuanLyThueXe.Properties.Resources.thongke;
            this.btnMoFormThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormThongKe.Name = "btnMoFormThongKe";
            this.btnMoFormThongKe.Size = new System.Drawing.Size(288, 50);
            this.btnMoFormThongKe.Text = "Thống kê xe";
            this.btnMoFormThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormThongKe.ToolTipText = "ThongKetoolStripButton4";
            this.btnMoFormThongKe.Click += new System.EventHandler(this.btnMoFormThongKe_Click);
            // 
            // btnMoFormThanhToan
            // 
            this.btnMoFormThanhToan.AutoSize = false;
            this.btnMoFormThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFormThanhToan.Image = global::QuanLyThueXe.Properties.Resources.bill;
            this.btnMoFormThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormThanhToan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoFormThanhToan.Name = "btnMoFormThanhToan";
            this.btnMoFormThanhToan.Size = new System.Drawing.Size(288, 50);
            this.btnMoFormThanhToan.Text = "Hóa đơn thanh toán";
            this.btnMoFormThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoFormThanhToan.Click += new System.EventHandler(this.btnMoFormThanhToan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = false;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::QuanLyThueXe.Properties.Resources.log_out;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0, 60, 0, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(288, 50);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = false;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyThueXe.Properties.Resources.power;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(288, 50);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // lbNameAccount
            // 
            this.lbNameAccount.AutoSize = true;
            this.lbNameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAccount.Location = new System.Drawing.Point(98, 116);
            this.lbNameAccount.Name = "lbNameAccount";
            this.lbNameAccount.Size = new System.Drawing.Size(0, 20);
            this.lbNameAccount.TabIndex = 4;
            // 
            // GUI_MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1295, 668);
            this.Controls.Add(this.lbNameAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "GUI_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.GUI_MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMoFormXe;
        private System.Windows.Forms.ToolStripButton btnMoFormHopDong;
        private System.Windows.Forms.ToolStripButton btnMoFormNhanVien;
        private System.Windows.Forms.ToolStripButton btnMoFormKhachHang;
        private System.Windows.Forms.ToolStripButton btnMoFormThongKe;
        private System.Windows.Forms.ToolStripButton btnDangXuat;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ToolStripButton btnMoFormThanhToan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNameAccount;
    }
}