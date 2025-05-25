using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KiemKho
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = DB_Context_Custom.getDataContext();
        public List<ET_KiemKho> HienThiDuLieuTheoMaCH(string maCH)
        {
            return db.KiemKhos.Where(pn => pn.MaCuaHang == maCH).Select(p => new ET_KiemKho
            {
                MaKiemKho = p.MaKiemKho,
                MaCuaHang = p.MaCuaHang,
                NgayKiem = Convert.ToDateTime(p.NgayKiem),
                MaNhanVien = p.MaNhanVien
            }).OrderByDescending(nh => nh.MaKiemKho).ToList();
        }

        public bool Them(ET_KiemKho kk)
        {
            if (kk == null) return false;
            try
            {
                db.KiemKhos.InsertOnSubmit(new KiemKho
                {
                    MaKiemKho  = kk.MaKiemKho,
                    MaCuaHang = kk.MaCuaHang,
                    NgayKiem = kk.NgayKiem,
                    MaNhanVien = kk.MaNhanVien
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(string maCH, string maKK)
        {
            var obj = db.KiemKhos.Where(p => p.MaCuaHang == maCH && p.MaKiemKho == maKK).FirstOrDefault();
            if (obj == null) return false;
            db.KiemKhos.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }

        public List<string> LayDanhSachMaKK()
        {
            var danhSachID = db.KiemKhos.Select(id => id.MaKiemKho).ToList();
            return danhSachID;
        }
    }
}
