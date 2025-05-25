using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public static class DB_Context_Custom
	{
		public static DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext getDataContext()
		{
			return new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext(DAL_DBConnect.GetConnectionString());
		}
	}
}
