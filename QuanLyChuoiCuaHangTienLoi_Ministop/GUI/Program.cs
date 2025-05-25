using BUS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (string.IsNullOrEmpty(BUS_DBConnect.GetConnectionString()) || !BUS_DBConnect.TestConnectionString(connstr: BUS_DBConnect.GetConnectionString()))
			{

                frm_ThayDoiChuoiSQLServer thayDoiForm = new frm_ThayDoiChuoiSQLServer();
				if (thayDoiForm.ShowDialog() != DialogResult.OK)
				{
					MessageBox.Show("Không thể kết nối CSDL. Ứng dụng sẽ thoát.");
					return;
				}
			
               
            }
            Application.Run(new frm_DangNhap());
        }
    }
}
