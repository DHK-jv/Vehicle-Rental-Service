namespace QuanLyThueXe.GUI
{
    partial class GUI_QuanLyKhachHangForm
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
            this.lsvKhachHang = new System.Windows.Forms.ListView();
            this.colMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvKhachHang
            // 
            this.lsvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaKH,
            this.colTenKH,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colCCCD,
            this.colSoDT,
            this.colDiaChi});
            this.lsvKhachHang.FullRowSelect = true;
            this.lsvKhachHang.GridLines = true;
            this.lsvKhachHang.HideSelection = false;
            this.lsvKhachHang.Location = new System.Drawing.Point(23, 81);
            this.lsvKhachHang.Name = "lsvKhachHang";
            this.lsvKhachHang.Size = new System.Drawing.Size(900, 357);
            this.lsvKhachHang.TabIndex = 1;
            this.lsvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lsvKhachHang.View = System.Windows.Forms.View.Details;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã Khách Hàng";
            this.colMaKH.Width = 80;
            // 
            // colTenKH
            // 
            this.colTenKH.Text = "Tên Khách Hàng";
            this.colTenKH.Width = 150;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày Sinh";
            this.colNgaySinh.Width = 90;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới Tính";
            this.colGioiTinh.Width = 70;
            // 
            // colCCCD
            // 
            this.colCCCD.Text = "CCCD";
            this.colCCCD.Width = 100;
            // 
            // colSoDT
            // 
            this.colSoDT.Text = "Số Điện Thoại";
            this.colSoDT.Width = 100;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa Chỉ";
            this.colDiaChi.Width = 250;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(606, 30);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(234, 26);
            this.txtTim.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(23, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(706, 65);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(174, 64);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(473, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(174, 64);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(246, 65);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(174, 64);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Sửa Thông Tin ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(22, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 64);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Khách Hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(845, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 28);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(23, 28);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(303, 28);
            this.cbbGioiTinh.TabIndex = 0;
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(347, 28);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // GUI_QuanLyKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(970, 650);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lsvKhachHang);
            this.Controls.Add(this.cbbGioiTinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyKhachHangForm";
            this.Text = "GUI_QuanLyKhachHangForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvKhachHang;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colTenKH;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colCCCD;
        private System.Windows.Forms.ColumnHeader colSoDT;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Button btnLamMoi;
    }
}