using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
using System.Net.Http.Headers;
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
        public List<string> LayDanhSachMaNVTheoVaiTro(string vaiTro)
        {

            return nv.LayDanhSachMaCHTheoVaiTro(vaiTro);

        }

        public List<ET_NhanVien> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            return nv.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        public bool Them(ET_NhanVien nhanVien)
        {
            return nv.Them(nhanVien);
        }
        public bool Xoa(string maMV)
        {
            return nv.Xoa(maMV);
        }
        public bool Sua(ET_NhanVien nhanVien)

        {
            return nv.Sua(nhanVien);
            

        }
      
    }
}
