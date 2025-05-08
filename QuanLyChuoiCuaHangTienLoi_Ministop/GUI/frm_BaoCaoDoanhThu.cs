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
    public partial class frm_BaoCaoDoanhThu : Form
    {
        private BUS_BaoCao bus_BaoCao = new BUS_BaoCao();
        private ET_DoanhThuCuaHangTheoThang et_DoanhThuCuaHang = new ET_DoanhThuCuaHangTheoThang();
        public frm_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            if(Session.MaCuaHang == null)
            {
                LoadDulieuDatagridview();
            }
            else
            {
                LoadDulieuDatagridview(Session.MaCuaHang);
            }
     
        }
        private void LoadDulieuDatagridview(string maCH = null)
        {
            dgv_Data.DataSource = bus_BaoCao.BaoCaoDoanhThuCuaHangTheoThang(maCH);
        }
        private void LoadDuLieuLenChart(List<ET_DoanhThuCuaHangTheoThang> ds )
        {
            if (ds == null || ds.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu doanh thu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            chart_DoanhThu.Series.Clear();
            Series series = new Series("DoanhThu");
            series.ChartType = SeriesChartType.Column;
            for (int i = 0; i < ds.Count; i++)
            {
                string label = $"{ds[i].Thang}/{ds[i].Nam}";
                decimal value = ds[i].DoanhThu;

                series.Points.AddXY(label, value);
            }
            chart_DoanhThu.Series.Add(series);
            chart_DoanhThu.ChartAreas[0].AxisX.Title = "Tháng/Năm";
            chart_DoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chart_DoanhThu.Series[0].IsValueShownAsLabel = true;
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            int dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) return;
            var maCH = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            LoadDuLieuLenChart(bus_BaoCao.BaoCaoDoanhThuCuaHangTheoThang(maCH));

        }

        private void frm_BaoCaoDoanhThu_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left=(this.ClientSize.Width - lbl_Title.Width)/2;
        }
    }
}
