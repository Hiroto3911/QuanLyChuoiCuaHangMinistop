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
                    GiaBan = (double)item.GiaBan,
                    SoluongTon = item.SoLuongTon
                });
            }
            return ds;
        }

        public List<ET_ChiTietKho> HienThiTatCa()
        {
            return db.ChiTietKhos.Select(p => new ET_ChiTietKho
            {
                MaCuaHang = p.MaCuaHang,
                MaChiTietKho = p.MaChiTietKho,
                MaSanPham = p.MaSanPham,
                GiaBan = (double)p.GiaBan,
                SoluongTon = p.SoLuongTon
            }).ToList();
        } 
        public List<string> LayDanhSachMaCH()
        {
            var danhSachID = db.CuaHangs.Select(id => id.MaCuaHang).ToList();
            return danhSachID;
        }
        public double LayGiaBanCuaSanPhamCuaMotCH(string maCH, string maSP)
        {
            var query = db.ChiTietKhos.Where(ma => ma.MaCuaHang == maCH && ma.MaSanPham == maSP).Select(ma => ma.GiaBan).FirstOrDefault();
            if (query == null) return 0.0;
            return Convert.ToDouble(query);

        }
        public bool KiemTraSanPhamConHang(string maCH, ET_ChiTietHoaDon sp)
        {

            var query = db.ChiTietKhos.Any(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == sp.MaSanPham && ctk.SoLuongTon >= sp.SoLuong);
            return query;
        }
        public int LaySLSanpham(string maCH, string maSP)
        {
            var query = db.ChiTietKhos.Where(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == maSP).FirstOrDefault();
            if (query == null) return 0;
            return Convert.ToInt32(query.SoLuongTon);
        }
        public bool CapNhapSLSanPham(string maCH, string loaiCapNhap, ET_ChiTietHoaDon sp, int? soLuongCu = null)
        {
            if (maCH == null || sp == null || loaiCapNhap == null) return false;
            try
            {


                var query = db.ChiTietKhos.Where(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == sp.MaSanPham).FirstOrDefault();
                if (query == null) return false;
                if (loaiCapNhap == "Them")
                {
                    query.SoLuongTon -= sp.SoLuong;

                }
                else if (loaiCapNhap == "Xoa")
                {
                    query.SoLuongTon += sp.SoLuong;

                }
                else if (loaiCapNhap == "Sua" && soLuongCu.HasValue)
                {
                    query.SoLuongTon += soLuongCu;
                    query.SoLuongTon -= sp.SoLuong;

                }
                else
                {
                    return false;
                }
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public bool Them(ET_ChiTietKho ct)
        {
            try
            {
                db.ChiTietKhos.InsertOnSubmit(new ChiTietKho
                {
                    MaChiTietKho = ct.MaChiTietKho,
                    MaCuaHang = ct.MaCuaHang,
                    MaSanPham = ct.MaSanPham,
                    SoLuongTon = ct.SoluongTon,
                    GiaBan = (decimal?)ct.GiaBan

                }) ;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(string mact)
        {
            var obj = db.ChiTietKhos.FirstOrDefault(l => l.MaChiTietKho == mact);
            if (obj == null) return false;
            db.ChiTietKhos.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }
    }
}
