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
    public partial class frm_RP_HoaDon : Form
    {
        private string maHD;
        public frm_RP_HoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void frm_RP_HoaDon_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            string reportPath = Path.Combine(Application.StartupPath, "Reporting", "RP_HoaDon.rpt");
            cryRpt.Load(reportPath);

            cryRpt.SetParameterValue("@MaHoaDon", maHD);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
