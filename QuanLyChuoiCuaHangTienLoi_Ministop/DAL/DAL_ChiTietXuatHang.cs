using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietXuatHang
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = DB_Context_Custom.getDataContext();

        public List<ET_ChiTietXuatHang> HienThiTatCa()
        {
            return db.ChiTietXuatHangs.Select(ct => new ET_ChiTietXuatHang
            {
                MaPhieuXuat = ct.MaPhieuXuat,
                MaSanPham = ct.MaSanPham,
                SoLuong = (int)ct.SoLuong,
                GiaXuat = (double)ct.GiaXuat,
                TongTien = (double)ct.TongTien,
                GhiChu = ct.GhiChu
            }).ToList();
        }

        public List<ET_ChiTietXuatHang> LayChiTietTheoMaPhieu(string maPhieuXuat)
        {
            return db.ChiTietXuatHangs.Where(ct => ct.MaPhieuXuat == maPhieuXuat).Select(ct => new ET_ChiTietXuatHang
            {
                MaPhieuXuat = ct.MaPhieuXuat,
                MaSanPham = ct.MaSanPham,
                SoLuong = (int)ct.SoLuong,
                GiaXuat = (double)ct.GiaXuat,
                TongTien = (double)ct.TongTien,
                GhiChu = ct.GhiChu
            }).ToList();
        }

        public bool Them(ET_ChiTietXuatHang ct)
        {
            try
            {
                db.ChiTietXuatHangs.InsertOnSubmit(new ChiTietXuatHang
                {
                    MaPhieuXuat = ct.MaPhieuXuat,
                    MaSanPham = ct.MaSanPham,
                    SoLuong = ct.SoLuong,
                    GiaXuat = (decimal)ct.GiaXuat,
                    TongTien = (decimal)ct.TongTien,
                    GhiChu = ct.GhiChu
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Sua(ET_ChiTietXuatHang ct)
        {
            var obj = db.ChiTietXuatHangs.FirstOrDefault(x => x.MaPhieuXuat == ct.MaPhieuXuat && x.MaSanPham == ct.MaSanPham);
            if (obj == null) return false;
            obj.SoLuong = ct.SoLuong;
            obj.GiaXuat = (decimal)ct.GiaXuat;
            //obj.TongTien = (decimal)ct.TongTien;
            obj.GhiChu = ct.GhiChu;
            db.SubmitChanges();
            return true;
        }

        public bool Xoa(string maPhieu, string maSanPham)
        {
            var obj = db.ChiTietXuatHangs.FirstOrDefault(x => x.MaPhieuXuat == maPhieu && x.MaSanPham == maSanPham);
            if (obj == null) return false;
            db.ChiTietXuatHangs.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }
    }
}
