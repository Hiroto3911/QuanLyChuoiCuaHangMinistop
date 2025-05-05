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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
     


        private void btn_QLCH_Click(object sender, EventArgs e)
        {
         
            frm_QuanLyCuaHang qlch = new frm_QuanLyCuaHang();
            qlch.MdiParent = this;
            qlch.Show();
        }

        private void btn_CTK_Click(object sender, EventArgs e)
        {
            frm_ChiTietKho ctk = new frm_ChiTietKho();
            ctk.MdiParent = this;
            ctk.Show();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lbl_HelloUser.Text = "Xin chào " + Session.HoTen + " |";
           
            if (Session.VaiTro == "Admin")
            {
                
            }
            else
            {
                List<Panel> panelFunToHide = new List<Panel>();
                if (Session.VaiTro == "QuanLy")
                {
                    panelFunToHide = new List<Panel>()
                    {
                        pnl_QuanLyCuaHang,
                        pnl_QuanLyNhanVien,
                        pnl_QuanLyNhaCungCap,
                        pnl_QuanLySanPham,
                        pnl_QuanLyKhuyenMai
                    };


                }
                else
                {
                    panelFunToHide = new List<Panel>()
                    {
                        pnl_QuanLyCuaHang,
                        pnl_QuanLyNhanVien,
                        pnl_QuanLyNhaCungCap,
                        pnl_QuanLySanPham,
                        pnl_QuanLyKhuyenMai,
                        pnl_NhapHang,
                        pnl_ChiTietKho,
                        pnl_QuanLyLichSuGiaSP
                    };

                }
                foreach (var pnl in panelFunToHide)
                {
                    pnl.Visible = false;
                }
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dn = new frm_DangNhap();
            Session.DangThoat();
            this.Hide();
            dn.ShowDialog();
            this.Close();


        }

        private void btn_BH_Click(object sender, EventArgs e)
        {
            frm_BanHang bh = new frm_BanHang();
            bh.MdiParent = this;
            bh.Show();
        }

        private void btn_QLKM_Click(object sender, EventArgs e)
        {
            frm_QuanLyKhuyenMai km = new frm_QuanLyKhuyenMai();
            km.MdiParent = this;
            km.Show();
        }

       
    }
}
