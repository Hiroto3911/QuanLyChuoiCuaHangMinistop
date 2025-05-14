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
        private void LoadDuLieuNhaCungCap()
        {
            dgv_Data.DataSource = bus_NhaCungCap.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        private void frm_QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieuNhaCungCap();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    et_NhaCungCap.MaNcc = TaoMaTuDong.TaoMa(bus_NhaCungCap.LayDanhSachMaNCC(), "NCC");
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var chapNhanXoa = MessageBox.Show($"Bạn có chắc muốn xoá dữ liệu {txt_MaNCC.Text} này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult.Cancel == chapNhanXoa) return;
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

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            rtf_DiaChi.Clear();
            txt_DTH.Clear();
            txt_Email.Clear();
            LoadDuLieuNhaCungCap();
        }

        private void dgv_Data_Click(object sender, EventArgs e)
        {
            if (dgv_Data.CurrentCell == null || dgv_Data.Rows.Count == 0)
                return;
            int dong = dgv_Data.CurrentCell.RowIndex;
            txt_MaNCC.Text = dgv_Data.Rows[dong].Cells[0].Value.ToString();
            txt_TenNCC.Text = dgv_Data.Rows[dong].Cells[1].Value.ToString();
            rtf_DiaChi.Text = dgv_Data.Rows[dong].Cells[2].Value.ToString();
            txt_DTH.Text = dgv_Data.Rows[dong].Cells[3].Value.ToString();
            txt_Email.Text = dgv_Data.Rows[dong].Cells[4].Value.ToString();
        }

        private void frm_QuanLyNhaCungCap_Resize(object sender, EventArgs e)
        {
            lbl_Title.Left = (this.ClientSize.Width - lbl_Title.Width) / 2;
            gbo_NhapThongTin.Left = (this.ClientSize.Width - gbo_NhapThongTin.Width) / 4;
            gbo_ThongTin.Left = gbo_NhapThongTin.Right + 20;
            gbo_NhapThongTin.Top = 90;
            gbo_ThongTin.Top = 90;
        }
        public bool KiemTraSoDienThoai(string s)
        {
            return s.All(char.IsDigit) && s.Length == 10 && s.StartsWith("0");
        }
        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }
        private void txt_DTH_Leave(object sender, EventArgs e)
        {
            if (!KiemTraSoDienThoai(txt_DTH.Text))
            {
                errorProvider1.SetError(txt_DTH, "Chỉ được nhập số và giới hạn là 10 số");
                txt_DTH.Text = "";
            }
            else
            {
                errorProvider1.SetError(txt_DTH, "");
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();

            // Kiểm tra email rỗng
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txt_Email,"Vui lòng nhập địa chỉ email.");

            }
            else
            {
                errorProvider1.SetError(txt_Email, "");
            }

            // Kiểm tra định dạng email hợp lệ
            if (!IsValidEmail(email))
            {
                errorProvider1.SetError(txt_Email, "Email không hợp lệ. Vui lòng nhập đúng định dạng.");

            }
            else
            {
                errorProvider1.SetError(txt_Email, "");
            }
        }
    }
}
