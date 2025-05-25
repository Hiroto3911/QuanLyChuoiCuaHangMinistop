using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
	public class DAL_DBConnect
	{
		private static string stringPath = Path.Combine(Application.StartupPath, "connection.txt");
		public static string GetConnectionString()
		{
			if (!File.Exists(stringPath)) {
			   return null;
			}
			return File.ReadAllText(stringPath).Trim();
		}

		public static void SetConnectionString(string connstr)
		{
			File.WriteAllText(stringPath, connstr.Trim());
		}
		/// <summary>
		/// Hàm kiểm tra chuỗi kết nối xem có thành công hay không
		/// </summary>
		/// <param name="connstr">chuỗi kết nối</param>
		/// <returns>trả về true nếu kết nối thành công và ngược lại</returns>
		public static bool TestConnectionString(string connstr)
		{
			try
			{
				using (var conn = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext(connstr))
				{
					conn.Connection.Open();
					conn.Connection.Close();
					return true;
				}
			}
			catch
			{
			  return false;
			}
		}
	}
}
