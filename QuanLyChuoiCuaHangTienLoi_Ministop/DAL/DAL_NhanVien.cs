using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
namespace DAL
{
    public class DAL_NhanVien
    {

        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        public ET_NhanVien TimNhanVienDuaTrenTaiKhoanDangNhap(string vaiTro, string taiKhoan, string matKhau)
        {
            var kq = db.NhanViens.Where(nv => nv.VaiTro == vaiTro && nv.TaiKhoan == taiKhoan &&  nv.MatKhau == SimpleHash.hash(matKhau)).FirstOrDefault();
            if (kq == null) return null;
            var nhanVien = new ET.ET_NhanVien
            {
                MaNV = kq.MaNhanVien,
                HoTen = kq.HoTen,
                GioiTinh = kq.GioiTinh,
                NgaySinh = Convert.ToDateTime(kq.NgaySinh),
                SoDienThoai = kq.SoDienThoai,
                NgayLamViec = Convert.ToDateTime(kq.NgayLamViec),
                TaiKhoan = kq.TaiKhoan,
                MatKhau = kq.MatKhau,
                VaiTro = kq.VaiTro,
                MaCuaHang = kq.MaCuaHang
            };
            return nhanVien;
        }

        public List<string> LayDanhSachMaNV()
        {
            var danhSachID = db.NhanViens.Select(id => id.MaNhanVien).ToList();
            return danhSachID;
        }
    }
}
