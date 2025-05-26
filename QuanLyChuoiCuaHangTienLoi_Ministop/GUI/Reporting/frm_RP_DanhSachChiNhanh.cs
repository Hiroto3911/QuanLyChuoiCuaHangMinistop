using BUS;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Reporting
{
    public partial class frm_RP_DanhSachChiNhanh : Form
    {
        public frm_RP_DanhSachChiNhanh()
        {
            InitializeComponent();
        }

        private void frm_RP_DanhSachChiNhanh_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "Reporting", "RP_DanhSachChiNhanh.rpt");
                cryRpt.Load(reportPath);
                BUS_CrystalReportHelper.ApplyConnection(cryRpt);
                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }catch(Exception ex)
            {
				MessageBox.Show("Lỗi Crystal: " + ex.Message);
			}
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
