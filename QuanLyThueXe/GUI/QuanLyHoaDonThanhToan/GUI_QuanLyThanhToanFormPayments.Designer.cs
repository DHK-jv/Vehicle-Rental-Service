namespace QuanLyThueXe
{
    partial class GUI_QuanLyThanhToanFormPayments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.cboPhuongThucTT = new System.Windows.Forms.ComboBox();
            this.dtpNgayTT = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phương thức thanh toán";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTT.Location = new System.Drawing.Point(412, 164);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(462, 34);
            this.txtMaTT.TabIndex = 6;
            // 
            // cboPhuongThucTT
            // 
            this.cboPhuongThucTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhuongThucTT.FormattingEnabled = true;
            this.cboPhuongThucTT.Items.AddRange(new object[] {
            "Thanh toán bằng tiền mặt",
            "Thanh toán bằng ví điện tử",
            "Thanh toán qua mã QR",
            "Thanh toán quẹt thẻ ngân hàng",
            "Thanh toán chuyển khoản qua ngân hàng"});
            this.cboPhuongThucTT.Location = new System.Drawing.Point(412, 313);
            this.cboPhuongThucTT.Name = "cboPhuongThucTT";
            this.cboPhuongThucTT.Size = new System.Drawing.Size(462, 37);
            this.cboPhuongThucTT.TabIndex = 8;
            // 
            // dtpNgayTT
            // 
            this.dtpNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTT.Location = new System.Drawing.Point(412, 236);
            this.dtpNgayTT.Name = "dtpNgayTT";
            this.dtpNgayTT.Size = new System.Drawing.Size(462, 34);
            this.dtpNgayTT.TabIndex = 22;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(412, 474);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(462, 34);
            this.txtSoTien.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(265, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số tiền";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(649, 556);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(225, 42);
            this.btnPay.TabIndex = 25;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(44, 556);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 42);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cboTrangThai.Location = new System.Drawing.Point(412, 389);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(462, 37);
            this.cboTrangThai.TabIndex = 27;
            // 
            // GUI_QuanLyThanhToanFormPayments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(922, 621);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgayTT);
            this.Controls.Add(this.cboPhuongThucTT);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_QuanLyThanhToanFormPayments";
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.ComboBox cboPhuongThucTT;
        private System.Windows.Forms.DateTimePicker dtpNgayTT;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboTrangThai;
    }
}