using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
namespace BUS
{
    public class BUS_DangNhap
    {
        private DAL_DangNhap dn = new DAL_DangNhap();
        public bool KiemTraDangNhap(string taiKhoan, string matKhau, string vaiTro)
        {
            return dn.KiemTraDangNhap(taiKhoan, matKhau, vaiTro);

        }
    }
}
