using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class Session
    {
        public static string MaNhanVien {  get; set; }
        public static string VaiTro {  get; set; }
        public static string HoTen {  get; set; }
        public static string MaCuaHang { get; set; }    
        public static void DangThoat()
        {
            MaNhanVien = null;
            VaiTro = null;
            HoTen = null;
            MaCuaHang = null;   
        }
    }
}
