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
    public partial class frm_BaoCaoSanPhamHayThatThoat : Form
    {
        private BUS_BaoCao bus_BaoCao = new BUS_BaoCao();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private ET_SanPhamHayMat et_SPHM= new ET_SanPhamHayMat();
        public frm_BaoCaoSanPhamHayThatThoat()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoSanPhamHayThatThoat_Load(object sender, EventArgs e)
        {
            LoadDuLieuCuaHangCombobox();
            cbo_SoLanThatThoat.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = true;
                cbo_MaCH.SelectedIndex = 0;              
            }
            else if (Session.VaiTro == "QuanLy")
            {
  
                cbo_MaCH.SelectedValue = Session.MaCuaHang;             
            }
        }
        private void LoadDuLieuDaLocTheoTgianMongMuon(string maCH, DateTime? tuNgay, DateTime? denNgay,int nguongLan)
        {

            dgv_Data.DataSource = bus_BaoCao.LaySanPhamHayThatThoatCuaCuaHangTheoTgianTuyChinh(maCH, tuNgay, denNgay, nguongLan);
        }
        private void LoadDuLieuCuaHangCombobox()
        {
            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
        }
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            int nguongLan = Convert.ToInt32(cbo_SoLanThatThoat.SelectedItem.ToString());
            var maCH = cbo_MaCH.SelectedValue.ToString();
            LoadDuLieuDaLocTheoTgianMongMuon(maCH, dtp_TuNgay.Value, dtp_DenNgay.Value, nguongLan);

           
           
        }

        private void frm_BaoCaoSanPhamHayThatThoat_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
        }


        private void rb_TuChinh_CheckedChanged(object sender, EventArgs e)
        {
            dtp_DenNgay.Enabled = true;
            dtp_TuNgay.Enabled = true;
        }

      
    }
}
