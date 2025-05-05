using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_SanPham> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            var query = db.SanPhams.OrderByDescending(ma => ma.MaSanPham).ToList();
            List<ET_SanPham> ds = new List<ET_SanPham>();
            foreach (var item in query)
            {
                ds.Add(new ET_SanPham
                {
                    MaSanPham = item.MaSanPham,
                    TenSanPham= item.TenSanPham,
                    LoaiSanPham = item.LoaiSanPham, 
                    DonViTinh = item.DonViTinh,
                    GiaMacDinh = (double)item.GiaMacDinh
                    

                });
            }
            return ds;
        }
        public string TimTenSPBangMaSP(string maSP)
        {
            var query = db.SanPhams.Where(ma => ma.MaSanPham == maSP).Select(ma => ma.TenSanPham).FirstOrDefault();
            return query;
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
        //public List<string> LayDanhSachMaSP()
        //{
        //    var danhSachID = db.CuaHangs.Select(id => id.MaCuaHang).ToList();
        //    return danhSachID;
        //} 
    }
}
