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
    }
}
