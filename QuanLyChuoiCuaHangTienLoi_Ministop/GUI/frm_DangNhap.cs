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
using System.Runtime.InteropServices.WindowsRuntime;
namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        private BUS_DangNhap bus_DangNhap = new BUS_DangNhap();
        private BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            rb_NhanVien.Checked = true;
            txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string vaiTro = null;
            if (rb_Admin.Checked)
            {
                vaiTro = "Admin";
            }
            else if (rb_QLCH.Checked)
            {
                vaiTro = "QuanLy";
            }
            else
            {
                vaiTro = "NhanVien";
            }
            string taiKhoan = txt_TaiKhoan.Text;
            string matKhau = txt_MatKhau.Text;
            var kq = bus_DangNhap.KiemTraDangNhap(taiKhoan, matKhau, vaiTro);
            if (kq == false) { MessageBox.Show("Có vẻ như bạn đã đăng nhập sai \n Vui lòng thử lại", "Đăng nhập thất bại", MessageBoxButtons.OKCancel); return; }
            BUS_NhanVien nv = new BUS_NhanVien();
            var user = nv.TimNhanVienDuaTrenTaiKhoanDangNhap(vaiTro, taiKhoan, matKhau);
            Session.MaNhanVien = user.MaNV;
            Session.HoTen = user.HoTen;
            Session.VaiTro = user.VaiTro;
            Session.MaCuaHang = user.MaCuaHang;

            frm_Main main = new frm_Main();
            this.Hide();
            main.ShowDialog();
            this.Close();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //   var kq = MessageBox.Show("Bạn có chắc là muốn thoát", "Thông báo", MessageBoxButtons.OKCancel);
        //    if(DialogResult.Cancel == kq) { e.Cancel = true;}
        //}

        private void chk_HienThiMatKhau_Click(object sender, EventArgs e)
        {
            var hienThiPass = txt_MatKhau.UseSystemPasswordChar == true ? txt_MatKhau.UseSystemPasswordChar = false : txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_TaiKhoan.Text))
            {
                errorProvider1.SetError(txt_TaiKhoan, "Không được để trống");
            }
            else
            {
                errorProvider1.SetError(txt_TaiKhoan, "");
            }
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                errorProvider1.SetError(txt_MatKhau, "Không được để trống");
            }
            else
            {
                errorProvider1.SetError(txt_MatKhau, "");
            }
        }

        private void txt_TaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MatKhau.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void txt_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap_Click(sender, e);
                e.Handled = true; 
                e.SuppressKeyPress = true;
            }
        }
    }
}
