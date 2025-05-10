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

namespace GUI
{
    public partial class frm_RP_PhieuNhap : Form
    {
        public frm_RP_PhieuNhap()
        {
            InitializeComponent();
        }

        private string maNH;
        public frm_RP_PhieuNhap(string maNH)
        {
            InitializeComponent();
            this.maNH = maNH;
        }

        private void frm_RP_PhieuNhap_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            string reportPath = Path.Combine(Application.StartupPath, "Reporting", "RP_PhieuNhapHang.rpt");
            cryRpt.Load(reportPath);

            cryRpt.SetParameterValue("@MaPhieuNhap", maNH);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
