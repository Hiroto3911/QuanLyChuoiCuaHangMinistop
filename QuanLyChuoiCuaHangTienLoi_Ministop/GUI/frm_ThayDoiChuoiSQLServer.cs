using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
	public partial class frm_ThayDoiChuoiSQLServer : Form
	{
		
		public frm_ThayDoiChuoiSQLServer()
		{
			InitializeComponent();
		}

		private void frm_ThayDoiChuoiSQLServer_Load(object sender, EventArgs e)
		{
			cbo_Authentication.DataSource = new List<string>() {"Windows Authentication","SQL Server Authentication"};
			cbo_DataBaseName.DataSource = new List<string>() { "QuanLyChuoiCuaHangMinistop" };
		}

		private void btn_Ok_Click(object sender, EventArgs e)
		{

			string fullConnStr = LayChuoiKetNoi(); // With Initial Catalog = your database
			string serverOnlyConnStr = LayChuoiKetNoiServerOnly(); // Just connects to master

			if (string.IsNullOrEmpty(fullConnStr) || string.IsNullOrEmpty(serverOnlyConnStr))
			{
				MessageBox.Show("Thiếu thông tin kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string dbName = cbo_DataBaseName.Text.Trim();

			if (!BUS_DBConnect.Check(serverOnlyConnStr, dbName))
			{
				if (BUS_DBConnect.CreatingDatabase(serverOnlyConnStr))
				{
					MessageBox.Show("✅ Tạo database và dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("❌ Lỗi khi tạo database hoặc dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else
			{
				MessageBox.Show("⚠ Database đã tồn tại. Bỏ qua bước tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			if (!BUS_DBConnect.TestConnectionString(fullConnStr))
			{
				MessageBox.Show("❌ Kết nối thất bại sau khi tạo database.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			BUS_DBConnect.SetConnectionString(fullConnStr);
			MessageBox.Show("✅ Kết nối thành công và đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.DialogResult = DialogResult.OK;

		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_TestConnection_Click(object sender, EventArgs e)
		{
			string connstr = LayChuoiKetNoi();
			if (!BUS_DBConnect.TestConnectionString(connstr))
			{
				MessageBox.Show("Kết nối thất bại", "Thông báo");
				return;
			}
			MessageBox.Show("Kết nối thành công", "Thông báo");
		}

		private void cbo_Authentication_SelectedValueChanged(object sender, EventArgs e)
		{
			if(cbo_Authentication.SelectedItem == "Windows Authentication")
			{
				txt_UserName.Enabled = false; txt_Password.Enabled = false;
			}
			else if(cbo_Authentication.SelectedItem == "SQL Server Authentication")
			{
				txt_UserName.Enabled = true; txt_Password.Enabled = true;
			}
		}

		private void frm_ThayDoiChuoiSQLServer_FormClosing(object sender, FormClosingEventArgs e)
		{
			//var rs = MessageBox.Show("Bạn có chắc muốn thoát","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
			//if(rs== DialogResult.Cancel) e.Cancel = false;
		}
		/// <summary>
		///  Hàm giúp lấy chuỗi kết nối mới  
		/// </summary>
		/// <returns>chuỗi kết nối mới hoặc null nếu thiếu thông tin </returns>
		private string LayChuoiKetNoi ()
		{
			string serverName = txt_ServerName.Text.Trim();
			string dataBaseName = cbo_DataBaseName.Text.Trim();
			if (string.IsNullOrEmpty(serverName) || string.IsNullOrEmpty(dataBaseName)) return null;
			if (cbo_Authentication.SelectedItem == "Windows Authentication")
			{
				return  $"Data Source={serverName};Initial Catalog={dataBaseName};Integrated Security=True;";


			}
			else if (cbo_Authentication.SelectedItem == "SQL Server Authentication")
			{
				string userName = txt_UserName.Text.Trim();
				string password = txt_Password.Text.Trim();
				if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password)) return null; 
				return  $"Data Source={serverName};Initial Catalog={dataBaseName};User Id={userName};Password={password};";

			}
			return null;	
		}
		private string LayChuoiKetNoiServerOnly()
		{
			string serverName = txt_ServerName.Text.Trim();
			if (string.IsNullOrEmpty(serverName)) return null;

			if (cbo_Authentication.SelectedItem == "Windows Authentication")
			{
				return $"Data Source={serverName};Initial Catalog=master;Integrated Security=True;";
			}
			else if (cbo_Authentication.SelectedItem == "SQL Server Authentication")
			{
				string userName = txt_UserName.Text.Trim();
				string password = txt_Password.Text.Trim();
				if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password)) return null;
				return $"Data Source={serverName};Initial Catalog=master;User Id={userName};Password={password};";
			}
			return null;
		}
	}
}
