using BUS;
using ET;
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

namespace GUI
{
    public partial class frm_BaoCaoTongDoanhThu : Form
    {
        private BUS_BaoCao bus_BaoCao = new BUS_BaoCao();
        public frm_BaoCaoTongDoanhThu()
        {
            InitializeComponent();
        }
        private void LoadDulieuDatagridview(string maCH = null)
        {
            var ds = bus_BaoCao.TongDoanhThuTheoThang();
            dgv_Data.DataSource = ds; 
            LoadDuLieuLenChart(ds);
           
        }

        private void frm_BaoCaoTongDoanhThu_Load(object sender, EventArgs e)
        {
            LoadDulieuDatagridview();
           

        }
        private void LoadDuLieuLenChart(List<ET_TongDoanhThu> ds)
        {
            if (ds == null || ds.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu doanh thu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            chart_TongDoanhThu.Series.Clear();
            Series series = new Series("TongDoanhThu");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ds.Count; i++)
            {
                string label = $"{ds[i].Thang}/{ds[i].Nam}";
                decimal value = ds[i].TongDoanhThu;

                series.Points.AddXY(label, value);
            }
            chart_TongDoanhThu.Series.Add(series);
            chart_TongDoanhThu.ChartAreas[0].AxisX.Title = "Tháng/Năm";
            chart_TongDoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chart_TongDoanhThu.Series[0].IsValueShownAsLabel = true;
        }
    }
}
