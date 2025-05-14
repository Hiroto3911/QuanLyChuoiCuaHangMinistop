using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietKiemKho
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        public List<ET_ChiTietKiemKho> LayChiTietTheoMaPhieu(string maKK)
        {
            return db.ChiTietKiemKhos
                     .Where(ct => ct.MaKiemKho == maKK)
                     .Select(ct => new ET_ChiTietKiemKho
                     {
                         MaKiemKho = ct.MaKiemKho,
                         MaSanPham = ct.MaSanPham,
                         SoLuongHeThong = (int)ct.SoLuongHeThong,
                         SoLuongThucTe = (int)ct.SoLuongThucTe,
                         TrangThai = ct.TrangThai,
                         ChenhLech = (int)ct.ChenhLech,
                         GhiChu = ct.GhiChu
                     }).ToList();
        }
        public bool Them(ET_ChiTietKiemKho ct)
        {
            if (ct == null) return false;
            try
            {
                db.ChiTietKiemKhos.InsertOnSubmit(new ChiTietKiemKho
                {

                    MaKiemKho = ct.MaKiemKho,
                    MaSanPham = ct.MaSanPham,
                    SoLuongHeThong = ct.SoLuongHeThong,
                    SoLuongThucTe = (int)ct.SoLuongThucTe,
                    TrangThai = ct.TrangThai,
                    ChenhLech = (int)ct.ChenhLech,
                    GhiChu = ct.GhiChu
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Sua(ET_ChiTietKiemKho ct)
        {
            if (ct == null) return false;
            try
            {
                var obj = db.ChiTietKiemKhos.Where(p => p.MaKiemKho == ct.MaKiemKho && p.MaSanPham == ct.MaSanPham).FirstOrDefault();
                if (obj == null) return false;
                obj.SoLuongThucTe = ct.SoLuongThucTe;
                obj.ChenhLech = ct.ChenhLech;
                obj.TrangThai = ct.TrangThai;
                obj.GhiChu = ct.GhiChu;

                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Xoa(string maKK, string maSP)
        {
            var obj = db.ChiTietKiemKhos.Where(p => p.MaKiemKho == maKK && p.MaSanPham == maSP).FirstOrDefault();
            if (obj == null) return false;
            db.ChiTietKiemKhos.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }


    }
}
