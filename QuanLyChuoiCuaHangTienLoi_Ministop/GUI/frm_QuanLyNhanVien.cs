using BUS;
using ET;
using System;
using System.CodeDom;
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
    public partial class frm_QuanLyNhanVien : Form
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        private ET_NhanVien et_NhanVien = new ET_NhanVien();

        private void LoadDuLieuNhanVien()
        {
            dgv_Data.DataSource = bus_NhanVien.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        private void LoadDuLieuCuaHang()
        {
            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
        }
      
        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cbo_VaiTro.DataSource = new List<string> { "NhanVien", "QuanLy", "Admin" };
            cbo_LocDanhSach.DataSource = new List<string> { "NhanVien", "QuanLy", "Admin" };
            LoadDuLieuNhanVien();
            LoadDuLieuCuaHang();
            rb_Nam.Checked = true;
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            try
            {
                int dong = dgv_Data.CurrentCell.RowIndex;
                txt_MaNV.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
                txt_HoTen.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
                string gt = dgv_Data.Rows[dong].Cells[2].Value.ToString();
                if (gt == "Nam")
                {
                    rb_Nam.Checked = true;
                    rb_Nu.Checked = false;

                }
                else
                {
                    rb_Nam.Checked = false;
                    rb_Nu.Checked = true;
                }
                dtp_NgaySinh.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
                txt_sodienthoai.Text = dgv_Data.Rows[dong].Cells[4].Value != null ? dgv_Data.Rows[dong].Cells[4].Value.ToString():"null";
                dtp_NgayLamViec.Text = dgv_Data.Rows[dong].Cells[5].Value.ToString();
                txt_TaiKhoan.Text = dgv_Data.Rows[dong].Cells[6].Value.ToString() ;
                txt_MatKhau.Text = dgv_Data.Rows[dong].Cells[7].Value.ToString() ;
                cbo_VaiTro.SelectedItem = dgv_Data.Rows[dong].Cells[8].Value.ToString();
                 var maCH = dgv_Data.Rows[dong].Cells[9].Value;
                if (maCH != null)
                {
                    cbo_MaCH.SelectedValue = maCH.ToString();
                }
                else
                {


                    cbo_MaCH.Text = "null";
                }
              

            }
            catch (Exception ex) {

                MessageBox.Show("Có lỗi khi bạn click vào data "+ex);

            }
            
        }

        private void cbo_VaiTro_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_VaiTro.SelectedItem == "Admin")
            {
                cbo_MaCH.Text = null;
                cbo_MaCH.Enabled = false;

            }
            else
            {
                cbo_MaCH.Enabled=true;
            }
            

        }

        private void frm_QuanLyNhanVien_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2; 
            gbo_NhapThongTin.Left= (this.ClientSize.Width - gbo_NhapThongTin.Width) / 2;
            gbo_NhapThongTin.Top = 90; 
            gbo_ThongTin.Left = (this.ClientSize.Width - gbo_ThongTin.Width)/2;
            gbo_ThongTin.Top = gbo_NhapThongTin.Bottom + 20; 

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                et_NhanVien.HoTen = txt_HoTen.Text;
                if (rb_Nam.Checked)
                {
                    et_NhanVien.GioiTinh = "Nam";

                }
                else
                {
                    et_NhanVien.GioiTinh = "Nữ";
                }
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_NhanVien.SoDienThoai = txt_sodienthoai.Text;
                et_NhanVien.NgayLamViec = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.TaiKhoan = txt_TaiKhoan.Text;
                et_NhanVien.MatKhau = SimpleHash.hash(txt_MatKhau.Text);
                var vaiTro = cbo_VaiTro.Text;
                if (vaiTro == "Admin")
                {
                    et_NhanVien.MaNV = TaoMaTuDong.TaoMa(bus_NhanVien.LayDanhSachMaNVTheoVaiTro(vaiTro), "AD");
                    et_NhanVien.MaCuaHang = null;
                }
                else if (vaiTro == "QuanLy")
                {
                    et_NhanVien.MaNV = TaoMaTuDong.TaoMa(bus_NhanVien.LayDanhSachMaNVTheoVaiTro(vaiTro), "QL");
                    et_NhanVien.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                }
                else
                {
                    et_NhanVien.MaNV = TaoMaTuDong.TaoMa(bus_NhanVien.LayDanhSachMaNVTheoVaiTro(vaiTro), "NV");
                    et_NhanVien.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                }
                et_NhanVien.VaiTro = cbo_VaiTro.Text;
                bus_NhanVien.Them(et_NhanVien);
                btn_LamMoi_Click(sender, e);
                MessageBox.Show("Thêm Thành Công");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
            LoadDuLieuNhanVien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {txt_MaNV.Text}-{txt_HoTen.Text} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
            try
            {

                bus_NhanVien.Xoa(txt_MaNV.Text);
                MessageBox.Show(" Xoá Thành Công");
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Xoá Thất Bại" + ex);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                et_NhanVien.MaNV = txt_MaNV.Text;
                et_NhanVien.HoTen = txt_HoTen.Text;
                if (rb_Nam.Checked)
                {
                    et_NhanVien.GioiTinh = "Nam";

                }
                else
                {
                    et_NhanVien.GioiTinh = "Nữ";
                }
                et_NhanVien.NgaySinh = Convert.ToDateTime(dtp_NgaySinh.Text);
                et_NhanVien.SoDienThoai = txt_sodienthoai.Text;
                et_NhanVien.NgayLamViec = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.TaiKhoan = txt_TaiKhoan.Text;
                et_NhanVien.MatKhau = SimpleHash.hash(txt_MatKhau.Text);
                et_NhanVien.VaiTro = cbo_VaiTro.Text;
                bus_NhanVien.Sua(et_NhanVien);
                MessageBox.Show(" Sửa Thành Công");
                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Sửa Thất Bại" + ex);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadDuLieuNhanVien();
            LoadDuLieuCuaHang();
            txt_MaNV.Clear();
            txt_HoTen.Clear();
            txt_MatKhau.Clear();
            txt_sodienthoai.Clear();
            txt_TaiKhoan.Clear();
            cbo_VaiTro.SelectedIndex = 0;
            cbo_MaCH.Text = null;
            rb_Nam.Checked = true;
            rb_Nu.Checked = false;
            dtp_NgayLamViec.Text = DateTime.Now.ToShortDateString();
            dtp_NgaySinh.Text = DateTime.Now.ToShortDateString();
        }

        private void cbo_LocDanhSach_SelectedValueChanged(object sender, EventArgs e)
        {
            dgv_Data.DataSource = bus_NhanVien.HienThiDuLieuTheoVaiTro(cbo_LocDanhSach.SelectedItem.ToString());
        }
        public bool KiemTraSoDienThoai(string s)
        {
            return s.All(char.IsDigit) && s.Length == 10 && s.StartsWith("0");
        }

        private void txt_sodienthoai_Leave(object sender, EventArgs e)
        {
            if (!KiemTraSoDienThoai(txt_sodienthoai.Text))
            {
                errorProvider1.SetError(txt_sodienthoai, "Chỉ được nhập số và giới hạn là 10 số");
                txt_sodienthoai.Text = "";
            }
            else
            {
                errorProvider1.SetError(txt_sodienthoai, "");
            }
        }
    }
}
