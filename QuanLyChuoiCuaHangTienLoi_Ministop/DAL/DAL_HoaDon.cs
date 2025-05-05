using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_HoaDon
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_HoaDon> HienThiDuLieuMotCHSapXepGiamDanTheoMa(string maCH)
        {
            
            var query = db.HoaDons.Where(ma=> ma.MaCuaHang == maCH).OrderByDescending(ma => ma.MaHoaDon).ToList();
            List<ET_HoaDon>ds = new List<ET_HoaDon>();
            foreach (var item in query) {
                ds.Add(new ET_HoaDon
                {
                    MaCuaHang = item.MaCuaHang,
                    MaHoaDon = item.MaHoaDon,
                    MaNhanVien = item.MaNhanVien,
                    NgayLap = Convert.ToDateTime(item.NgayLap),
                    TongTien = (decimal)item.TongTien,
                });
            }
            return ds;
        }
        public bool Them(ET_HoaDon hoaDon)
        {
            if (hoaDon == null) return false;
            try
            {
                HoaDon hd = new HoaDon()
                {
                    MaHoaDon = hoaDon.MaHoaDon,
                    MaCuaHang = hoaDon.MaCuaHang,
                    MaNhanVien = hoaDon.MaNhanVien,
                    NgayLap = hoaDon.NgayLap,
                    TongTien = (decimal)hoaDon.TongTien
                };
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;    
            }
            catch (Exception ex) { throw ex; }
        }
       
        public bool Xoa(string maHD)
        {
            if (string.IsNullOrWhiteSpace(maHD)) return false;
            try
            {
                var del = TimHoaDonBangMaHD(maHD);
                if (del == null) return false;
                db.HoaDons.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_HoaDon hd)
        {
            if (hd == null) return false;
            try
            {
                var capNhap = TimHoaDonBangMaHD(hd.MaHoaDon);
                capNhap.TongTien = (decimal)hd.TongTien;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public HoaDon TimHoaDonBangMaHD(string maHD)
        {
            var kq = db.HoaDons.Where(n => n.MaHoaDon == maHD).FirstOrDefault();
            return kq;  
        }
        public List<string> LayDanhSachMaHD()
        {
            var danhSachID = db.HoaDons.Select(id => id.MaHoaDon).ToList();
            return danhSachID;
        }
    }
}
