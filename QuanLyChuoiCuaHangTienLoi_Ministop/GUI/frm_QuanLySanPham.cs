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

namespace GUI
{
    public partial class frm_QuanLySanPham : Form
    {
        public frm_QuanLySanPham()
        {
            InitializeComponent();
        }
        private BUS_SanPham bus_SanPham = new BUS_SanPham();
        private ET_SanPham et_SanPham = new ET_SanPham();

        private void LoadDanhSachSanPham()
        {
            dgv_Data.DataSource = bus_SanPham.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        private void frm_QuanLySanPham_Load(object sender, EventArgs e)
        {
            cbo_LoaiSP.DataSource = new List<string> { "Nước giải khát", "Mì gói", "Bánh kẹo", "Sữa", "Đồ hộp" };
            LoadDanhSachSanPham();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                et_SanPham.MaSanPham = TaoMaTuDong.TaoMa(bus_SanPham.LayDanhSachMaSP(), "SP");
                et_SanPham.TenSanPham = txt_TenSP.Text;
                et_SanPham.GiaMacDinh = Convert.ToDecimal(txt_GiaBanTieuChuan.Text);
                et_SanPham.DonViTinh = cbo_DonVi.SelectedItem.ToString();
                et_SanPham.LoaiSanPham = cbo_LoaiSP.SelectedItem.ToString();
                bus_SanPham.Them(et_SanPham);
                MessageBox.Show("Thêm Thành Công");
                LoadDanhSachSanPham();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                bus_SanPham.Xoa(txt_MaSP.Text);
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
                et_SanPham.MaSanPham = txt_MaSP.Text;
                et_SanPham.TenSanPham = txt_TenSP.Text;
                et_SanPham.GiaMacDinh = Convert.ToDecimal(txt_GiaBanTieuChuan.Text);
                et_SanPham.DonViTinh = cbo_DonVi.SelectedItem.ToString();
                et_SanPham.LoaiSanPham = cbo_LoaiSP.SelectedItem.ToString();
                bus_SanPham.Sua(et_SanPham);
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
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_GiaBanTieuChuan.Clear();
            cbo_LoaiSP.SelectedIndex = 0;
            LoadDanhSachSanPham();
            txt_TimKiem.Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var timKiem = bus_SanPham.TimSanPhamBangTen(txt_TimKiem.Text);
            if (timKiem != null)
            {
                dgv_Data.DataSource = bus_SanPham.TimSanPhamBangTen(txt_TimKiem.Text);
                MessageBox.Show("Đã tìm thấy sản phẩm trùng với từ khóa" + txt_TimKiem.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm trùng với từ khóa" + txt_TimKiem.Text);
            }
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            int dong = dgv_Data.CurrentCell.RowIndex;
            txt_MaSP.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            txt_TenSP.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            txt_GiaBanTieuChuan.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            cbo_DonVi.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            cbo_LoaiSP.SelectedItem = dgv_Data.Rows[dong].Cells[4].Value.ToString();
            
        }

        private void cbo_LoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiSP.SelectedItem == "Nước giải khát")
            {
                cbo_DonVi.DataSource = new List<string> { "Chai", "Lon" };

            }
            else if (cbo_LoaiSP.SelectedItem == "Mì gói")
            {
                cbo_DonVi.DataSource = new List<string> { "Gói" };
            }
            else if (cbo_LoaiSP.SelectedItem == "Bánh kẹo")
            {

                cbo_DonVi.DataSource = new List<string> { "Bịch" };
            }
            else if (cbo_LoaiSP.SelectedItem == "Sữa")
            {
                cbo_DonVi.DataSource = new List<string> { "Hộp", "Bịch" };
            }
            else if (cbo_LoaiSP.SelectedItem == "Đồ hộp")
            {
                cbo_DonVi.DataSource = new List<string> { "Hộp" };
            }

            dgv_Data.DataSource = bus_SanPham.HienThiSanPhamBangLoaiSanPham(cbo_LoaiSP.SelectedItem.ToString());
        }

        private void frm_QuanLySanPham_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 4;
            gbo_ThongTin.Left = gbo_NhapThongTin.Right + 20;
            gbo_NhapThongTin.Top = 90;
            gbo_ThongTin.Top = 90;
        }
    }
}
