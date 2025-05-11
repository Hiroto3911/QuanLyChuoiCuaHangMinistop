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
using GUI.Reporting;

namespace GUI
{
    public partial class frm_NhapKho : Form
    {
        private BUS_NhapHang bus_NhapHang = new BUS_NhapHang();
        private ET_NhapHang et_NhapHang = new ET_NhapHang();
        private BUS_ChiTietNhapHang bus_CT = new BUS_ChiTietNhapHang();
        private ET_ChiTietNhapHang et_CT = new ET_ChiTietNhapHang();
        private BUS_NhaCungCap bus_NhaCungCap = new BUS_NhaCungCap();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();
        private BUS_ChiTietKho bus_CTK = new BUS_ChiTietKho();
        private BUS_LichSuKho bus_LSK = new BUS_LichSuKho();
        private static string maNhapMoiThem;
        public frm_NhapKho()
        {
            InitializeComponent();
        }

        private void frm_NhapKho_Load(object sender, EventArgs e)
        {

            LoadComboBox();
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = true;
            }
            else
            {
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
                txt_MaNV.Text = Session.MaNhanVien;
            }
            LoadDuLieuNhapHang();
            LoadChiTietTheoMaPN(dgv_Data.CurrentRow.Cells[0].Value.ToString());

        }
        // Load dữ liệu nhập hàng lên DataGridView và tạo mã phiếu nhập mới
        public void LoadDuLieuNhapHang()
        {

            dgv_Data.DataSource = bus_NhapHang.HienThiDuLieuTheoMaCH(cbo_MaCH.SelectedValue.ToString());
        }


        // Load chi tiết nhập theo mã phiếu nhập được chọn
        private void LoadChiTietTheoMaPN(string maPhieuNhap)
        {
            var dsChiTiet = bus_CT.LayChiTietTheoMaPhieu(maPhieuNhap);
            dgv_DataChiTiet.DataSource = dsChiTiet;
        }

        // Load dữ liệu cho các ComboBox
        private void LoadComboBox()
        {
            cbo_NCC.DataSource = bus_NhaCungCap.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_NCC.DisplayMember = "MaNCC";
            cbo_NCC.ValueMember = "MaNCC";

            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.DisplayMember = "TenCH";
            cbo_MaCH.ValueMember = "MaCH";

            cbo_MaSP.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.DisplayMember = "MaSanPham";
            cbo_MaSP.ValueMember = "MaSanPham";
        }

