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
    public partial class frm_ChiTietKho : Form
    {
        private BUS_ChiTietKho bus_ChiTietKho = new BUS_ChiTietKho();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();
        private BUS_LichSuKho bus_LichSuKho = new BUS_LichSuKho();
        private ET_ChiTietKho eT_ChiTietKho = new ET_ChiTietKho();
        public frm_ChiTietKho()
        {
            InitializeComponent();
        }

        private void frm_ChiTietKho_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = false;
            }
            else
            {
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
            }
            LoadDuLieuChiTietKho();
            LoadDuLieuLichSuKhoTheoMa(dgv_Data.CurrentRow.Cells[0].Value.ToString());
            
        }
        private void LoadComboBox()
        {
            string[] listLoai = { "Xuat", "Nhap", "Kiem" };

            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.DisplayMember = "TenCH";
            cbo_MaCH.ValueMember = "MaCH";

            cbo_MaSP.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.DisplayMember = "MaSanPham";
            cbo_MaSP.ValueMember = "MaSanPham";
        }

        public void LoadDuLieuChiTietKho()
        {
           
            dgv_Data.DataSource = bus_ChiTietKho.HienThiDuLieuSapXepGiamDanTheoMaCH(cbo_MaCH.SelectedValue.ToString());
        }

        public void LoadDuLieuLichSuKhoTheoMa(string maCTK)
        {
            var dsLS = bus_LichSuKho.LayLichSuKhoTheoMaCTK(maCTK);
            dgv_DataChiTiet.DataSource = dsLS;
        }

        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                cbo_MaCH.Text = dgv_Data.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_MaCTK.Text = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbo_MaSP.Text = dgv_Data.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_SLTon.Text = dgv_Data.Rows[e.RowIndex].Cells[3].Value?.ToString();
                txt_GiaBan.Text = dgv_Data.Rows[e.RowIndex].Cells[4].Value.ToString();
                string maPN = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadDuLieuLichSuKhoTheoMa(txt_MaCTK.Text);
            }
        }

        private void dgv_DataChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaCTLSK.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_MaChiTietKho.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_NgayThayDoi.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_SLThucTe.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbo_LoaiThayDoi.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_MaThamChieu.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[5].Value?.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                eT_ChiTietKho.MaChiTietKho = txt_MaCTK.Text;
                eT_ChiTietKho.MaSanPham = cbo_MaSP.Text;
                eT_ChiTietKho.MaCuaHang = cbo_MaCH.Text;
                eT_ChiTietKho.GiaBan = decimal.Parse(txt_GiaBan.Text);
                eT_ChiTietKho.SoluongTon = int.Parse(txt_SLTon.Text);
                if (bus_ChiTietKho.Them(eT_ChiTietKho))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");

                LoadDuLieuChiTietKho();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
            LoadDuLieuChiTietKho();
            LoadDuLieuLichSuKhoTheoMa(dgv_Data.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
