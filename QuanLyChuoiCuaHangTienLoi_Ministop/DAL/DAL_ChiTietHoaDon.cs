using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDon
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_ChiTietHoaDon> HienThiDuLieuSapXepGiamDanTheoMaHD(string maHD)
        {
            var query = db.ChiTietHoaDons.Where(ma => ma.MaHoaDon == maHD).OrderByDescending(ma => ma.MaChiTietHD).ToList();
            List<ET_ChiTietHoaDon> ds = new List<ET_ChiTietHoaDon>();
            foreach(var item in query)
            {
                ds.Add(new ET_ChiTietHoaDon
                {
                    MaChiTietHD = item.MaChiTietHD,
                    MaHoaDon = item.MaHoaDon,
                    MaSanPham = item.MaSanPham,
                    SoLuong =(int) item.SoLuong,
                    GiaBan = (decimal)item.GiaBan,
                    ThanhTien =(decimal)item.ThanhTien 
                });
            }
            return ds;
        }
        public bool Them(ET_ChiTietHoaDon chiTietHD)
        {
            if (chiTietHD == null) return false;
            var check = db.ChiTietHoaDons.Where(cthd => cthd.MaHoaDon == chiTietHD.MaHoaDon && cthd.MaSanPham == chiTietHD.MaSanPham).FirstOrDefault();
            if (check != null)
            {
                check.SoLuong += chiTietHD.SoLuong; 
                //check.ThanhTien = check.SoLuong * check.GiaBan;
                db.SubmitChanges();
                return true;
            }
            else
            {
                try
                {
                    ChiTietHoaDon cthd = new ChiTietHoaDon()
                    {
                        MaChiTietHD = chiTietHD.MaChiTietHD,
                        MaHoaDon = chiTietHD.MaHoaDon,
                        MaSanPham = chiTietHD.MaSanPham,
                        SoLuong = chiTietHD.SoLuong,
                        GiaBan = (decimal?)chiTietHD.GiaBan,
                    };
                    db.ChiTietHoaDons.InsertOnSubmit(cthd);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception ex) { throw ex; }
            }
           
        }

        public bool Sua(ET_ChiTietHoaDon chiTietHD)
        {
            if (chiTietHD == null) return false;
            try
            {
                var capNhap = TimChiTietHoaDonBangMaHD(chiTietHD.MaChiTietHD);
                capNhap.SoLuong = chiTietHD.SoLuong;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Xoa(string maCTHD)
        {
            if (string.IsNullOrWhiteSpace(maCTHD)) return false;
            try
            {
                var del = TimChiTietHoaDonBangMaHD(maCTHD);
                if (del == null) return false;
                db.ChiTietHoaDons.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public ChiTietHoaDon TimChiTietHoaDonBangMaHD(string maCTHD)
        {
            var kq = db.ChiTietHoaDons.Where(n => n.MaChiTietHD == maCTHD).FirstOrDefault();
            return kq;
        }
      
        public List<string> LayDanhSachMaCTHD()
        {
            var danhSachID = db.ChiTietHoaDons.Select(id => id.MaChiTietHD).ToList();
            return danhSachID;
        }
        public decimal TinhTongTienTheoMaHD(string maHD)
        {
            var query = db.ChiTietHoaDons.Where(cthd => cthd.MaHoaDon == maHD).Sum(cthd => cthd.ThanhTien);
            if(query == null) return 0;
            return (decimal)query; 
        }

    }
}
