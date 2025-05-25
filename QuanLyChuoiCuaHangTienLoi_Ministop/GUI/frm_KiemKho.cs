using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;
using BUS;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class frm_KiemKho : Form
    {
        private BUS_KiemKho bus_KiemKho = new BUS_KiemKho();
        private BUS_ChiTietKiemKho bus_CTKK = new BUS_ChiTietKiemKho();
        private BUS_ChiTietKho bus_ChiTietKho = new BUS_ChiTietKho();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();
        private ET_KiemKho et_KiemKho = new ET_KiemKho();
        private ET_ChiTietKiemKho et_CTKK = new ET_ChiTietKiemKho();
        private static string maKKMoiThem;
        public frm_KiemKho()
        {
            InitializeComponent();
        }

        private void LoadThongTinDatagridview()
        {
            dgv_Data.DataSource = bus_KiemKho.HienThiDuLieuTheoMaCH(cbo_MaCH.SelectedValue.ToString());
        }
        private void LoadThongTinChiTietTheoMaDatagridview(string maKK)
        {
            dgv_DataChiTiet.DataSource = bus_CTKK.LayChiTietTheoMaPhieu(maKK);
        }
        // Load dữ liệu cho các ComboBox
        private void LoadComboBox()
        {


            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.DisplayMember = "TenCH";
            cbo_MaCH.ValueMember = "MaCH";

            cbo_MaSP.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.DisplayMember = "MaSanPham";
            cbo_MaSP.ValueMember = "MaSanPham";
        }
        private void KiemTraTrangThai(int chenhLech)
        {
            if (chenhLech == 0)
            {
                cbo_TrangThai.SelectedItem = "Khớp";
            }
            else if (chenhLech < 0)
            {
                cbo_TrangThai.SelectedItem = "Thiếu";
            }
            else if (chenhLech > 0)
            {
                cbo_TrangThai.SelectedItem = "Dư";
            }
        }
        private void LamMoiTextBox()
        {
            txt_MaKK.Clear();
            txt_SLThucTe.Clear();
            txt_ChenhLech.Clear();
            rtf_GhiChu.Clear();
        }

        private void frm_KiemKho_Load(object sender, EventArgs e)
        {
            cbo_TrangThai.DataSource = new List<string>() {"", "Khớp", "Thiếu", "Dư" };
            LoadComboBox();
            if (Session.VaiTro == "Admin")
            {
                cbo_MaCH.Enabled = true;
                btn_Them.Enabled = false;

            }
            else if (Session.VaiTro == "QuanLy")
            {
                btn_Them.Enabled = false;
            }
            else if (Session.VaiTro == "NhanVien")
            {
                cbo_MaCH.SelectedValue = Session.MaCuaHang;
                txt_MaNV.Text = Session.MaNhanVien;
            }
            LoadThongTinDatagridview();
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            LoadThongTinChiTietTheoMaDatagridview(dgv_Data.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                maKKMoiThem = TaoMaTuDong.TaoMa(bus_KiemKho.LayDanhSachMaKK(), "KK");
                et_KiemKho.MaKiemKho = maKKMoiThem;
                et_KiemKho.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                et_KiemKho.MaNhanVien = txt_MaNV.Text;
                et_KiemKho.NgayKiem = dtp_NgayKiem.Value;
                bus_KiemKho.Them(et_KiemKho);
                btn_LamMoiChiTiet_Click(sender, e);
                btn_Xoa.Enabled = true;
                btn_HoanTat.Enabled = true; 
                dgv_Data_Click(sender, e);
                MessageBox.Show("Thêm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {txt_MaKK.Text} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            if (bus_CTKK.LayChiTietTheoMaPhieu(txt_MaKK.Text).Count == 0)
            {
                try
                {
                    bus_KiemKho.Xoa(cbo_MaCH.SelectedValue.ToString(), txt_MaKK.Text);
                    btn_LamMoiChiTiet_Click(sender, e);
                    MessageBox.Show("Xóa thành công");
                    maKKMoiThem = null;
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
            if (maKKMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu kiểm này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu kiểm mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                et_CTKK.MaKiemKho = maKKMoiThem;
                et_CTKK.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_CTKK.SoLuongHeThong = Convert.ToInt32(txt_SLHeThong.Text);
                et_CTKK.SoLuongThucTe = Convert.ToInt32(txt_SLThucTe.Text);
                et_CTKK.ChenhLech = Convert.ToInt32(txt_ChenhLech.Text);
                et_CTKK.TrangThai = cbo_TrangThai.Text;
                et_CTKK.GhiChu = rtf_GhiChu.Text;
                bus_CTKK.Them(et_CTKK);
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
            if (maKKMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu kiểm này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu kiểm mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {txt_MaKK.Text}-{cbo_MaSP.Text} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_CTKK.Xoa(maKKMoiThem, et_CTKK.MaSanPham);
                MessageBox.Show("Xoá thành công");
                btn_LamMoiChiTiet_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoá thất bại Lỗi thêm: " + ex.Message);
            }
        }

        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            if (maKKMoiThem == null)
            {
                MessageBox.Show("Thành thật xin lỗi bạn. Phiếu kiểm này hiện tại đã hoàn tất không thể thêm xoá sửa được nữa " +
                "\n !Xin vui lòng tạo phiếu kiểm mới rồi bạn có thể thêm xoá sửa!", "Thông báo", MessageBoxButtons.OKCancel); return;
            }
            try
            {
                et_CTKK.MaKiemKho = maKKMoiThem;
                et_CTKK.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_CTKK.SoLuongHeThong = Convert.ToInt32(txt_SLHeThong.Text);
                et_CTKK.SoLuongThucTe = Convert.ToInt32(txt_SLThucTe.Text);
                et_CTKK.ChenhLech = Convert.ToInt32(txt_ChenhLech.Text);
                et_CTKK.TrangThai = cbo_TrangThai.Text;
                et_CTKK.GhiChu = rtf_GhiChu.Text;
                bus_CTKK.Sua(et_CTKK);
                MessageBox.Show("Sửa thành công");
                btn_LamMoiChiTiet_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại Lỗi thêm: " + ex.Message);
            }
        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
            LamMoiTextBox();
            dtp_NgayKiem.Text = DateTime.Now.ToShortDateString();
            cbo_MaSP.SelectedIndex = 0;
            cbo_TrangThai.SelectedIndex = 0;
            LoadThongTinDatagridview();
            LoadThongTinChiTietTheoMaDatagridview(dgv_Data.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            var dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) return;
            txt_MaKK.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString() ?? "";
            cbo_MaCH.SelectedValue = dgv_Data.Rows[dong].Cells[1].Value.ToString() ?? "";
            txt_MaNV.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString() ?? "";
            dtp_NgayKiem.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString() ?? "";
            string maKK = dgv_Data.Rows[dong].Cells[0].Value.ToString() ?? "";
            LoadThongTinChiTietTheoMaDatagridview(maKK);
        }

        private void dgv_DataChiTiet_Click(object sender, EventArgs e)
        {
            if (dgv_DataChiTiet.CurrentCell == null || dgv_DataChiTiet.Rows.Count == 0)
                return;
            var dong = dgv_DataChiTiet.CurrentCell.RowIndex;        
            if (dong > dgv_DataChiTiet.Rows.Count - 1) return;
            cbo_MaSP.SelectedValue = dgv_DataChiTiet.Rows[dong].Cells[1].Value.ToString()?? "";
            txt_SLHeThong.Text = dgv_DataChiTiet.Rows[dong].Cells[2].Value.ToString() ?? "";
            txt_SLThucTe.Text = dgv_DataChiTiet.Rows[dong].Cells[3].Value.ToString() ?? "";
            txt_ChenhLech.Text = dgv_DataChiTiet.Rows[dong].Cells[4].Value.ToString() ?? "";
            cbo_TrangThai.SelectedItem = dgv_DataChiTiet.Rows[dong].Cells[5].Value.ToString() ?? "";
            rtf_GhiChu.Text = dgv_DataChiTiet.Rows[dong].Cells[6].Value.ToString() ?? "";
        }

        private void frm_KiemKho_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 2;
            gbo_NhapThongTin.Top = 90;
            gbo_ThongTin.Left = (this.ClientSize.Width - gbo_ThongTin.Width) / 2;
            gbo_ThongTin.Top = gbo_NhapThongTin.Bottom + 20;
        }

        private void btn_HoanTat_Click(object sender, EventArgs e)
        {
            if (maKKMoiThem == null) { MessageBox.Show($"Hiện không có sự thay đổi nào cả", "Thông báo", MessageBoxButtons.OKCancel); return; }
            var chapNhan = MessageBox.Show($"Sau khi nhấn nút ok thì bạn sẽ không thể sửa hoặc xoá dữ liệu của phiếu kiểm này nữa", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhan) return;
            try
            {
                foreach(var ct in bus_CTKK.LayChiTietTheoMaPhieu(maKKMoiThem))
                {
                    if(ct.ChenhLech !=0)
                    {
                      var capNhap = bus_ChiTietKho.CapNhapChiTietKhoKhiKiemKho(cbo_MaCH.SelectedValue.ToString(), ct, DateTime.Now);
                        if (!capNhap)
                        {
                            MessageBox.Show($"Không thể cập nhật sản phẩm có mã {ct.MaSanPham} trong kho .", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                MessageBox.Show($" Đã cập nhập vào kho", "Thông báo");
                maKKMoiThem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi " + ex, "Thông báo", MessageBoxButtons.OKCancel);
            }
          
        }

        private void cbo_MaSP_SelectedValueChanged(object sender, EventArgs e)
        {
			string tenSP = TimTenSanPham(cbo_MaSP.SelectedValue.ToString());
			txt_TenSP.Text = tenSP;
			txt_SLHeThong.Text = bus_ChiTietKho.LaySLSanPhamCuaMotCH(cbo_MaCH.SelectedValue.ToString(), cbo_MaSP.SelectedValue.ToString()).ToString();
        }

        private void txt_SLThucTe_Leave(object sender, EventArgs e)
        {
            int slHeThong = Convert.ToInt32(txt_SLHeThong.Text);
            int slThucTe = Convert.ToInt32(txt_SLThucTe.Text);
            int chenhLech = slThucTe - slHeThong;
            txt_ChenhLech.Text = chenhLech.ToString();
            KiemTraTrangThai(chenhLech);

        }

		private string TimTenSanPham(string maSP)
		{
			return bus_SanPham.TimTenSPBangMaSP(maSP);
		}
	}
}
