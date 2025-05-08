using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BaoCao
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_DoanhThuCuaHangTheoThang> BaoCaoDoanhThuCuaHangTheoThang(string maCH = null) {
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
    }
}
