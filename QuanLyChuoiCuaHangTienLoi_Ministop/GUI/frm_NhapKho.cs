using BUS;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frm_NhapKho : Form
    {
        public frm_NhapKho()
        {
            InitializeComponent();
        }

        private BUS_NhapHang bus_NhapHang = new BUS_NhapHang();
        private ET_NhapHang et_NhapHang = new ET_NhapHang();
        private BUS_ChiTietNhapHang bus_CT = new BUS_ChiTietNhapHang();
        private ET_ChiTietNhapHang et_CT = new ET_ChiTietNhapHang();
        private BUS_NhaCungCap bus_NhaCungCap = new BUS_NhaCungCap();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();

        // Sự kiện xảy ra khi form được load
        private void frm_NhapKho_Load(object sender, EventArgs e)
        {
            cbo_MaCH.Text = Session.MaCuaHang;
            txt_MaNV.Text = Session.MaNhanVien;
            LoadDuLieuNhapHang();
            LoadComboBox();
        }

        // Load dữ liệu nhập hàng lên DataGridView và tạo mã phiếu nhập mới
        public void LoadDuLieuNhapHang()
        {
            txt_MaNH.Text = TaoMaTuDong.TaoMa(bus_NhapHang.HienThiTatCa().Select(x => x.MaPhieuNhap).ToList(), "PN");
            dgv_Data.DataSource = bus_NhapHang.HienThiTatCa();
        }

        // Load toàn bộ dữ liệu chi tiết nhập hàng
        private void LoadDuLieuChiTiet()
        {
            dgv_DataChiTiet.DataSource = bus_CT.HienThiTatCa();
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

        // Xử lý sự kiện nút xoá phiếu nhập
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (bus_CT.LayChiTietTheoMaPhieu(txt_MaNH.Text).Count == 0)
            {
                try
                {
                    if (bus_NhapHang.Xoa(txt_MaNH.Text))
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("Xóa thất bại");

                    LoadDuLieuNhapHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Phiếu vẫn còn dữ liệu, không thể xoá được");
            }
        }

        // Xử lý sự kiện thêm phiếu nhập
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_NhapHang.MaPhieuNhap = txt_MaNH.Text;
                et_NhapHang.MaNcc = cbo_NCC.Text;
                et_NhapHang.MaCuaHang = cbo_MaCH.Text;
                et_NhapHang.NgayNhap = dtp_NgayNhap.Value;
                et_NhapHang.MaNhanVien = txt_MaNV.Text;

                if (bus_NhapHang.Them(et_NhapHang))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");

                LoadDuLieuNhapHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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

        // In phiếu nhập (chưa cài đặt)
        private void btn_InPhieuNhap_Click(object sender, EventArgs e)
        {
            //lam crytal report
            string maNH = txt_MaNH.Text;
            frm_RP_PhieuNhap frm = new frm_RP_PhieuNhap(maNH);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        // Thêm chi tiết nhập hàng
        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                et_CT.MaPhieuNhap = txt_MaNH.Text;
                et_CT.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_CT.SoLuong = int.Parse(txt_SLNhap.Text);
                et_CT.GiaNhap = decimal.Parse(txt_GiaNhap.Text);
                et_CT.TongTien = decimal.Parse(txt_TongTien.Text);
                et_CT.GhiChu = rtf_GhiChu.Text;

                if (bus_CT.Them(et_CT))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");

                LoadChiTietTheoMaPN(txt_MaNH.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // Xoá chi tiết nhập hàng
        private void btn_XoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_CT.Xoa(txt_MaNH.Text, cbo_MaSP.Text))
                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Xoá thất bại");

                LoadChiTietTheoMaPN(txt_MaNH.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
            }
        }

        // Sửa chi tiết nhập hàng
        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                et_CT.MaPhieuNhap = txt_MaNH.Text;
                et_CT.MaSanPham = cbo_MaSP.Text;
                et_CT.SoLuong = int.Parse(txt_SLNhap.Text);
                et_CT.GiaNhap = decimal.Parse(txt_GiaNhap.Text);
                et_CT.TongTien = decimal.Parse(txt_TongTien.Text);
                et_CT.GhiChu = rtf_GhiChu.Text;

                if (bus_CT.Sua(et_CT))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");

                LoadChiTietTheoMaPN(txt_MaNH.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // Làm mới toàn bộ thông tin nhập và chi tiết nhập
        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
            txt_MaNH.Clear();
            cbo_NCC.SelectedIndex = 0;
            cbo_MaCH.SelectedIndex = 0;
            txt_MaNV.Clear();
            dtp_NgayNhap.Value = DateTime.Now;

            txt_MaNH.Clear();
            cbo_MaSP.SelectedIndex = 0;
            txt_SLNhap.Clear();
            txt_GiaNhap.Clear();
            txt_TongTien.Clear();
            rtf_GhiChu.Clear();
            txt_MaNH.Focus();

            dgv_DataChiTiet.DataSource = null;
            LoadDuLieuNhapHang();
        }

        // Tự động tính tổng tiền khi thay đổi số lượng
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // Tự động tính tổng tiền khi thay đổi giá nhập
        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // Sự kiện khi chọn một dòng chi tiết để hiển thị lên form
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

        // Sự kiện khi chọn một dòng phiếu nhập để hiển thị chi tiết tương ứng
        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txt_MaNH.Text = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbo_NCC.Text = dgv_Data.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbo_MaCH.Text = dgv_Data.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtp_NgayNhap.Text = dgv_Data.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_MaNV.Text = dgv_Data.Rows[e.RowIndex].Cells[4].Value.ToString(); 
                

                string maPN = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadChiTietTheoMaPN(maPN);
            }
        }
        //Ham thay doi gia 
        private void cbo_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            ET_SanPham sp = bus_SanPham.TimSanPhamBangMa(cbo_MaSP.Text).ToList().FirstOrDefault();
            txt_GiaNhap.Text = sp.GiaMacDinh.ToString();
        }
    }
}

