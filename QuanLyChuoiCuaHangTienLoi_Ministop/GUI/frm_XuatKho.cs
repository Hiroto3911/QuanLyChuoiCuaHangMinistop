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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frm_XuatKho : Form
    {
        // Khởi tạo các lớp xử lý nghiệp vụ và thực thể
        private BUS_XuatHang bus_XuatHang = new BUS_XuatHang();
        private ET_XuatHang et_XuatHang = new ET_XuatHang();
        private BUS_ChiTietXuatHang bus_ChiTietXuat = new BUS_ChiTietXuatHang();
        private ET_ChiTietXuatHang et_ChiTietXuat = new ET_ChiTietXuatHang();
        private BUS_NhaCungCap bus_NhaCungCap = new BUS_NhaCungCap();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();
        private BUS_ChiTietKho bus_CTK = new BUS_ChiTietKho();
        private BUS_LichSuKho bus_LSK = new BUS_LichSuKho();
        private static string maXuatMoiThem;

        public frm_XuatKho()
        {
            InitializeComponent();
        }
        // Hiển thị tất cả phiếu xuất và sinh mã phiếu mới
        public void LoadDuLieuXuatHang()
        {

            dgv_Data.DataSource = bus_XuatHang.HienThiDuLieuTheoMaCH(cbo_MaCH.SelectedValue.ToString());
        }

        // Hiển thị chi tiết xuất theo mã phiếu
        private void LoadChiTietTheoMaPX(string maPhieuNhap)
        {
            var dsChiTiet = bus_ChiTietXuat.LayChiTietTheoMaPhieu(maPhieuNhap);
            dgv_DataChiTiet.DataSource = dsChiTiet;
        }

        // Load dữ liệu cho combobox NCC, Cửa hàng, Sản phẩm
        private void LoadComboBox()
        {
            string[] listLoai = { "HangLoi", "HangHetHan" };
            cbo_LoaiXuat.DataSource = listLoai;

            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.DisplayMember = "TenCH";
            cbo_MaCH.ValueMember = "MaCH";

            cbo_MaSP.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.DisplayMember = "MaSanPham";
            cbo_MaSP.ValueMember = "MaSanPham";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_HoanTat.Enabled = true;
            try
            {
                maXuatMoiThem = TaoMaTuDong.TaoMa(bus_XuatHang.LayDanhSachMaXH(), "PX");
                et_XuatHang.MaPhieuXuat = maXuatMoiThem;
                et_XuatHang.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                et_XuatHang.MaNhanVien = Session.MaNhanVien;
                et_XuatHang.NgayXuat = dtp_NgayXuat.Value;
                et_XuatHang.LoaiXuat = cbo_LoaiXuat.SelectedItem.ToString();
                bus_XuatHang.Them(et_XuatHang);
                MessageBox.Show("Thêm phiếu xuất thành công");
                LoadDuLieuXuatHang(); // Tải lại danh sách

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm phiếu xuất thất bại Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maXuatMoiThem} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_XuatHang.Xoa(maXuatMoiThem);
                MessageBox.Show("Xóa phiếu xuất thành công");
                LoadDuLieuXuatHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa phiếu xuất thất bại Lỗi: " + ex.Message);
            }
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var ct in bus_ChiTietXuat.LayChiTietTheoMaPhieu(maXuatMoiThem))
                {
                    bus_CTK.CapNhapChiTietKhoKhiXuatHang(cbo_MaCH.SelectedValue.ToString(), ct, et_XuatHang.NgayXuat);
                }
                maXuatMoiThem = null;
                MessageBox.Show("Cập nhập kho thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("việc xử lý đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btn_InPhieuNhap_Click(object sender, EventArgs e)
        {
            string maXH = txt_MaXH.Text;
            frm_RP_PhieuXuatHang frm = new frm_RP_PhieuXuatHang(maXH);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            if (maXuatMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu xuất này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu xuất mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                et_ChiTietXuat.MaPhieuXuat = maXuatMoiThem;
                et_ChiTietXuat.MaSanPham = cbo_MaSP.Text;
                et_ChiTietXuat.SoLuong = int.Parse(txt_SLNhap.Text);
                et_ChiTietXuat.GiaXuat = double.Parse(txt_GiaXuat.Text);
                et_ChiTietXuat.GhiChu = rtf_GhiChu.Text;
                var slHienTai = bus_CTK.LaySLSanPhamCuaMotCH(cbo_MaCH.SelectedValue.ToString(), et_ChiTietXuat.MaSanPham);
                if(slHienTai < et_ChiTietXuat.SoLuong)
                {
                    MessageBox.Show("Xin lỗi hiện tại số lượng xuất đang lớn hơn số lượng trong kho");
                    return;
                }
                bus_ChiTietXuat.Them(et_ChiTietXuat);

                MessageBox.Show("Thêm chi tiết xuất thành công");
                btn_LamMoiChiTiet_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm chi tiết xuất thất bại Lỗi thêm: " + ex.Message);
            }
        }

        private void btn_XoaChiTiet_Click(object sender, EventArgs e)
        {
            if (maXuatMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu xuất này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu xuất mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maXuatMoiThem}-{cbo_MaSP.SelectedValue.ToString()} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {
                string maSanPham = cbo_MaSP.SelectedValue.ToString();
                bus_ChiTietXuat.Xoa(maXuatMoiThem, maSanPham);
                MessageBox.Show("Xóa chi tiết xuất thành công");
                LoadChiTietTheoMaPX(txt_MaXH.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
            }
        }

        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            if (maXuatMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu xuất này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu xuất mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                et_ChiTietXuat.MaPhieuXuat = maXuatMoiThem;
                et_ChiTietXuat.MaSanPham = cbo_MaSP.Text;
                et_ChiTietXuat.SoLuong = int.Parse(txt_SLNhap.Text);
                et_ChiTietXuat.GiaXuat = double.Parse(txt_GiaXuat.Text);
                et_ChiTietXuat.GhiChu = rtf_GhiChu.Text;
                bus_ChiTietXuat.Sua(et_ChiTietXuat);
                MessageBox.Show("Sửa chi tiết xuất thành công");
                btn_LamMoiChiTiet_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {

            LoadDuLieuXuatHang();
            LoadChiTietTheoMaPX(txt_MaXH.Text);
            txt_MaXH.Clear();
            txt_TongTien.Clear();
            txt_SLNhap.Clear();
            txt_GiaXuat.Clear();
            cbo_LoaiXuat.SelectedIndex = 0;
            cbo_MaSP.SelectedIndex = 0;
            dtp_NgayXuat.Text = DateTime.Now.ToShortDateString();
            rtf_GhiChu.Clear();
        }

        private void frm_XuatKho_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = true;
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_HoanTat.Enabled = false;
                cbo_MaCH.SelectedIndex = 0;

            }
            else if (Session.VaiTro == "QuanLy")
            {
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
                txt_MaNV.Text = Session.MaNhanVien;
            }
            else
            {
                btn_Them.Enabled = true;
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
                txt_MaNV.Text = Session.MaNhanVien;
            }
            LoadDuLieuXuatHang();
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            LoadChiTietTheoMaPX(dgv_Data.CurrentRow.Cells[0].Value.ToString());
        }





        private void frm_XuatKho_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 2;
            gbo_NhapThongTin.Top = 90;
            gbo_ThongTin.Left = (this.ClientSize.Width - gbo_ThongTin.Width) / 2;
            gbo_ThongTin.Top = gbo_NhapThongTin.Bottom + 20; ;
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            int dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) return;
            txt_MaXH.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            cbo_MaCH.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            txt_MaNV.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            dtp_NgayXuat.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            cbo_LoaiXuat.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
            LoadChiTietTheoMaPX(txt_MaXH.Text);



        }

        private void dgv_DataChiTiet_Click(object sender, EventArgs e)
        {
            if (dgv_DataChiTiet.CurrentCell == null || dgv_DataChiTiet.Rows.Count == 0)
                return;
            int dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) return;
            txt_MaXH.Text = dgv_DataChiTiet.Rows[dong].Cells[0].Value.ToString();
            cbo_MaSP.Text = dgv_DataChiTiet.Rows[dong].Cells[1].Value.ToString();
            txt_SLNhap.Text = dgv_DataChiTiet.Rows[dong].Cells[2].Value.ToString();
            txt_GiaXuat.Text = dgv_DataChiTiet.Rows[dong].Cells[3].Value.ToString();
            txt_TongTien.Text = dgv_DataChiTiet.Rows[dong].Cells[4].Value.ToString();
            rtf_GhiChu.Text = dgv_DataChiTiet.Rows[dong].Cells[5].Value?.ToString();
        }

        private void cbo_MaSP_SelectedValueChanged(object sender, EventArgs e)
        {
			string tenSP = TimTenSanPham(cbo_MaSP.SelectedValue.ToString());
			txt_TenSP.Text = tenSP;
			txt_GiaXuat.Text = bus_CTK.LayGiaBanCuaSanPhamCuaMotCH(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString()).ToString();
        }

        private void txt_SLNhap_Leave(object sender, EventArgs e)
        {
            if (!KiemTraSoNguyenHopLe(txt_SLNhap.Text))
            {
                errorProvider1.SetError(txt_SLNhap, "Chỉ được nhập số");
                txt_SLNhap.Text = "";
                txt_TongTien.Text = "";
                return;
            }
            errorProvider1.SetError(txt_SLNhap, "");
            int sl = Convert.ToInt32(txt_SLNhap.Text);
            double gia = Convert.ToDouble(txt_GiaXuat.Text);
            txt_TongTien.Text = (sl * gia).ToString();

        }
        public bool KiemTraSoNguyenHopLe(string s)
        {
            return int.TryParse(s, out _);
        }
		private string TimTenSanPham(string maSP)
		{
			return bus_SanPham.TimTenSPBangMaSP(maSP);
		}   

	}
}
