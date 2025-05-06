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
        private BUS_NhanVien bus_NhanVien=new BUS_NhanVien();
        private ET_NhanVien et_NhanVien = new ET_NhanVien();

        private void LoadDuLieuNhanVien ()
        {
            dgv_Data.DataSource = bus_NhanVien.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        private void LoadDuLieuCuaHang()
        {
            cbo_MaCH.DataSource = bus_CuaHang.HienThiDuLieuSapXepGiamDanTheoMa ();
            cbo_MaCH.ValueMember = "MaCH";
            cbo_MaCH.DisplayMember = "TenCH";
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
                et_NhanVien.NgaySinh =  Convert.ToDateTime( dtp_NgaySinh.Text);
                et_NhanVien.SoDienThoai = txt_sodienthoai.Text;
                et_NhanVien.NgayLamViec = Convert.ToDateTime(dtp_NgayLamViec.Text);
                et_NhanVien.TaiKhoan = txt_TaiKhoan.Text;
                et_NhanVien.MatKhau = SimpleHash.hash(txt_MatKhau.Text);
                var vaiTro = cbo_VaiTro.Text;
                if (vaiTro == "Admin")
                {
                    et_NhanVien.MaNV = TaoMaTuDong.TaoMa(bus_NhanVien.LayDanhSachMaNVTheoVaiTro(vaiTro), "AD");
                }
                else if (vaiTro == "Quản Lý")
                {
                    et_NhanVien.MaNV = TaoMaTuDong.TaoMa(bus_NhanVien.LayDanhSachMaNVTheoVaiTro(vaiTro), "QL");
                }
                else {
                    et_NhanVien.MaNV = TaoMaTuDong.TaoMa(bus_NhanVien.LayDanhSachMaNVTheoVaiTro(vaiTro), "NV");
                }
                et_NhanVien.VaiTro = cbo_VaiTro.Text;
                
                
                et_NhanVien.MaCuaHang = cbo_MaCH.SelectedValue.ToString();
                bus_NhanVien.Them(et_NhanVien);
                MessageBox.Show("Thêm Thành Công");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
            LoadDuLieuNhanVien();
        }

        private void dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cbo_VaiTro.DataSource = new List<string> { "Admin", "QuanLy", "NhanVien" };
           

            LoadDuLieuNhanVien();
            LoadDuLieuCuaHang();
        }

        private void dgv_Data_Click(object sender, EventArgs e)
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
          txt_sodienthoai.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
            dtp_NgayLamViec.Text  = dgv_Data.Rows[dong].Cells[5].Value.ToString();

            txt_TaiKhoan.Text = dgv_Data.Rows[dong].Cells[6].Value.ToString();
            txt_MatKhau.Text = dgv_Data.Rows[dong].Cells[7].Value.ToString();
            cbo_VaiTro.Text = dgv_Data.Rows[dong].Cells[8].Value.ToString();
            cbo_MaCH.Text = dgv_Data.Rows[dong].Cells[9].Value.ToString();
        }
    }
}
