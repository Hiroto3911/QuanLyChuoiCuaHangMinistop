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
    public partial class frm_QuanLyNhaCungCap : Form
    {
        public frm_QuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        private BUS_NhaCungCap bus_NhaCungCap = new BUS_NhaCungCap();
        private ET_NhaCungCap et_NhaCungCap = new ET_NhaCungCap();


        private void  LoadDuLieuNhaCungCap()
        {
            dgv_Data.DataSource = bus_NhaCungCap.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    et_NhaCungCap.MaNcc = TaoMaTuDong.TaoMa(bus_NhaCungCap.LayDanhSachMaNCC(), "MCC");
                    et_NhaCungCap.TenNcc = txt_TenNCC.Text;
                    et_NhaCungCap.DiaChi = rtf_DiaChi.Text;
                    et_NhaCungCap.SoDienThoai = txt_DTH.Text;
                    et_NhaCungCap.Email = txt_Email.Text;
                    bus_NhaCungCap.Them(et_NhaCungCap);
                    MessageBox.Show("Thêm Thành Công");
                    LoadDuLieuNhaCungCap();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại" + ex);
                }


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

                bus_NhaCungCap.Xoa(txt_MaNCC.Text);
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
                et_NhaCungCap.MaNcc = txt_MaNCC.Text;
                et_NhaCungCap.TenNcc = txt_TenNCC.Text;
                et_NhaCungCap.DiaChi = rtf_DiaChi.Text;
                et_NhaCungCap.SoDienThoai = txt_DTH.Text;
                et_NhaCungCap.Email = txt_Email.Text;

                bus_NhaCungCap.Sua(et_NhaCungCap);

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
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            rtf_DiaChi.Clear();
            txt_DTH.Clear();
            txt_Email.Clear();
            LoadDuLieuNhaCungCap();
        }

        private void frm_QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieuNhaCungCap();
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            int dong = dgv_Data.CurrentCell.RowIndex;
            txt_MaNCC.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            txt_TenNCC.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            rtf_DiaChi.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            txt_DTH.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            txt_Email.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
        }
    }
}
