using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietNhapHang
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        // Hiển thị tất cả chi tiết nhập hàng
        public List<ET_ChiTietNhapHang> HienThiTatCa()
        {
            return db.ChiTietNhapHangs.Select(ct => new ET_ChiTietNhapHang
            {
                MaPhieuNhap = ct.MaPhieuNhap,
                MaSanPham = ct.MaSanPham,
                SoLuong = (int)ct.SoLuong,
                GiaNhap = (decimal)ct.GiaNhap,
                TongTien = (decimal)ct.TongTien,
                GhiChu = ct.GhiChu
            }).ToList();
        }

        // Thêm chi tiết nhập hàng
        public bool Them(ET_ChiTietNhapHang ct)
        {
            try
            {
                db.ChiTietNhapHangs.InsertOnSubmit(new ChiTietNhapHang
                {
                    MaPhieuNhap = ct.MaPhieuNhap,
                    MaSanPham = ct.MaSanPham,
                    SoLuong = ct.SoLuong,
                    GiaNhap = ct.GiaNhap,
                    TongTien = (decimal)ct.TongTien,
                    GhiChu = ct.GhiChu
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        // Xoá một dòng chi tiết nhập (theo mã phiếu và mã sản phẩm)
        public bool Xoa(string maPhieuNhap, string maSanPham)
        {
            var obj = db.ChiTietNhapHangs.FirstOrDefault(ct => ct.MaPhieuNhap == maPhieuNhap && ct.MaSanPham == maSanPham);
            if (obj == null) return false;
            db.ChiTietNhapHangs.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }

        // Sửa chi tiết nhập hàng
        public bool Sua(ET_ChiTietNhapHang ct)
        {
            var obj = db.ChiTietNhapHangs.FirstOrDefault(x => x.MaPhieuNhap == ct.MaPhieuNhap && x.MaSanPham == ct.MaSanPham);
            if (obj == null) return false;
            obj.SoLuong = ct.SoLuong;
            obj.GiaNhap = ct.GiaNhap;
            //obj.TongTien = (decimal)ct.TongTien;
            obj.GhiChu = ct.GhiChu;
            db.SubmitChanges();
            return true;
        }

        // Lấy danh sách chi tiết theo mã phiếu nhập
        public List<ET_ChiTietNhapHang> LayChiTietTheoMaPhieu(string maPN)
        {
            return db.ChiTietNhapHangs
                     .Where(ct => ct.MaPhieuNhap == maPN)
                     .Select(ct => new ET_ChiTietNhapHang
                     {
                         MaPhieuNhap = ct.MaPhieuNhap,
                         MaSanPham = ct.MaSanPham,
                         SoLuong = (int)ct.SoLuong,
                         GiaNhap = (decimal)ct.GiaNhap,
                         TongTien = (decimal)ct.TongTien,
                         GhiChu = ct.GhiChu
                     }).ToList();
        }
    }
}
