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
    public partial class frm_QuanLyCuaHang : Form
    {
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private ET_CuaHang et_CuaHang = new ET_CuaHang();
        public frm_QuanLyCuaHang()
        {
            InitializeComponent();
        }

        private void frm_QuanLyCuaHang_Load(object sender, EventArgs e)
        {
            LoadDuLieuCH();
        }
        private void LoadDuLieuCH()
        {
            dgv_Data.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_CuaHang.TenCH = txt_TenCH.Text;
                et_CuaHang.SDT = txt_DTH.Text;
                et_CuaHang.DChi = rtf_DiaChi.Text;
                et_CuaHang.MaCH = TaoMaTuDong.TaoMa(bus_CuaHang.LayDanhSachMaCH(), "CH");
                bus_CuaHang.Them(et_CuaHang);
                MessageBox.Show(" Thêm Thành Công");
                txt_MaNguoiQL.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Thêm Thất Bại" + ex);
            }
            LoadDuLieuCH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                bus_CuaHang.Xoa(txt_MaCH.Text);
                MessageBox.Show(" Xoá Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xoá Thất Bại" + ex);
            }
            LoadDuLieuCH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                et_CuaHang.TenCH = txt_TenCH.Text;
                et_CuaHang.SDT = txt_DTH.Text;
                et_CuaHang.DChi = rtf_DiaChi.Text;
                et_CuaHang.MaCH = txt_MaCH.Text;
                bus_CuaHang.Sua(et_CuaHang);
                MessageBox.Show(" Sửa Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Sửa Thất Bại" + ex);
            }
            LoadDuLieuCH();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaCH.Clear();
            txt_TenCH.Clear();
            txt_DTH.Clear();
            rtf_DiaChi.Clear();
            txt_MaNguoiQL.Clear();
            txt_TenCH.Focus();
            txt_MaNguoiQL.Enabled = false;
            LoadDuLieuCH();
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            int dong = dgv_Data.CurrentCell.RowIndex;
            txt_MaCH.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            txt_TenCH.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            txt_DTH.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            rtf_DiaChi.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            var cellValue = dgv_Data.Rows[dong].Cells[4].Value;
            txt_MaNguoiQL.Text = cellValue != null ? cellValue.ToString() : "null";
        }

        private void frm_QuanLyCuaHang_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width)/2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 4;
            gbo_Data.Left = gbo_NhapThongTin.Right + 20;
            gbo_NhapThongTin.Top = 90;
            gbo_Data.Top = 90;
        }

        private void pnl_Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
