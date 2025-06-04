namespace QuanLyThueXe
{
    partial class GUI_QuanLyThongKeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xe được sử dụng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xe thuê nhiều nhất";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(32, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Doanh thu theo xe";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuong.ForeColor = System.Drawing.Color.Green;
            this.txtTongSoLuong.Location = new System.Drawing.Point(140, 84);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(100, 34);
            this.txtTongSoLuong.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng xe";
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
            this.lsvXe.Location = new System.Drawing.Point(271, 84);
            this.lsvXe.Name = "lsvXe";
            this.lsvXe.Size = new System.Drawing.Size(649, 493);
            this.lsvXe.TabIndex = 6;
            this.lsvXe.UseCompatibleStateImageBehavior = false;
            this.lsvXe.View = System.Windows.Forms.View.Details;
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
            this.colMaHX.Text = "Mã hảng xe";
            this.colMaHX.Width = 120;
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(32, 519);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(208, 58);
            this.btnOut.TabIndex = 7;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // GUI_QuanLyThongKeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lsvXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongSoLuong);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_QuanLyThongKeForm";
            this.Text = "GUI_QuanLyThongKeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvXe;
        private System.Windows.Forms.ColumnHeader colMaXe;
        private System.Windows.Forms.ColumnHeader colTenXe;
        private System.Windows.Forms.ColumnHeader colBienSo;
        private System.Windows.Forms.ColumnHeader colMauSac;
        private System.Windows.Forms.ColumnHeader colTinhTrang;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colGiaThue;
        private System.Windows.Forms.ColumnHeader colNamXS;
        private System.Windows.Forms.ColumnHeader colLoaiXe;
        private System.Windows.Forms.ColumnHeader colMaHX;
        private System.Windows.Forms.Button btnOut;
    }
}