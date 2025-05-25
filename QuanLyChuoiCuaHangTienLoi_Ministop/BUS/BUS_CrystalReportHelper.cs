using CrystalDecisions.CrystalReports.Engine;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public static class BUS_CrystalReportHelper
	{
		public static void ApplyConnection(ReportDocument report)
		{
			DAL_CrystalReportHelper.ApplyConnection(report);
		}
	}
}
