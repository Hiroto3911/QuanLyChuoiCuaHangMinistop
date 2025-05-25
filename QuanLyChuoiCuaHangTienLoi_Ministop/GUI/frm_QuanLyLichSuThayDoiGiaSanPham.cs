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
        private BUS_ChiTietKho bus_CTK = new BUS_ChiTietKho();
        private ET_LichSuThayDoiGia et_LSG = new ET_LichSuThayDoiGia();
        private static string maLichSuGia;
           
        public frm_QuanLyLichSuThayDoiGiaSanPham()
        {
            InitializeComponent();
        }

        private void frm_QuanLyLichSuThayDoiGiaSanPham_Load(object sender, EventArgs e)
        {
            txt_NguoiThayDoi.Text = Session.MaNhanVien;
          
            LoadDuLieuCuaHangCombobox();
            LoadDuLieuSanPhamCombobox();
            if (Session.VaiTro =="QuanLy")
            {
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
               
            }
            else 
            {
                cbo_MaCH.Enabled = true;

            }
            LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                maLichSuGia = TaoMaTuDong.TaoMa(bus_LSG.LayDanhSachMaLS(), "LSG");
                et_LSG.MaLichSu = maLichSuGia;  
                et_LSG.MaCuaHang = Session.MaCuaHang;
                et_LSG.NguoiThayDoi = Session.MaNhanVien;
                et_LSG.MaSanPham =cbo_MaSP.SelectedValue.ToString();
                et_LSG.GiaCu = Convert.ToDecimal(txt_GiaCu.Text);
                et_LSG.GiaMoi = Convert.ToDecimal(txt_GiaMoi.Text);
                et_LSG.NgayThayDoi = dtp_TgianCapNhap.Value;
                et_LSG.LyDo = rtf_LyDo.Text;
                bus_LSG.Them(et_LSG);
                LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
                LamMoiCacTextBox();
                MessageBox.Show("Thêm Thành Công");
                btn_Them.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_HoanTat.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
            
        }


        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
            LoadDuLieuCuaHangCombobox();
            LoadDuLieuSanPhamCombobox();
            txt_NguoiThayDoi.Text= Session.MaNhanVien;
            cbo_MaCH.SelectedValue= Session.MaCuaHang;
            cbo_MaSP.SelectedIndex= 0;
            txt_GiaMoi.Focus();
            LamMoiCacTextBox();
           
           
           

        }
        private void LamMoiCacTextBox()
        {
            txt_MaLSG.Clear();
            txt_GiaMoi.Clear();
            rtf_LyDo.Clear();
            dtp_TgianCapNhap.Text = DateTime.Now.ToShortDateString();
        }
        

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            if(dgv_Data.Rows.Count == 0) return;
            try
            {
                var dong = dgv_Data.CurrentCell.RowIndex;
                if (dong == null || dong > dgv_Data.Rows.Count - 1) return;
                txt_MaLSG.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                cbo_MaSP.SelectedValue = dgv_Data.Rows[dong].Cells[1].Value.ToString();
                cbo_MaCH.SelectedValue = dgv_Data.Rows[dong].Cells[2].Value.ToString();
                txt_GiaCu.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
                txt_GiaMoi.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
                txt_NguoiThayDoi.Text = dgv_Data.Rows[dong].Cells[5].Value.ToString();
                rtf_LyDo.Text = dgv_Data.Rows[dong].Cells[6].Value.ToString();
                dtp_TgianCapNhap.Text = dgv_Data.Rows[dong].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi khi bạn click vào data " + ex);

            }



        }

        private void cbo_MaCH_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Session.VaiTro == "QuanLy") return;
            if(cbo_MaCH.SelectedValue ==  null) return;
            if (cbo_MaSP.SelectedValue == null) return;
            LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
        }

        private void cbo_MaSP_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_GiaCu.Text = bus_CTK.LayGiaBanCuaSanPhamCuaMotCH(cbo_MaCH.SelectedValue.ToString(),cbo_MaSP.SelectedValue.ToString()).ToString();
            LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
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
        private void LoadDuLieuLichSuGiaDataGridView(string maCH, string maSP)
        {
            dgv_Data.DataSource = bus_LSG.HienThiDuLieuSapXepGiamDanTheoMaCHVaMaSP(maCH , maSP);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (maLichSuGia == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Việc thay đổi giá hiện tại đã hoàn tất không thể xoá sửa được nữa " +
               "\n !Bạn chỉ có thể xoá sửa trước khi nhấn nút hoàn tất việc thay đổi!", "Thông báo", MessageBoxButtons.OKCancel); 
                return;
            }
            try
            {
                et_LSG.MaLichSu = maLichSuGia;
                et_LSG.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                et_LSG.NguoiThayDoi = txt_NguoiThayDoi.Text;
                et_LSG.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_LSG.GiaCu = Convert.ToDecimal(txt_GiaCu.Text);
                et_LSG.GiaMoi = Convert.ToDecimal(txt_GiaMoi.Text);
                et_LSG.NgayThayDoi = dtp_TgianCapNhap.Value;
                et_LSG.LyDo = rtf_LyDo.Text;
                bus_LSG.Sua(et_LSG);
                LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
                LamMoiCacTextBox();
                MessageBox.Show("Sửa Thành Công");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (maLichSuGia == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Việc thay đổi giá hiện tại đã hoàn tất không thể xoá sửa được nữa " +
               "\n !Bạn chỉ có thể xoá sửa trước khi nhấn nút hoàn tất việc thay đổi!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maLichSuGia} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_LSG.Xoa(cbo_MaCH.SelectedValue.ToString() ,maLichSuGia);
                MessageBox.Show(" Xoá Thành Công");
                maLichSuGia = null;
                LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
                LamMoiCacTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xoá Thất Bại" + ex);
            }
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = true;
            if (maLichSuGia == null) { MessageBox.Show($"Hiện không có sự thay đổi nào cả", "Thông báo", MessageBoxButtons.OKCancel); return; }
            var chapNhan = MessageBox.Show($"Sau khi nhấn nút ok thì bạn sẽ không thể sửa hoặc xoá dữ liệu thay đổi này nữa", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhan) return; try
            {
               
                decimal tongThayDoi = bus_LSG.TinhTongThayDoiGiaTrongMotThang(et_LSG);
                decimal tiLeTangHienTai = (et_LSG.GiaMoi - et_LSG.GiaCu) / et_LSG.GiaCu * 100;
                if (tongThayDoi + tiLeTangHienTai > 20)
                {
                    MessageBox.Show($"Tổng mức thay đổi giá trong 1 tháng vượt quá 20%. Thay đổi không được phép.", "Thông báo", MessageBoxButtons.OKCancel);
                    bus_LSG.Xoa(cbo_MaCH.SelectedValue.ToString(), maLichSuGia);
                    LoadDuLieuLichSuGiaDataGridView(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString());
                    maLichSuGia = null;
                    return;

                }
                else
                {
                    MessageBox.Show($"Thay đổi giá thành công", "Thông báo", MessageBoxButtons.OKCancel);
                    bus_CTK.CapNhapGiaCuaSanPhamTaiMotCuaHang(et_LSG);
                    cbo_MaSP_SelectedValueChanged(sender, e);
                    maLichSuGia = null;
                }
            }
            catch (Exception ex) { MessageBox.Show($"Đã xảy ra lỗi "+ ex, "Thông báo", MessageBoxButtons.OKCancel); }

        }

        private void frm_QuanLyLichSuThayDoiGiaSanPham_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 2;
            gbo_NhapThongTin.Top = 90;
            gbo_ThongTin.Left = (this.ClientSize.Width - gbo_ThongTin.Width) / 2;
            gbo_ThongTin.Top = gbo_NhapThongTin.Bottom + 20;
        }
    }
}
