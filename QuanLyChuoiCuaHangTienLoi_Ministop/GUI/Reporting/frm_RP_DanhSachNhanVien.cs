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
    public partial class frm_RP_DanhSachNhanVien : Form
    {
        private string maCH;
        public frm_RP_DanhSachNhanVien(string maCH)
        {
            InitializeComponent();
            this.maCH = maCH;
        }

        private void frm_RP_DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            string reportPath = Path.Combine(Application.StartupPath, "Reporting", "RP_DanhSachNhanVien.rpt");
            cryRpt.Load(reportPath);

            cryRpt.SetParameterValue("@MaCuaHang", maCH);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
