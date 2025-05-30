﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public static class BUS_DBConnect
	{
		public static string GetConnectionString()
		{
			return DAL_DBConnect.GetConnectionString();
		}

		public static void SetConnectionString(string connstr)
		{
			 DAL_DBConnect.SetConnectionString(connstr);
		}
		
		public static bool TestConnectionString(string connstr)
		{
			return DAL_DBConnect.TestConnectionString(connstr);
		}
	}
}
