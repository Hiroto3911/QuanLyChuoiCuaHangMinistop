﻿using ET;
using GUI.Reporting;
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
                pnl_BanHang.Visible = false;
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
                        pnl_QuanLyKhuyenMai,
                        pnl_TongDoanhThu
                    };


                }
                else
                {
                    bToolStripMenuItem.Visible = false;
                    panelFunToHide = new List<Panel>()
                    {
                        pnl_QuanLyCuaHang,
                        pnl_QuanLyNhanVien,
                        pnl_QuanLyNhaCungCap,
                        pnl_QuanLySanPham,
                        pnl_QuanLyKhuyenMai,
                        pnl_NhapHang,
                        pnl_ChiTietKho,
                        pnl_QuanLyLichSuGiaSP,
                        pnl_DoanhThuCuaHang,
                        pnl_BaoCaoKho,
                        pnl_TongDoanhThu,
                        pnl_SanPhamHayThatThoat
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

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhanVien nv = new frm_QuanLyNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void btn_QLLSGSP_Click(object sender, EventArgs e)
        {
            frm_QuanLyLichSuThayDoiGiaSanPham lsg = new frm_QuanLyLichSuThayDoiGiaSanPham();
            lsg.MdiParent = this;
            lsg.Show();
        }

        private void btn_DoanhThuTungCH_Click(object sender, EventArgs e)
        {
            frm_BaoCaoDoanhThu baoCao = new frm_BaoCaoDoanhThu();
            baoCao.MdiParent = this; 
            baoCao.Show();
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            frm_QuanLySanPham sp = new frm_QuanLySanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void btn_QLNCC_Click(object sender, EventArgs e)
        {
            frm_QuanLyNhaCungCap ncc = new frm_QuanLyNhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void btn_BaoCaoKho_Click(object sender, EventArgs e)
        {
            frm_BaoCaoTonKho tk = new frm_BaoCaoTonKho();
            tk.MdiParent = this;
            tk.Show();
        }

        private void btn_NH_Click(object sender, EventArgs e)
        {
            frm_NhapKho nk = new frm_NhapKho();
            nk.MdiParent = this;
            nk.Show();
        }

        private void btn_XH_Click(object sender, EventArgs e)
        {
            frm_XuatKho xk = new frm_XuatKho();
            xk.MdiParent = this;
            xk.Show();
        }

        private void btn_KK_Click(object sender, EventArgs e)
        {
            frm_KiemKho kk = new frm_KiemKho();
            kk.MdiParent = this;
            kk.Show();
        }

        private void btn_TongDoanhThu_Click(object sender, EventArgs e)
        {
            frm_BaoCaoTongDoanhThu tdh = new frm_BaoCaoTongDoanhThu();
            tdh.MdiParent = this;
            tdh.Show();
        }

        private void btn_SPHM_Click(object sender, EventArgs e)
        {
            frm_BaoCaoSanPhamHayThatThoat sphm = new frm_BaoCaoSanPhamHayThatThoat();
            sphm.MdiParent = this;
            sphm.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RP_DanhSachChiNhanh frm = new frm_RP_DanhSachChiNhanh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maCH = Session.MaCuaHang;
            frm_RP_DanhSachNhanVien frm = new frm_RP_DanhSachNhanVien(maCH);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
