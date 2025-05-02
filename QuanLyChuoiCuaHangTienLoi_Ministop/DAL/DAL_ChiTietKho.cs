using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietKho
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_ChiTietKho> HienThiDuLieuSapXepGiamDanTheoMaSP(string maCH)
        {
            var query = db.ChiTietKhos.Where(ma => ma.MaCuaHang == maCH).OrderByDescending(ma => ma.MaSanPham).ToList();
            List<ET_ChiTietKho> ds = new List<ET_ChiTietKho>();
            foreach (var item in query)
            {
                ds.Add(new ET_ChiTietKho
                {
                    MaCuaHang = item.MaCuaHang,
                    MaChiTietKho = item.MaChiTietKho,
                    MaSanPham = item.MaSanPham,
                    GiaBan = (double) item.GiaBan,
                    SoluongTon = item.SoLuongTon
                });
            }
            return ds;
        }
        //public bool Them(ET_HoaDon hoaDon)
        //{

        //}

        //public bool Xoa(string maHD)
        //{

        //}
        //public HoaDon TimHoaDonBangMaHD(string maHD)
        //{

        //}
        public List<string> LayDanhSachMaCH()
        {
            var danhSachID = db.CuaHangs.Select(id => id.MaCuaHang).ToList();
            return danhSachID;
        }
        public double LayGiaBanCuaSanPhamCuaMotCH(string maCH,string maSP)
        {
            var query = db.ChiTietKhos.Where(ma => ma.MaCuaHang == maCH && ma.MaSanPham == maSP).Select(ma => ma.GiaBan).FirstOrDefault();
            if (query == null) return 0.0;
            return Convert.ToDouble(query);

        }
    }
}
