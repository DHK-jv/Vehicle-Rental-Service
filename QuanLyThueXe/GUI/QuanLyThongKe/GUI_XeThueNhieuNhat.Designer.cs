namespace QuanLyThueXe
{
    partial class GUI_XeThueNhieuNhat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOut = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartXe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbThoiGian = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartXe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.White;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Image = global::QuanLyThueXe.Properties.Resources.left;
            this.btnOut.Location = new System.Drawing.Point(862, 12);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(57, 44);
            this.btnOut.TabIndex = 27;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // chartXe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartXe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartXe.Legends.Add(legend1);
            this.chartXe.Location = new System.Drawing.Point(97, 130);
            this.chartXe.Name = "chartXe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartXe.Series.Add(series1);
            this.chartXe.Size = new System.Drawing.Size(740, 472);
            this.chartXe.TabIndex = 28;
            this.chartXe.Text = "chart1";
            this.chartXe.Click += new System.EventHandler(this.chartXe_Click);
            // 
            // cbbThoiGian
            // 
            this.cbbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThoiGian.FormattingEnabled = true;
            this.cbbThoiGian.Items.AddRange(new object[] {
            "Ngày",
            "Tuần",
            "Tháng"});
            this.cbbThoiGian.Location = new System.Drawing.Point(95, 35);
            this.cbbThoiGian.Name = "cbbThoiGian";
            this.cbbThoiGian.Size = new System.Drawing.Size(219, 33);
            this.cbbThoiGian.TabIndex = 29;
            this.cbbThoiGian.SelectedIndexChanged += new System.EventHandler(this.cbbThoiGian_SelectedIndexChanged);
            // 
            // GUI_XeThueNhieuNhat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(940, 668);
            this.Controls.Add(this.cbbThoiGian);
            this.Controls.Add(this.chartXe);
            this.Controls.Add(this.btnOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_XeThueNhieuNhat";
            this.Text = "GUI_XeThueNhieuNhat";
            ((System.ComponentModel.ISupportInitialize)(this.chartXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXe;
        private System.Windows.Forms.ComboBox cbbThoiGian;
    }
}