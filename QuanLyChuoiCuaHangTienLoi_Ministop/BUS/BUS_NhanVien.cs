using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        public ET_NhanVien TimNhanVienDuaTrenTaiKhoanDangNhap(string vaiTro, string taiKhoan, string matKhau)
        {
            return nv.TimNhanVienDuaTrenTaiKhoanDangNhap(vaiTro,taiKhoan,matKhau);
        }
        public List<string> LayDanhSachMaNV()
        {
            
            return nv.LayDanhSachMaNV();
        }
    }
}
