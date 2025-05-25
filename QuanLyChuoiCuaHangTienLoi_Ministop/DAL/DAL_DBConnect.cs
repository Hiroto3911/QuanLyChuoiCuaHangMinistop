using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private static void ExecuteSqlScript(string connectionString, string resourceName, Assembly sourceAssembly)
        {
            using (Stream stream = sourceAssembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string script = reader.ReadToEnd();
                var batches = script.Split(new[] { "GO", "Go", "go" }, StringSplitOptions.RemoveEmptyEntries);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (var batch in batches)
                    {
                        if (!string.IsNullOrWhiteSpace(batch))
                        {
                            using (SqlCommand cmd = new SqlCommand(batch, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Executed: " + resourceName);
        }

        public static bool RunAllScripts(string connectionString)
        {
			try
			{
                // Reference the DAL assembly using any known type in DAL
                var assembly = typeof(DAL.DAL_CuaHang).Assembly;

                string[] resourceNames = {
                "DAL.SQL.CSDL_QuanLyChuoiCuaHangTienLoiMinistop.sql",
                "DAL.SQL.DL_QuanLyChuoiCuaHangTienLoiMinistop.sql",
                "DAL.SQL.SP_TaoPhieu.sql"
                };

                foreach (var resource in resourceNames)
                {
                    ExecuteSqlScript(connectionString, resource, assembly);
                }

                Console.WriteLine("✅ All scripts executed.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi chạy script: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckDatabaseExists(string serverConnStr, string dbName)
        {
            try
            {
                using (var conn = new SqlConnection(serverConnStr))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand($"SELECT db_id('{dbName}')", conn))
                    {
                        return cmd.ExecuteScalar() != DBNull.Value;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
