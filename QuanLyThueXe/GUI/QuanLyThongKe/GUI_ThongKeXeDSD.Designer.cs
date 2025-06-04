namespace QuanLyThueXe
{
    partial class GUI_ThongKeXeDSD
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
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lsvXe.Location = new System.Drawing.Point(42, 96);
            this.lsvXe.Name = "lsvXe";
            this.lsvXe.Size = new System.Drawing.Size(855, 493);
            this.lsvXe.TabIndex = 7;
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
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(42, 40);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(227, 33);
            this.cbbTinhTrang.TabIndex = 9;
            this.cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbbTinhTrang_SelectedIndexChanged);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.White;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Image = global::QuanLyThueXe.Properties.Resources.left;
            this.btnOut.Location = new System.Drawing.Point(871, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(57, 44);
            this.btnOut.TabIndex = 26;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // GUI_ThongKeXeDSD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.lsvXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_ThongKeXeDSD";
            this.Text = "GUI_ThongKeXeDSD";
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Button btnOut;
    }
}