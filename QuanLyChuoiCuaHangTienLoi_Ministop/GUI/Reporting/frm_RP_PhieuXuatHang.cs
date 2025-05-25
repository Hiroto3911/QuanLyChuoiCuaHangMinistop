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
    public partial class frm_RP_PhieuXuatHang : Form
    {
        private string maXH;
        public frm_RP_PhieuXuatHang(string maNH)
        {
            InitializeComponent();
            this.maXH = maNH;
        }

        private void frm_RP_PhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument cryRpt = new ReportDocument();
                string reportPath = Path.Combine(Application.StartupPath, "Reporting", "RP_PhieuXuatHang.rpt");
				cryRpt.Load(reportPath);
				BUS_CrystalReportHelper.ApplyConnection(cryRpt);
                cryRpt.SetParameterValue("@MaPhieuXuat", maXH);
				crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }catch(Exception ex)
            {
				MessageBox.Show("Lỗi Crystal: " + ex.Message);
			}
        }
    }
}
