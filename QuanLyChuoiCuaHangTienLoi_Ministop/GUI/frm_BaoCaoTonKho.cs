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

namespace GUI
{
    public partial class frm_BaoCaoTonKho : Form
    {
        private BUS_BaoCao bus_BaoCao = new BUS_BaoCao();
        private BUS_CuaHang bus_CH = new BUS_CuaHang();
    
        public frm_BaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoTonKho_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 2;
            gbo_NhapThongTin.Top = 90; 
            gbo_ThongTin.Left = (this.ClientSize.Width - gbo_ThongTin.Width) / 2;
            gbo_ThongTin.Top = gbo_NhapThongTin.Bottom + 20;

        }

        private void frm_BaoCaoTonKho_Load(object sender, EventArgs e)
        {
            LoadDuLieuCuaHangCombobox();
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = true;
            }
            else
            {
                cbo_MaCH.Enabled = false;
                cbo_MaCH.SelectedValue = Session.MaCuaHang;

            }
            cbo_Thang.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            rb_TuDong.Checked = true; 
            rb_TuChinh.Checked = false;          
         
           
           
        }
        private void LoadDuLieuCuaHangCombobox()
        {
            cbo_MaCH.DataSource = bus_CH.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
        }
        private void LoadDuLieuTonKhoDatagridview(int nam, int thang , string maCH)
        {
            var ds = bus_BaoCao.BaoCaoTonKhoTrongCuaHang(nam, thang, maCH);
            if( ds == null) { MessageBox.Show($"Có vẻ như không có dữ liệu trong khoảng tgian tháng {cbo_Thang.Text} năm {txt_Nam.Text} ", "Thông báo"); return; }
            dgv_Data.DataSource = ds;
        }
        
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieuTonKhoDatagridview(Convert.ToInt32(txt_Nam.Text), Convert.ToInt32(cbo_Thang.SelectedItem.ToString()), cbo_MaCH.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex);
            }
        }

        private void rb_TuChinh_CheckedChanged(object sender, EventArgs e)
        {
            cbo_Thang.Enabled = true;
            txt_Nam.Enabled = true;
        }

        private void rb_TuDong_CheckedChanged(object sender, EventArgs e)
        {
          
            cbo_Thang.Enabled = false;
            txt_Nam.Enabled = false;
            cbo_Thang.SelectedItem = DateTime.Now.Month;
            txt_Nam.Text = DateTime.Now.Year.ToString();
        }

        private void cbo_MaCH_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_Title.Text = "Báo cáo tồn kho của "+ cbo_MaCH.SelectedValue.ToString();
        }
    }
}
