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
        public List<ET_NhanVien> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            var query = db.NhanViens.OrderByDescending(ma => ma.MaNhanVien).ToList();
            List<ET_NhanVien> ds = new List<ET_NhanVien>();
            foreach (var item in query)
            {
                ds.Add(new ET_NhanVien
                {
                   
                    MaNV = item.MaNhanVien,
                    HoTen = item.HoTen,
                    GioiTinh = item.GioiTinh,
                    NgaySinh = (DateTime)item.NgaySinh,
                    SoDienThoai = item.SoDienThoai,
                    
                    NgayLamViec = (DateTime)item.NgayLamViec,
                    TaiKhoan = item.TaiKhoan,
                    MatKhau = item.MatKhau,
                    VaiTro = item.VaiTro,
                     MaCuaHang = item.MaCuaHang
                });
            }
            return ds;
        }
        public List<string> LayDanhSachMaNV()
        {
            var danhSachID = db.NhanViens.Select(id => id.MaNhanVien).ToList();
            return danhSachID;
        }
        public List<string> LayDanhSachMaCHTheoVaiTro(string vaiTro)
        {
            var danhSachID = db.NhanViens.Where(nv => nv.VaiTro == vaiTro).Select(id => id.MaNhanVien).ToList();
            return danhSachID;
        }

        public bool Them(ET_NhanVien nhanVien)
        {
            if (nhanVien == null) return false;
            try
            {
                NhanVien ch = new NhanVien()
                {

                    MaCuaHang = nhanVien.MaCuaHang,
                    MaNhanVien = nhanVien.MaNV,
                    HoTen = nhanVien.HoTen,
                    NgaySinh = nhanVien.NgaySinh,
                    GioiTinh = nhanVien.GioiTinh,
                    NgayLamViec = nhanVien.NgayLamViec,
                    TaiKhoan = nhanVien.TaiKhoan,
                    MatKhau = nhanVien.MatKhau,
                    VaiTro = nhanVien.VaiTro
                };
                db.NhanViens.InsertOnSubmit(ch);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Xoa(string maMV)
        {
            if (string.IsNullOrWhiteSpace(maMV)) return false;
            try
            {
                var del = TimCuaHangBangMaNV(maMV);
                if (del == null) return false;
                db.NhanViens.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_NhanVien nhanVien)

        {

            if (nhanVien == null) return false;
            try
            {
                var capNhat = TimCuaHangBangMaNV(nhanVien.MaNV);
                if (capNhat == null) return false;
                capNhat.MaCuaHang = nhanVien.MaCuaHang;
               
                capNhat.HoTen = nhanVien.HoTen;
                capNhat.NgaySinh = nhanVien.NgaySinh;
                capNhat.GioiTinh = nhanVien.GioiTinh;
                capNhat.NgayLamViec = nhanVien.NgayLamViec;
                capNhat.TaiKhoan = nhanVien.TaiKhoan;
                capNhat.MatKhau = nhanVien.MatKhau;
                capNhat.VaiTro = nhanVien.VaiTro;
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {


                throw ex;

            }

        }
        public NhanVien TimCuaHangBangMaNV(string maNV)
        {
            var kq = db.NhanViens.Where(n => n.MaNhanVien == maNV).FirstOrDefault();
            return kq;
        }
        
    }
}
