using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_QuanLyKhuyenMai : Form
    {
        // biến tầng BUS
        BUS_KhuyenMai bus_KM = new BUS_KhuyenMai();
        BUS_KhuyenMai_SanPham bus_KM_SP = new BUS_KhuyenMai_SanPham();
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        // biến tầng ET
        ET_KhuyenMai et_KM = new ET_KhuyenMai();
        ET_KhuyenMai_SanPham et_KM_SP = new ET_KhuyenMai_SanPham();
        // biến local 

        // function control
        public frm_QuanLyKhuyenMai()
        {
            InitializeComponent();
        }

        private void frm_QuanLyKhuyenMai_Resize(object sender, EventArgs e)
        {
            llbl_title.Left = (this.ClientSize.Width - llbl_title.Width) / 2;
            gbo_KhuyenMai.Left = (this.ClientSize.Width - gbo_KhuyenMai.Width) / 2;
            gbo_KhuyenMai.Top = 90;
            gbo_ChiTietKhuyenMai.Top = gbo_KhuyenMai.Bottom + 20;
            gbo_ChiTietKhuyenMai.Left = (this.ClientSize.Width - gbo_ChiTietKhuyenMai.Width) / 2;

        }


        private void frm_QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDuLieuKhuyenMai();
            LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.CurrentRow.Cells[0].Value.ToString());
            cbo_UuTien.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbo_LoaiApDung.DataSource = new List<string> { "Sản phẩm", "Hoá đơn" };
            cbo_LocDuLieu.DataSource = new List<string> { "Sản phẩm", "Hoá đơn" };
            LoadLoaiKhuyenMaiCombobox();
            LoadLoaiSanPhamCombobox();
            rb_Bat.Checked = false;
            rb_Tat.Enabled = true;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int trangThai;
            if (rb_Bat.Checked == true)
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }

            try
            {

                string maKM = TaoMaTuDong.TaoMa(bus_KM.LayDanhSachMaKM(), "KM");
                et_KM.MaKhuyenMai = maKM;
                et_KM.TenKhuyenMai = txt_TenKM.Text;
                et_KM.MucGiamGia = Convert.ToDecimal(txt_MucGiam.Text);
                et_KM.NgayBatDau = Convert.ToDateTime(dtp_NgayBatDau.Value.ToShortDateString());
                et_KM.NgayKetThuc = Convert.ToDateTime(dtp_NgayKetThuc.Value.ToShortDateString());
                et_KM.LoaiApDung = cbo_LoaiApDung.Text;
                et_KM.DieuKienApDung = Convert.ToDecimal(txt_DieuKienApDung.Text);
                et_KM.TrangThai = trangThai;
                bus_KM.Them(et_KM);
                MessageBox.Show("Thêm thành công");
                LoadLoaiKhuyenMaidgvData(cbo_LocDuLieu.Text);
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.CurrentRow.Cells[0].Value.ToString());
                LoadLoaiKhuyenMaiCombobox();
                LamMoiTruongDuLieuKhuyenMai();


            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại \n Lỗi:" + ex); }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maKM = txt_MaKM.Text;
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maKM} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_KM.Xoa(maKM);
                MessageBox.Show("Xoá thành công");
                LoadLoaiKhuyenMaidgvData(cbo_LocDuLieu.Text);
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.CurrentRow.Cells[0].Value.ToString());
                LoadLoaiKhuyenMaiCombobox();
                LamMoiTruongDuLieuKhuyenMai();


            }
            catch (Exception ex) { MessageBox.Show("Xoá thất bại\n Lỗi:" + ex); }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int trangThai;
            if (rb_Bat.Checked == true)
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }
            try
            {
                et_KM.MaKhuyenMai = txt_MaKM.Text;
                et_KM.TenKhuyenMai = txt_TenKM.Text;
                et_KM.MucGiamGia = Convert.ToDecimal(txt_MucGiam.Text);
                et_KM.NgayBatDau = Convert.ToDateTime(dtp_NgayBatDau.Value.ToShortDateString());
                et_KM.NgayKetThuc = Convert.ToDateTime(dtp_NgayKetThuc.Value.ToShortDateString());
                et_KM.LoaiApDung = cbo_LoaiApDung.Text;
                et_KM.DieuKienApDung = Convert.ToDecimal(txt_DieuKienApDung.Text);
                et_KM.TrangThai = trangThai;
                bus_KM.Sua(et_KM);
                MessageBox.Show("Sửa thành công");
                LoadLoaiKhuyenMaidgvData(cbo_LocDuLieu.Text);
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.CurrentRow.Cells[0].Value.ToString());
                LoadLoaiKhuyenMaiCombobox();
                LamMoiTruongDuLieuKhuyenMai();
            }
            catch (Exception ex) { MessageBox.Show("Cập nhập thất bại\n Lỗi:" + ex, "Thông báo"); }
        }

        private void btn_ThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {


                et_KM_SP.MaKhuyenMai = cbo_MaKM.SelectedValue.ToString();
                et_KM_SP.MaSanPham = cbo_MaSP.SelectedValue.ToString();
                et_KM_SP.SoLuongToiThieu = Convert.ToInt32(txt_SLToiThieu.Text);
                et_KM_SP.DoUuTien = Convert.ToInt32(cbo_UuTien.SelectedItem.ToString());
                if (bus_KM_SP.KiemTraDoUuTien(et_KM_SP)) { MessageBox.Show($"Xin lỗi nhưng bạn độ ưu tiên {et_KM_SP.DoUuTien} của sản phẩm đã được áp dụng ", "Thông báo"); return; };
                bus_KM_SP.Them(et_KM_SP);
                MessageBox.Show("Thêm thành công");
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.CurrentRow.Cells[0].Value.ToString());



            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại \n Lỗi:" + ex); }
        }

        private void btn_XoaChiTiet_Click(object sender, EventArgs e)
        {
            string maKM = cbo_MaKM.SelectedValue.ToString();
            string maSP = cbo_MaSP.SelectedValue.ToString();
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {maKM}-{maSP} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_KM_SP.Xoa(maKM, maSP);
                MessageBox.Show("Xoá thành công");
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(maKM);



            }
            catch (Exception ex) { MessageBox.Show("Xoá thất bại\n Lỗi:" + ex); }
        }

        private void btn_SuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                et_KM_SP.MaKhuyenMai = cbo_MaKM.Text;
                et_KM_SP.MaSanPham = cbo_MaSP.Text;
                et_KM_SP.SoLuongToiThieu = Convert.ToInt32(txt_SLToiThieu.Text);
                et_KM_SP.DoUuTien = Convert.ToInt32(cbo_UuTien.SelectedItem.ToString());
                if (bus_KM_SP.KiemTraDoUuTien(et_KM_SP)) { MessageBox.Show($"Xin lỗi nhưng bạn độ ưu tiên {et_KM_SP.DoUuTien} của sản phẩm đã được áp dụng", "Thông báo"); return; };
                bus_KM_SP.Sua(et_KM_SP);
                MessageBox.Show("Sửa thành công");
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(cbo_MaKM.Text);
            }
            catch (Exception ex) { MessageBox.Show("Cập nhập thất bại\n Lỗi:" + ex, "Thông báo"); }
        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {
           
            LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.CurrentRow.Cells[0].Value.ToString());
            LoadLoaiKhuyenMaiCombobox();
            LoadLoaiSanPhamCombobox();
            LamMoiTruongDuLieuKhuyenMaiSanPham();

        }

        private void dgv_DataChiTiet_Click(object sender, EventArgs e)
        {
            int dong = dgv_DataChiTiet.CurrentCell.RowIndex;
            if (dong > dgv_DataChiTiet.Rows.Count - 1) { return; }
            cbo_MaKM.SelectedValue = dgv_DataChiTiet.Rows[dong].Cells[0].Value.ToString();
            cbo_MaSP.SelectedValue = dgv_DataChiTiet.Rows[dong].Cells[1].Value.ToString();
            txt_SLToiThieu.Text = dgv_DataChiTiet.Rows[dong].Cells[2].Value.ToString();
            cbo_UuTien.SelectedItem = dgv_DataChiTiet.Rows[dong].Cells[3].Value.ToString();

        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            int dong = dgv_Data.CurrentCell.RowIndex;
            if (dong > dgv_Data.Rows.Count - 1) { return; }
            txt_MaKM.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            txt_TenKM.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            txt_MucGiam.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            dtp_NgayBatDau.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            dtp_NgayKetThuc.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
            cbo_LoaiApDung.SelectedItem = dgv_Data.Rows[dong].Cells[5].Value.ToString();
            if (dgv_Data.Rows[dong].Cells[5].Value.ToString() == "Sản phẩm")
            {
                LoadDuLieuChiTietKhuyenMaiTheoMaKM(dgv_Data.Rows[dong].Cells[0].Value.ToString());
            }
            var dk = dgv_Data.Rows[dong].Cells[6].Value.ToString();
            txt_DieuKienApDung.Text = dk == null ? "null" : dk;
            if (Convert.ToInt32(dgv_Data.Rows[dong].Cells[7].Value.ToString()) == 1)
            {
                rb_Bat.Checked = true;
            }
            else
            {
                rb_Tat.Checked = true;
            }
        }


        private void txt_MucGiam_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MucGiam.Text))
            {
                btn_Them.Enabled = false;
                errorProvider1.SetError(txt_MucGiam, "Không được để trống!");
                return;
            }

            else if (!txt_MucGiam.Text.All(char.IsDigit))
            {
                btn_Them.Enabled = false;
                errorProvider1.SetError(txt_MucGiam, "dữ liệu nhập phải là số!");
                return;
            }
            else
            {
                btn_Them.Enabled = true;
                errorProvider1.SetError(txt_MucGiam, "");
            }
        }
        private void txt_TenKM_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKM.Text))
            {
                btn_Them.Enabled = false;
                errorProvider1.SetError(txt_TenKM, "Không được để trống!");
                return;
            }
            else
            {
                btn_Them.Enabled = true;
                errorProvider1.SetError(txt_TenKM, "");
            }
        }
        private void gbo_KhuyenMai_Enter(object sender, EventArgs e)
        {

        }

        private void dtp_NgayKetThuc_Leave(object sender, EventArgs e)
        {

            if (dtp_NgayKetThuc.Value < dtp_NgayBatDau.Value)
            {
                btn_Them.Enabled = false;
                errorProvider1.SetError(dtp_NgayKetThuc, "ngày kết thúc phải lớn hơn ngày bắt đầu");
            }
            else
            {
                btn_Them.Enabled = true;
                errorProvider1.SetError(dtp_NgayKetThuc, "");
            }
        }

        private void cbo_LoaiApDung_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiApDung.Text == "Sản phẩm")
            {
                txt_DieuKienApDung.Text = "0";
            }
        }

        private void cbo_LocDuLieu_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadLoaiKhuyenMaidgvData(cbo_LocDuLieu.SelectedItem.ToString());
        }
        // function hỗ trợ
        private void LoadDuLieuKhuyenMai()
        {
            dgv_Data.DataSource = bus_KM.HienThiDuLieuMotKMSapXepGiamDanTheoMa();
        }
        private void LoadDuLieuChiTietKhuyenMaiTheoMaKM(string maKM)
        {
            dgv_DataChiTiet.DataSource = bus_KM_SP.HienThiDuLieuMotKMSapXepGiamDanTheoMaKM(maKM);
        }

        private void LoadLoaiSanPhamCombobox()
        {
            cbo_MaSP.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaSP.ValueMember = "MaSanPham";
            cbo_MaSP.DisplayMember = "TenSanPham";
        }
        private void LoadLoaiKhuyenMaiCombobox()
        {
            cbo_MaKM.DataSource = bus_KM.HienThiDuLieuTheoLoaiApDung("Sản phẩm");
            cbo_MaKM.ValueMember = "MaKhuyenMai";
            cbo_MaKM.DisplayMember = "TenKhuyenMai";
        }
        private void LoadLoaiKhuyenMaidgvData(string loaiApDung)
        {
            dgv_Data.DataSource = bus_KM.HienThiDuLieuTheoLoaiApDung(loaiApDung);

        }
        private void LamMoiTruongDuLieuKhuyenMai()
        {
            txt_MaKM.Clear();
            txt_TenKM.Clear();
            txt_MucGiam.Clear();
            rb_Bat.Checked = false;
            rb_Tat.Checked = true;
            dtp_NgayBatDau.Text = DateTime.Now.ToShortDateString();
            dtp_NgayKetThuc.Text = DateTime.Now.ToShortDateString();
            cbo_LoaiApDung.SelectedIndex = 0;
            txt_DieuKienApDung.Text = "0";
        }
        private void LamMoiTruongDuLieuKhuyenMaiSanPham()
        {
            txt_SLToiThieu.Clear();
            cbo_MaKM.SelectedIndex = 0;
            cbo_MaSP.SelectedIndex = 0;
            cbo_UuTien.SelectedIndex = 0;
            
        }

       
    }
}