        // Tính tổng tiền khi thay đổi số lượng hoặc giá
        private void TinhTongTien()
        {
            if (int.TryParse(txt_SLNhap.Text, out int sl) &&
                decimal.TryParse(txt_GiaNhap.Text, out decimal gia))
            {
                double tong = sl * (double)gia;
                txt_TongTien.Text = tong.ToString("N2");
            }
            else
            {
                txt_TongTien.Text = "0";
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                maNhapMoiThem = TaoMaTuDong.TaoMa(bus_NhapHang.LayDanhSachMaNH(), "PN");
                et_NhapHang.MaPhieuNhap = maNhapMoiThem;
                et_NhapHang.MaNcc = cbo_NCC.Text;
                et_NhapHang.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                et_NhapHang.NgayNhap = dtp_NgayNhap.Value;
                et_NhapHang.MaNhanVien = txt_MaNV.Text;
                bus_NhapHang.Them(et_NhapHang);
                MessageBox.Show("Thêm thành công");
                LoadDuLieuNhapHang();
                LoadChiTietTheoMaPN(maNhapMoiThem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (bus_CT.LayChiTietTheoMaPhieu(txt_MaNH.Text).Count == 0)
            {
                try
                {
                    bus_NhapHang.Xoa(txt_MaNH.Text);
                    MessageBox.Show("Xóa thành công");
                    LoadDuLieuNhapHang();
                    LoadChiTietTheoMaPN(dgv_Data.CurrentRow.Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Phiếu vẫn còn dữ liệu, không thể xoá được");
            }
        }

        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            if (maNhapMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu nhập này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu nhập mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                et_CT.MaPhieuNhap = maNhapMoiThem;
                et_CT.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_CT.SoLuong = int.Parse(txt_SLNhap.Text);
                et_CT.GiaNhap = decimal.Parse(txt_GiaNhap.Text);
                et_CT.GhiChu = rtf_GhiChu.Text;
                bus_CT.Them(et_CT);
                MessageBox.Show("Thêm thành công");
                btn_LamMoiChiTiet_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại Lỗi thêm: " + ex.Message);
            }
        }

        private void btn_XoaChiTiet_Click(object sender, EventArgs e)
        {
            if (maNhapMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu nhập này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu nhập mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                bus_CT.Xoa(maNhapMoiThem, cbo_MaSP.Text);
                MessageBox.Show("Xoá thành công");
                btn_LamMoiChiTiet_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xoá thất bại Lỗi xoá: " + ex.Message);
            }
        }

        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            if (maNhapMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu nhập này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu nhập mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                et_CT.MaPhieuNhap = maNhapMoiThem;
                et_CT.MaSanPham = cbo_MaSP.Text;
                et_CT.SoLuong = int.Parse(txt_SLNhap.Text);
                et_CT.GiaNhap = decimal.Parse(txt_GiaNhap.Text);
                //et_CT.TongTien = decimal.Parse(txt_TongTien.Text);
                et_CT.GhiChu = rtf_GhiChu.Text;
                bus_CT.Sua(et_CT);
                MessageBox.Show("Sửa thành công");
                btn_LamMoiChiTiet_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại Lỗi sửa: " + ex.Message);
            }
        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
            txt_MaNH.Clear();
            cbo_NCC.SelectedIndex = 0;
            txt_MaNV.Text = Session.MaNhanVien;
            dtp_NgayNhap.Value = DateTime.Now;
            cbo_MaSP.SelectedIndex = 0;
            txt_SLNhap.Clear();
            txt_GiaNhap.Clear();
            txt_TongTien.Clear();
            rtf_GhiChu.Clear();
            LoadDuLieuNhapHang();
            LoadChiTietTheoMaPN(dgv_Data.CurrentRow.Cells[0].Value.ToString());
        }

        private void frm_NhapKho_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 2;
            gbo_NhapThongTin.Top = 90;
            gbo_ThongTin.Left = (this.ClientSize.Width - gbo_ThongTin.Width) / 2;
            gbo_ThongTin.Top = gbo_NhapThongTin.Bottom + 20;
        }


        private void dgv_DataChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaNH.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbo_MaSP.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_SLNhap.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_GiaNhap.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_TongTien.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtf_GhiChu.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[5].Value?.ToString();
            }
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var ct in bus_CT.LayChiTietTheoMaPhieu(maNhapMoiThem))
                {
                    bus_CTK.CapNhapChiTietKhoKhiNhapHang(cbo_MaCH.Text, ct, et_NhapHang.NgayNhap);
                }
                maNhapMoiThem = null;
                MessageBox.Show("Cập nhập kho thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("việc xử lý đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void txt_GiaNhap_Leave(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(txt_SLNhap.Text);
            decimal gia = Convert.ToDecimal(txt_GiaNhap.Text);
            txt_TongTien.Text = (sl * gia).ToString();
        }

        private void btn_InPhieuNhap_Click(object sender, EventArgs e)
        {
            string maNH = txt_MaNH.Text;
            frm_RP_PhieuNhapHang frm = new frm_RP_PhieuNhapHang(maNH);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            int dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) return;

            txt_MaNH.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            cbo_NCC.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            cbo_MaCH.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            dtp_NgayNhap.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            txt_MaNV.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
            string maPN = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            LoadChiTietTheoMaPN(maPN);

        }
    }
}
