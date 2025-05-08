using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QuanLyLichSuThayDoiGiaSanPham : Form
    {
        private BUS_LichSuThayDoiGia bus_LSG = new BUS_LichSuThayDoiGia();
        private BUS_CuaHang bus_CH = new BUS_CuaHang();
        private BUS_SanPham bus_SP = new BUS_SanPham();
        private ET_LichSuThayDoiGia et_LSG = new ET_LichSuThayDoiGia();
        private static string MaLichSuGia;
           
        public frm_QuanLyLichSuThayDoiGiaSanPham()
        {
            InitializeComponent();
        }

        private void frm_QuanLyLichSuThayDoiGiaSanPham_Load(object sender, EventArgs e)
        {
            txt_NguoiThayDoi.Text = Session.MaNhanVien;
          
            LoadDuLieuCuaHangCombobox();
            LoadDuLieuSanPhamCombobox();
            if (Session.MaNhanVien.StartsWith("QL"))
            {
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
            }
            else if(Session.MaNhanVien.StartsWith("AD"))
            {
                cbo_MaCH.Enabled = true;
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                MaLichSuGia = TaoMaTuDong.TaoMa(bus_LSG.LayDanhSachMaLS(), "LSG");
                et_LSG.MaLichSu = MaLichSuGia;  
                et_LSG.MaCuaHang = Session.MaCuaHang;
                et_LSG.NguoiThayDoi = Session.MaNhanVien;
                et_LSG.MaSanPham =cbo_MaSP.SelectedValue.ToString();
                et_LSG.GiaCu = Convert.ToDecimal(txt_GiaCu.Text);
                et_LSG.GiaMoi = Convert.ToDecimal(txt_GiaMoi.Text);
                et_LSG.NgayThayDoi = dtp_TgianCapNhap.Value;
                et_LSG.LyDo = rtf_LyDo.Text;
                bus_LSG.Them(et_LSG);
                btn_LamMoi_Click(sender, e);
                MessageBox.Show("Thêm Thành Công");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
            
        }


        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaLSG.Clear();
            txt_GiaCu.Clear();
            txt_GiaMoi.Clear();
            txt_NguoiThayDoi.Text= Session.MaNhanVien;
            LoadDuLieuCuaHangCombobox();
            cbo_MaCH.SelectedValue= Session.MaCuaHang;
            LoadDuLieuSanPhamCombobox();
            txt_GiaMoi.Focus();
            rtf_LyDo.Clear();
            dtp_TgianCapNhap.Text = DateTime.Now.ToShortDateString();


        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            try
            {
                var dong = dgv_Data.CurrentCell.RowIndex;
                if (dong == null || dong > dgv_Data.Rows.Count - 1) return;
                txt_MaLSG.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                txt_GiaCu.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                txt_GiaMoi.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                txt_NguoiThayDoi.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                cbo_MaCH.SelectedValue = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                cbo_MaSP.SelectedValue = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                dtp_TgianCapNhap.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                rtf_LyDo.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi khi bạn click vào data " + ex);

            }



        }

        private void cbo_MaCH_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbo_MaSP_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadDuLieuCuaHangCombobox()
        {
            cbo_MaCH.DataSource = bus_CH.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
        }
        private void LoadDuLieuSanPhamCombobox()
        {
            cbo_MaSP.DataSource = bus_SP.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.ValueMember = "MaSanPham";
            cbo_MaSP.DisplayMember = "TenSanPham";
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (MaLichSuGia == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Việc thay đổi giá hiện tại đã hoàn tất không thể xoá sửa được nữa " +
               "\n !Bạn chỉ có thể xoá sửa trước khi nhấn nút hoàn tất việc thay đổi!", "Thông báo", MessageBoxButtons.OKCancel); 
                return;
            }
            try
            {
                et_LSG.MaLichSu = MaLichSuGia;
                et_LSG.MaCuaHang = cbo_MaCH.Text;
                et_LSG.NguoiThayDoi = txt_NguoiThayDoi.Text;
                et_LSG.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_LSG.GiaCu = Convert.ToDecimal(txt_GiaCu.Text);
                et_LSG.GiaMoi = Convert.ToDecimal(txt_GiaMoi.Text);
                et_LSG.NgayThayDoi = dtp_TgianCapNhap.Value;
                et_LSG.LyDo = rtf_LyDo.Text;
                bus_LSG.Sua(et_LSG);
                btn_LamMoi_Click(sender, e);
                MessageBox.Show("Sửa Thành Công");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MaLichSuGia == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Việc thay đổi giá hiện tại đã hoàn tất không thể xoá sửa được nữa " +
               "\n !Bạn chỉ có thể xoá sửa trước khi nhấn nút hoàn tất việc thay đổi!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {MaLichSuGia} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_LSG.Xoa(cbo_MaCH.Text,MaLichSuGia);
                MessageBox.Show(" Xoá Thành Công");
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xoá Thất Bại" + ex);
            }
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            var chapNhan = MessageBox.Show($"Sau khi nhấn nút ok thì bạn sẽ không thể sửa hoặc xoá dữ liệu thay đổi này nữa", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhan) return;
            MaLichSuGia = null;
        }
    }
}
