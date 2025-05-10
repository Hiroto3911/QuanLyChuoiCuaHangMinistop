using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhapHang
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_NhapHang> HienThiDuLieuTheoMaCH(string maCH)
        {
            return db.PhieuNhaps.Where(pn=> pn.MaCuaHang == maCH).Select(p => new ET_NhapHang
            {
                MaPhieuNhap = p.MaPhieuNhap,
                MaNcc = p.MaNCC,
                MaCuaHang = p.MaCuaHang,
                NgayNhap = Convert.ToDateTime(p.NgayNhap),
                MaNhanVien = p.MaNhanVien
            }).OrderByDescending(nh => nh.MaPhieuNhap).ToList();
        }

        public bool Them(ET_NhapHang pn)
        {
            try
            {
                db.PhieuNhaps.InsertOnSubmit(new PhieuNhap
                {
                    MaPhieuNhap = pn.MaPhieuNhap,
                    MaNCC = pn.MaNcc,
                    MaCuaHang = pn.MaCuaHang,
                    NgayNhap = pn.NgayNhap,
                    MaNhanVien = pn.MaNhanVien
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(string maPN)
        {
            var obj = db.PhieuNhaps.FirstOrDefault(p => p.MaPhieuNhap == maPN);
            if (obj == null) return false;
            db.PhieuNhaps.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }

        public bool Sua(ET_NhapHang pn)
        {
            var obj = db.PhieuNhaps.FirstOrDefault(p => p.MaPhieuNhap == pn.MaPhieuNhap);
            if (obj == null) return false;
            obj.MaNCC = pn.MaNcc;
            obj.MaCuaHang = pn.MaCuaHang;
            obj.NgayNhap = pn.NgayNhap;
            obj.MaNhanVien = pn.MaNhanVien;
            db.SubmitChanges();
            return true;
        }
        public List<string> LayDanhSachMaNH()
        {
            var danhSachID = db.PhieuNhaps.Select(id => id.MaPhieuNhap).ToList();
            return danhSachID;
        }
    }
}
