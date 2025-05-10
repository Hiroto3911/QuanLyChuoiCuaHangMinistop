using BUS;
using BUS.BUS;
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
    public partial class frm_XuatKho : Form
    {
        public frm_XuatKho()
        {
            InitializeComponent();
        }

        // Khởi tạo các lớp xử lý nghiệp vụ và thực thể
        private BUS_XuatHang bus_XuatHang = new BUS_XuatHang();
        private ET_XuatHang et_XuatHang = new ET_XuatHang();
        private BUS_ChiTietXuatHang bus_ChiTietXuat = new BUS_ChiTietXuatHang();
        private ET_ChiTietXuatHang et_ChiTietXuat = new ET_ChiTietXuatHang();
        private BUS_NhaCungCap bus_NhaCungCap = new BUS_NhaCungCap();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();

        // Khi form load, gọi dữ liệu phiếu xuất và combobox
        private void frm_NhapKho_Load(object sender, EventArgs e)
        {
            LoadDuLieuXuatHang();
            LoadComboBox();
        }

        // Hiển thị tất cả phiếu xuất và sinh mã phiếu mới
        public void LoadDuLieuXuatHang()
        {
            txt_MaXH.Text = TaoMaTuDong.TaoMa(bus_XuatHang.HienThiTatCa().Select(x => x.MaPhieuXuat).ToList(), "PN");
            dgv_Data.DataSource = bus_XuatHang.HienThiTatCa();
        }

        // Hiển thị tất cả chi tiết xuất (nếu cần)
        private void LoadDuLieuChiTiet()
        {
            dgv_DataChiTiet.DataSource = bus_ChiTietXuat.HienThiTatCa();
        }

        // Hiển thị chi tiết xuất theo mã phiếu
        private void LoadChiTietTheoMaPN(string maPhieuNhap)
        {
            var dsChiTiet = bus_ChiTietXuat.LayChiTietTheoMaPhieu(maPhieuNhap);
            dgv_DataChiTiet.DataSource = dsChiTiet;
        }

        // Load dữ liệu cho combobox NCC, Cửa hàng, Sản phẩm
        private void LoadComboBox()
        {
            string[] listLoai = { "KiemKeLech", "HangLoi", "HangHetHan"};

            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.DisplayMember = "TenCH";
            cbo_MaCH.ValueMember = "MaCH";

            cbo_MaSP.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.DisplayMember = "TenSanPham";
            cbo_MaSP.ValueMember = "MaSanPham";
        }

        // Thêm mới phiếu nhập
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                et_XuatHang.MaPhieuXuat = txt_MaXH.Text;
                et_XuatHang.MaCuaHang = cbo_MaCH.Text;
                et_XuatHang.MaNhanVien = txt_MaNV.Text;
                et_XuatHang.NgayXuat = dtp_NgayXuat.Value;
                et_XuatHang.LoaiXuat = cbo_LoaiXuat.Text;

                if (bus_XuatHang.Them(et_XuatHang))
                {
                    MessageBox.Show("Thêm phiếu xuất thành công");
                    LoadDuLieuXuatHang();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu xuất thất bại");
                }

                LoadDuLieuXuatHang(); // Tải lại danh sách
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Xóa phiếu nhập
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieuXuat = txt_MaXH.Text;
                if (bus_XuatHang.Xoa(maPhieuXuat))
                {
                    MessageBox.Show("Xóa phiếu xuất thành công");
                    LoadDuLieuXuatHang();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu xuất thất bại");
                }

                LoadDuLieuXuatHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Thêm chi tiết phiếu nhập
        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                et_ChiTietXuat.MaPhieu = txt_MaXH.Text;
                et_ChiTietXuat.MaSanPham = cbo_MaSP.Text;
                et_ChiTietXuat.SoLuong = int.Parse(txt_SLNhap.Text);
                et_ChiTietXuat.GiaXuat = double.Parse(txt_GiaNhap.Text);
                et_ChiTietXuat.TongTien = double.Parse(txt_TongTien.Text);
                et_ChiTietXuat.GhiChu = rtf_GhiChu.Text;

                if (bus_ChiTietXuat.Them(et_ChiTietXuat))
                {
                    MessageBox.Show("Thêm chi tiết xuất thành công");
                    LoadChiTietTheoMaPX(txt_MaXH.Text);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết xuất thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void LoadChiTietTheoMaPX(string maPhieuXuat)
        {
            dgv_DataChiTiet.DataSource = bus_ChiTietXuat.LayChiTietTheoMaPhieu(maPhieuXuat);
        }

        // Xoá chi tiết
        private void btn_XoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maSanPham = cbo_MaSP.Text;
                if (bus_ChiTietXuat.Xoa(txt_MaXH.Text, maSanPham))
                {
                    MessageBox.Show("Xóa chi tiết xuất thành công");
                    LoadChiTietTheoMaPX(txt_MaXH.Text);
                }
                else
                {
                    MessageBox.Show("Xóa chi tiết xuất thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
            }
        }

        // Sửa chi tiết
        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                et_ChiTietXuat.MaPhieu = txt_MaXH.Text;
                et_ChiTietXuat.MaSanPham = cbo_MaSP.Text;
                et_ChiTietXuat.SoLuong = int.Parse(txt_SLNhap.Text);
                et_ChiTietXuat.GiaXuat = double.Parse(txt_GiaNhap.Text);
                et_ChiTietXuat.TongTien = et_ChiTietXuat.SoLuong * et_ChiTietXuat.GiaXuat;
                et_ChiTietXuat.GhiChu = rtf_GhiChu.Text;

                if (bus_ChiTietXuat.Sua(et_ChiTietXuat))
                {
                    MessageBox.Show("Sửa chi tiết xuất thành công");
                    LoadChiTietTheoMaPX(txt_MaXH.Text);
                }
                else
                {
                    MessageBox.Show("Sửa chi tiết xuất thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // Tính tổng tiền khi thay đổi số lượng
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // Tính tổng tiền khi thay đổi giá
        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // Công thức tính tổng tiền
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

        // Làm mới dữ liệu phiếu nhập và chi tiết
        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
            et_ChiTietXuat.MaPhieu = txt_MaXH.Text;
            et_ChiTietXuat.MaSanPham = cbo_MaSP.SelectedItem.ToString();
            et_ChiTietXuat.SoLuong = int.Parse(txt_SLNhap.Text);
            et_ChiTietXuat.GiaXuat = double.Parse(txt_GiaNhap.Text);
            et_ChiTietXuat.TongTien = double.Parse(txt_TongTien.Text);
            et_ChiTietXuat.GhiChu = rtf_GhiChu.Text;

            if (bus_ChiTietXuat.Sua(et_ChiTietXuat))
            {
                MessageBox.Show("Cập nhật chi tiết xuất thành công");
                LoadChiTietTheoMaPX(txt_MaXH.Text); // Tải lại chi tiết theo mã phiếu
            }
            else
            {
                MessageBox.Show("Cập nhật chi tiết xuất thất bại");
            }
        }

        // Hiển thị dữ liệu chi tiết khi click vào dòng chi tiết
        private void dgv_DataChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaXH.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbo_MaSP.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_SLNhap.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_GiaNhap.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_TongTien.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[4].Value.ToString();
                rtf_GhiChu.Text = dgv_DataChiTiet.Rows[e.RowIndex].Cells[5].Value?.ToString();
            }
        }

        // Hiển thị chi tiết tương ứng khi chọn dòng phiếu nhập
        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maPN = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadChiTietTheoMaPN(maPN);
            }
        }

        // Nút in phiếu nhập (chưa làm)
        private void btn_InPhieuNhap_Click(object sender, EventArgs e)
        {
            // TODO: Làm Crystal Report in phiếu nhập
        }
    }
}
