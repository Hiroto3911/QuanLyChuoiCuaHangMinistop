using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai_SanPham
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_KhuyenMai_SanPham> HienThiDuLieuMotKMSapXepGiamDanTheoMaKM(string maKM)
        {

            var query = db.KhuyenMai_SanPhams.Where(ma => ma.MaKhuyenMai == maKM).OrderByDescending(ma => ma.MaKhuyenMai).ToList();
            List<ET_KhuyenMai_SanPham> ds = new List<ET_KhuyenMai_SanPham>();
            foreach (var item in query)
            {
                ds.Add(new ET_KhuyenMai_SanPham
                {

                   MaKhuyenMai = item.MaKhuyenMai,
                   MaSanPham = item.MaSanPham,
                   SoLuongToiThieu = (int)item.SoLuongToiThieu,
                   DoUuTien = (int)item.DoUuTien

                });
            }
            return ds;
        }
        public bool Them(ET_KhuyenMai_SanPham ctkm)
        {
            if (ctkm == null) return false;
            try
            {

                KhuyenMai_SanPham km = new KhuyenMai_SanPham()
                {
                    MaKhuyenMai = ctkm.MaKhuyenMai,
                    MaSanPham = ctkm.MaSanPham,
                    SoLuongToiThieu = ctkm.SoLuongToiThieu,
                    DoUuTien = ctkm.DoUuTien
                };
                db.KhuyenMai_SanPhams.InsertOnSubmit(km);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Xoa(string maKM,string maSP)
        {
            if (string.IsNullOrWhiteSpace(maKM)&& string.IsNullOrWhiteSpace(maSP)) return false;
            try
            {
                var del = TimKhuyenMai_SanPhamBangMaKM_SP(maKM,maSP);
                if (del == null) return false;
                db.KhuyenMai_SanPhams.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_KhuyenMai_SanPham km)
        {
            if (km == null) return false;
            try
            {
                var capNhap = TimKhuyenMai_SanPhamBangMaKM_SP(km.MaKhuyenMai, km.MaSanPham);
                capNhap.SoLuongToiThieu = km.SoLuongToiThieu;
                capNhap.DoUuTien = km.DoUuTien;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        private KhuyenMai_SanPham TimKhuyenMai_SanPhamBangMaKM_SP(string maKH, string maSP)
        {
            var kq = db.KhuyenMai_SanPhams.Where(n => n.MaKhuyenMai == maKH && n.MaSanPham == maSP).FirstOrDefault();
            return kq;
        }
        public bool KiemTraDoUuTien(ET_KhuyenMai_SanPham ctkm)
        {
            var query = from km_sp in db.KhuyenMai_SanPhams
                        join km in db.KhuyenMais on km_sp.MaKhuyenMai equals km.MaKhuyenMai
                        where km_sp.MaSanPham == ctkm.MaSanPham 
                           && km_sp.DoUuTien == ctkm.DoUuTien
                           && km.TrangThai == 1 
                           && DateTime.Now >= km.NgayBatDau
                           && DateTime.Now <= km.NgayKetThuc
                        select km_sp;
            return query.Any();
            
        }
        public ET_KhuyenMaiApDung ApDungKhuyenMaiChoSanPham(ET_ChiTietHoaDon cthd, DateTime tgianMua)
        {
            var query = from ctkm in db.KhuyenMai_SanPhams
                        join km in db.KhuyenMais on ctkm.MaKhuyenMai equals km.MaKhuyenMai
                        where ctkm.MaSanPham == cthd.MaSanPham
                        && km.TrangThai == 1
                        && cthd.SoLuong >= ctkm.SoLuongToiThieu
                        && tgianMua >= km.NgayBatDau
                        && tgianMua <= km.NgayKetThuc
                        orderby ctkm.DoUuTien
                        select new ET_KhuyenMaiApDung
                        {
                            MaSanPham = ctkm.MaSanPham,
                            TenKhuyenMai = km.TenKhuyenMai,
                            MucGiamGia = (decimal)km.MucGiamGia,
                            NgayBatDau = Convert.ToDateTime(km.NgayBatDau),
                            NgayKetThuc = Convert.ToDateTime(km.NgayKetThuc)
                        };
                        
            return query.FirstOrDefault();
        }
    }
}
