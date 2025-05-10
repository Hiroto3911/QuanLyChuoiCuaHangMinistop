using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KiemKho
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        public List<ET_KiemKho> HienThiTatCa()
        {
            return db.KiemKhos.Select(k => new ET_KiemKho
            {
                MaKiemKho = k.MaKiemKho,
                MaCuaHang = k.MaCuaHang,
                MaNhanVien = k.MaNhanVien,
                NgayKiem = (DateTime)k.NgayKiem
            }).ToList();
        }

        public bool Them(ET_KiemKho kk)
        {
            try
            {
                db.KiemKhos.InsertOnSubmit(new KiemKho
                {
                    MaKiemKho = kk.MaKiemKho,
                    MaCuaHang = kk.MaCuaHang,
                    MaNhanVien = kk.MaNhanVien,
                    NgayKiem = kk.NgayKiem
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(string maKK)
        {
            var obj = db.KiemKhos.FirstOrDefault(k => k.MaKiemKho == maKK);
            if (obj == null) return false;
            db.KiemKhos.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }

        public bool Sua(ET_KiemKho kk)
        {
            var obj = db.KiemKhos.FirstOrDefault(k => k.MaKiemKho == kk.MaKiemKho);
            if (obj == null) return false;
            obj.MaCuaHang = kk.MaCuaHang;
            obj.MaNhanVien = kk.MaNhanVien;
            obj.NgayKiem = kk.NgayKiem;
            db.SubmitChanges();
            return true;
        }
    }
}
