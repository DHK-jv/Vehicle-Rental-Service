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
    public partial class GUI_DoanhThu : Form
    {
        BLL_QuanLyThongKe bllThongKe = new BLL_QuanLyThongKe();
        public GUI_DoanhThu()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

                this.Close();
            
        }

        public void LoadChartDoanhThu()
        {
            DataTable dt = bllThongKe.GetDoanhThuTungXe();

            chartDoanhThu.Series.Clear();
            Series series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Color = Color.OrangeRed
            };

            foreach (DataRow row in dt.Rows)
            {
                string tenXe = row["TenXe"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                series.Points.AddXY(tenXe, doanhThu);
            }

            chartDoanhThu.Series.Add(series);
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(new Title("Doanh Thu Theo Xe (Có Tính Phí Phạt)", Docking.Top, new Font("Arial", 16, FontStyle.Bold), Color.Blue));
        }


        private void GUI_DoanhThu_Load(object sender, EventArgs e)
        {
            LoadChartDoanhThu();
        }
    }
}
