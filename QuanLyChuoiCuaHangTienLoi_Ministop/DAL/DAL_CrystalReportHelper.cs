using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace DAL
{
	public static class DAL_CrystalReportHelper
	{

		public static void ApplyConnection(ReportDocument report)
		{
			string connStr = DAL_DBConnect.GetConnectionString();
			var builder = new SqlConnectionStringBuilder(connStr);

			ConnectionInfo info = new ConnectionInfo
			{
				ServerName = builder.DataSource,
				DatabaseName = builder.InitialCatalog,
				IntegratedSecurity = builder.IntegratedSecurity
			};

			if (!builder.IntegratedSecurity)
			{
				info.UserID = builder.UserID;
				info.Password = builder.Password;
			}

			try
			{
				ApplyConnectionToTables(report.Database.Tables, info);
			}
			catch (Exception ex)
			{
				throw new ApplicationException("Lỗi khi áp dụng thông tin kết nối cho report chính", ex);
			}

			// Xử lý subreport nếu có
			foreach (CrystalDecisions.CrystalReports.Engine.Section section in report.ReportDefinition.Sections)
			{
				foreach (ReportObject obj in section.ReportObjects)
				{
					if (obj is SubreportObject sub)
					{
						try
						{
							var subreport = report.Subreports[sub.SubreportName];
							ApplyConnectionToTables(subreport.Database.Tables, info);
						}
						catch (Exception ex)
						{
							throw new ApplicationException($"Lỗi khi áp dụng kết nối cho subreport: {sub.SubreportName}", ex);
						}
					}
				}
			}
		}

		private static void ApplyConnectionToTables(Tables tables, ConnectionInfo connectionInfo)
		{
			foreach (Table table in tables)
			{
				TableLogOnInfo logon = table.LogOnInfo;
				logon.ConnectionInfo = connectionInfo;
				table.ApplyLogOnInfo(logon);

				// Nếu là stored procedure, cần giữ nguyên schema và tên procedure
				if (table.Name.EndsWith(";1") || table.Name.Contains("@") || table.Name.Contains("sp_"))
				{
					// Không thay đổi Location, tránh lỗi mất định danh
					continue;
				}

				// Nếu bảng có schema (vd: dbo.MyTable), thì giữ nguyên
				if (table.Location.Contains("."))
				{
					// Không thay đổi location
					continue;
				}

				// Nếu không có schema, có thể gán tên để tránh lỗi tên ngắn
				table.Location = table.Name;
			}
		}



	}
}
