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
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private ET_DoanhThuCuaHangTheoThang et_DoanhThuCuaHang = new ET_DoanhThuCuaHangTheoThang();
        public frm_BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadDuLieuCuaHangCombobox();
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = true;
                cbo_MaCH.SelectedIndex = 0;
                LoadTatCaDulieuDatagridview(cbo_MaCH.SelectedValue.ToString());
            }
            else if(Session.VaiTro =="QuanLy")
            {
                cbo_MaCH.SelectedValue=Session.MaCuaHang;  
                LoadTatCaDulieuDatagridview(cbo_MaCH.SelectedValue.ToString());
            }

        }
        private void LoadTatCaDulieuDatagridview(string maCH= null)
        {
            dgv_Data.DataSource = bus_BaoCao.BaoCaoDoanhThuCuaHangTheoThang(maCH);
        }
        private void LoadDuLieuDaLocTheoTgianMongMuon(string maCH ,DateTime tuNgay, DateTime denNgay) 
        { 
           dgv_Data.DataSource = bus_BaoCao.BaoCaoDoanhThuCuaHangDieuChinhTheoTgianMongMuon(maCH, tuNgay, denNgay);
        }
        private void LoadDuLieuCuaHangCombobox()
        {
            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
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


        private void frm_BaoCaoDoanhThu_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left=(this.ClientSize.Width - lbl_Title.Width)/2;
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            string maCH = cbo_MaCH.SelectedValue.ToString();
            if (string.IsNullOrEmpty(maCH)) { MessageBox.Show("Mã cửa hàng hiện tại đang trống! ","Thông báo"); return; }
            if (rb_XemTatCa.Checked == true)
            {
                LoadTatCaDulieuDatagridview(maCH);
                LoadDuLieuLenChart(bus_BaoCao.BaoCaoDoanhThuCuaHangTheoThang(maCH));
            }
            else if(rb_TuChinh.Checked == true)
            {
                LoadDuLieuDaLocTheoTgianMongMuon(maCH, dtp_TuNgay.Value, dtp_DenNgay.Value);
                LoadDuLieuLenChart(bus_BaoCao.BaoCaoDoanhThuCuaHangDieuChinhTheoTgianMongMuon(maCH, dtp_TuNgay.Value, dtp_DenNgay.Value));
            }
        }

        private void rb_TuChinh_CheckedChanged(object sender, EventArgs e)
        {
            dtp_DenNgay.Enabled = true; 
            dtp_TuNgay.Enabled = true;
            
        }

        private void rb_XemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            dtp_DenNgay.Enabled=false;
            dtp_TuNgay.Enabled = false;
        }
    }
}
