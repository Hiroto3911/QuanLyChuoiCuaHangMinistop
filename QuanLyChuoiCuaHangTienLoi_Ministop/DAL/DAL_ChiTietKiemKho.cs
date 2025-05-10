using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietKiemKho
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        public List<ET_ChiTietKiemKho> LayChiTietTheoPhieu(string maKK)
        {
            return db.ChiTietKiemKhos
                .Where(c => c.MaKiemKho == maKK)
                .Select(c => new ET_ChiTietKiemKho
                {
                    MaKiemKho = c.MaKiemKho,
                    MaSanPham = c.MaSanPham,
                    SoLuongHeThong = (int)c.SoLuongHeThong,
                    SoLuongThucTe = (int)c.SoLuongThucTe,
                    TrangThai = c.TrangThai,
                    ChenhLech = (int)c.ChenhLech,
                    GhiChu = c.GhiChu
                }).ToList();
        }

        public bool Them(ET_ChiTietKiemKho ct)
        {
            try
            {
                db.ChiTietKiemKhos.InsertOnSubmit(new ChiTietKiemKho
                {
                    MaKiemKho = ct.MaKiemKho,
                    MaSanPham = ct.MaSanPham,
                    SoLuongHeThong = ct.SoLuongHeThong,
                    SoLuongThucTe = ct.SoLuongThucTe,
                    TrangThai = ct.TrangThai,
                    ChenhLech = ct.ChenhLech,
                    GhiChu = ct.GhiChu
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(string maKK, string maSP)
        {
            var obj = db.ChiTietKiemKhos.FirstOrDefault(c => c.MaKiemKho == maKK && c.MaSanPham == maSP);
            if (obj == null) return false;
            db.ChiTietKiemKhos.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }

        public bool Sua(ET_ChiTietKiemKho ct)
        {
            var obj = db.ChiTietKiemKhos.FirstOrDefault(c => c.MaKiemKho == ct.MaKiemKho && c.MaSanPham == ct.MaSanPham);
            if (obj == null) return false;
            obj.SoLuongHeThong = ct.SoLuongHeThong;
            obj.SoLuongThucTe = ct.SoLuongThucTe;
            obj.TrangThai = ct.TrangThai;
            obj.ChenhLech = ct.ChenhLech;
            obj.GhiChu = ct.GhiChu;
            db.SubmitChanges();
            return true;
        }
    }

}
