using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CuaHang
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_CuaHang> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            var query = db.CuaHangs.OrderByDescending(ma => ma.MaCuaHang).ToList();
            List<ET_CuaHang> ds = new List<ET_CuaHang>();
            foreach (var item in query)
            {
                ds.Add(new ET_CuaHang
                {
                   MaCH = item.MaCuaHang,
                   TenCH = item.TenCuaHang,
                   SDT = item.SoDienThoai,
                   DChi = item.DiaChi,
                   NguoiQL = item.MaQuanLy
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
    }
}
