using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyThueXe.BLL;

namespace QuanLyThueXe
{
    public partial class GUI_XeThueNhieuNhat : Form
    {
        BLL_QuanLyThongKe bllThongKe = new BLL_QuanLyThongKe();
        public GUI_XeThueNhieuNhat()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void cbbThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cbbThoiGian.SelectedItem.ToString();
            DataTable dt = bllThongKe.getXeThueNhieu(selectedFilter);
            LoadChart(dt);
        }

        private void LoadChart(DataTable dt)
        {
            chartXe.Series.Clear(); // Xóa toàn bộ Series cũ
            chartXe.Titles.Clear(); // Xóa tiêu đề cũ

            // Thêm tiêu đề cho biểu đồ
            Title title = new Title("Top Xe Được Thuê Nhiều Nhất")
            {
                Font = new Font("Arial", 16, FontStyle.Bold), // Tăng kích thước chữ
                ForeColor = Color.Blue, // Màu chữ (có thể thay đổi)
                Alignment = ContentAlignment.TopCenter // Căn giữa tiêu đề
            };

            chartXe.Titles.Add(title);

            // Tạo Series mới nếu chưa có
            Series series = new Series("XeThue")
            {
                ChartType = SeriesChartType.Column, // Kiểu biểu đồ cột
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            // Thêm dữ liệu vào Chart
            foreach (DataRow row in dt.Rows)
            {
                string tenXe = row["TenXe"].ToString();
                int soLanThue = Convert.ToInt32(row["SoLanThue"]);
                series.Points.AddXY(tenXe, soLanThue);
            }

            chartXe.Series.Add(series); // Thêm Series vào biểu đồ
        }

        private void chartXe_Click(object sender, EventArgs e)
        {

        }
    }
}
