using BUS;
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
    public partial class frm_ChiTietKho : Form
    {
        public frm_ChiTietKho()
        {
            InitializeComponent();
        }
        private BUS_ChiTietKho bus_ChiTietKho = new BUS_ChiTietKho();
        private BUS_CuaHang bus_CuaHang = new BUS_CuaHang();
        private BUS_SanPham bus_SanPham = new BUS_SanPham();
        private BUS_LichSuKho bus_LichSuKho = new BUS_LichSuKho();

        private void frm_ChiTietKho_Load(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_LamMoiChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
