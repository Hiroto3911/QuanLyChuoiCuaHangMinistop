using ET;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BaoCao
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_DoanhThuCuaHangTheoThang> BaoCaoDoanhThuCuaHangTheoThang(string maCH = null)
        {
            var ds = db.HoaDons
                .Where(hd => maCH == null || hd.MaCuaHang == maCH)
                .SelectMany(hd => hd.ChiTietHoaDons, (hd, ct) => new
                {
                    hd.NgayLap,
                    hd.MaCuaHang,
                    hd.CuaHang.TenCuaHang,
                    ct.ThanhTien
                })
                .GroupBy(x => new
                {
                    x.NgayLap.Value.Year,
                    x.NgayLap.Value.Month,
                    x.MaCuaHang,
                    x.TenCuaHang
                })
                .Select(g => new ET_DoanhThuCuaHangTheoThang
                {
                    Nam = g.Key.Year,
                    Thang = g.Key.Month,
                    TenCH = g.Key.TenCuaHang,
                    MaCH = g.Key.MaCuaHang,
                    DoanhThu = (decimal)g.Sum(x => x.ThanhTien)
                }).OrderBy(x => x.Nam).ThenBy(x => x.Thang).ToList();
            return ds;

        }
        public List<ET_TongDoanhThu> TongDoanhThuTheoThang()
        {
            var ds = db.HoaDons
                .SelectMany(hd => hd.ChiTietHoaDons , (hd , ct)=> new
                {
                    hd.NgayLap,
                    hd.MaCuaHang,
                    ct.ThanhTien 
                })
                .GroupBy(x => new
                {
                    x.NgayLap.Value.Year,
                    x.NgayLap.Value.Month
                })
                .Select( g => new ET_TongDoanhThu
                {
                    Nam = g.Key.Year , 
                    Thang = g.Key.Month,
                    TongDoanhThu = (decimal)g.Sum(x => x.ThanhTien)
                }).OrderBy(x => x.Nam).ThenBy (x => x.Thang).ToList();
            return ds;
        }
        public List<ET_BaoCaoTonKho> BaoCaoTonKhoTrongCuaHang(int nam, int thang, string maCH)
        {
            try
            {
                var ngayDauThang = new DateTime(nam, thang, 1);
                var ngayCuoiThang = ngayDauThang.AddMonths(1).AddDays(-1);
                var ds = db.SanPhams.Select(sp => new { sp.MaSanPham, sp.TenSanPham, sp.DonViTinh, sp.LoaiSanPham });
                var baoCao = from sp in ds
                             let tonDauKy = db.LichSuKhos
                             .Where(lsk => lsk.ChiTietKho.MaCuaHang == maCH
                                 && lsk.ChiTietKho.MaSanPham == sp.MaSanPham
                                 && lsk.NgayThayDoi < ngayDauThang)
                             .OrderBy(lsk => lsk.NgayThayDoi)
                             .Sum(lsk => (int?)lsk.SoLuongThayDoi) ?? 0
                             let nhapTrongKy = db.ChiTietNhapHangs
                             .Where(ct => ct.PhieuNhap.MaCuaHang == maCH
                                  && ct.MaSanPham == sp.MaSanPham
                                  && ct.PhieuNhap.NgayNhap <= ngayCuoiThang
                                  && ct.PhieuNhap.NgayNhap >= ngayDauThang)
                             .Sum(ct => (int?)ct.SoLuong) ?? 0
                             let xuatHang = db.ChiTietXuatHangs
                             .Where(ct => ct.PhieuXuat.MaCuaHang == maCH
                                 && ct.MaSanPham == sp.MaSanPham
                                 && ct.PhieuXuat.NgayXuat <= ngayCuoiThang
                                 && ct.PhieuXuat.NgayXuat >= ngayDauThang)
                             .Sum(ct => (int?)ct.SoLuong) ?? 0
                             let xuatBan = db.ChiTietHoaDons
                             .Where(ct => ct.HoaDon.MaCuaHang == maCH
                                 && ct.HoaDon.NgayLap >= ngayDauThang
                                 && ct.HoaDon.NgayLap <= ngayCuoiThang
                                 && ct.MaSanPham == sp.MaSanPham)
                             .Sum(ct => (int?)ct.SoLuong) ?? 0
                             let slChenhLechThieu = db.ChiTietKiemKhos
                             .Where(ct => ct.KiemKho.MaCuaHang == maCH
                                 && ct.MaSanPham == sp.MaSanPham
                                 && ct.KiemKho.NgayKiem >= ngayDauThang
                                 && ct.KiemKho.NgayKiem <= ngayCuoiThang
                                 && ct.ChenhLech < 0)
                             .Sum(ct => (int?)ct.ChenhLech) ?? 0
                             let slChenhLechDu = db.ChiTietKiemKhos
                             .Where(ct => ct.KiemKho.MaCuaHang == maCH
                                 && ct.MaSanPham == sp.MaSanPham
                                 && ct.KiemKho.NgayKiem >= ngayDauThang
                                 && ct.KiemKho.NgayKiem <= ngayCuoiThang
                                 && ct.ChenhLech > 0)
                             .Sum(ct => (int?)ct.ChenhLech) ?? 0
                             let tongXuat = xuatHang + xuatBan
                             let tongKiem = slChenhLechDu +slChenhLechThieu
                             let tonCuoiKy = (tonDauKy + nhapTrongKy) - tongXuat + tongKiem
                             select new ET_BaoCaoTonKho
                             {
                                 maSP = sp.MaSanPham,
                                 Ten = sp.TenSanPham,
                                 LoaiSP = sp.LoaiSanPham,
                                 DViTinh = sp.DonViTinh,
                                 TonDauKy = tonDauKy,
                                 SLNhapTrongKy = nhapTrongKy,
                                 SLXuatHang = xuatHang,
                                 SLXuatBan = xuatBan,
                                 TongXuat = tongXuat,
                                 SLKiemKhoDu = slChenhLechDu,
                                 SLKiemKhoThieu = slChenhLechThieu,
                                 TonCuoiKy = tonCuoiKy,
                             };
                return baoCao.ToList();
            }
            catch (Exception ex) { throw ex; }



        }
    }
}
