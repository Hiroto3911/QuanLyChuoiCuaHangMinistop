using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = DB_Context_Custom.getDataContext();
        public List<ET_KhuyenMai> HienThiDuLieuMotKMSapXepGiamDanTheoMa()
        {

            var query = db.KhuyenMais.OrderByDescending(ma => ma.MaKhuyenMai).ToList();
            List<ET_KhuyenMai> ds = new List<ET_KhuyenMai>();
            foreach (var item in query)
            {
                ds.Add(new ET_KhuyenMai
                {
                     
                    MaKhuyenMai = item.MaKhuyenMai,
                    TenKhuyenMai = item.TenKhuyenMai,
                    MucGiamGia = (decimal)item.MucGiamGia,
                    NgayBatDau = Convert.ToDateTime(item.NgayBatDau),
                    NgayKetThuc = Convert.ToDateTime(item.NgayKetThuc),
                    LoaiApDung = item.LoaiApDung,
                    DieuKienApDung =(decimal)(item.DieuKienApDung??0) ,
                    TrangThai = (int)item.TrangThai

                });
            }
            return ds;
        }

        public List<ET_KhuyenMai> HienThiDuLieuTheoLoaiApDung(string loaiApDung)
        {

            var query = db.KhuyenMais.Where(ma => ma.LoaiApDung == loaiApDung).OrderByDescending(ma => ma.MaKhuyenMai).ToList();
            List<ET_KhuyenMai> ds = new List<ET_KhuyenMai>();
            foreach (var item in query)
            {
                ds.Add(new ET_KhuyenMai
                {

                    MaKhuyenMai = item.MaKhuyenMai,
                    TenKhuyenMai = item.TenKhuyenMai,
                    MucGiamGia = (decimal)item.MucGiamGia,
                    NgayBatDau = Convert.ToDateTime(item.NgayBatDau),
                    NgayKetThuc = Convert.ToDateTime(item.NgayKetThuc),
                    LoaiApDung = item.LoaiApDung,
                    DieuKienApDung = (decimal)(item.DieuKienApDung ?? 0),
                    TrangThai = (int)item.TrangThai

                });
            }
            return ds;
        }
        public bool Them(ET_KhuyenMai  KhuyenMai)
        {
            if ( KhuyenMai == null) return false;
            try
            {
               
                 KhuyenMai km = new KhuyenMai()
                {
                     MaKhuyenMai = KhuyenMai.MaKhuyenMai,
                     TenKhuyenMai = KhuyenMai.TenKhuyenMai,
                     MucGiamGia = KhuyenMai.MucGiamGia,
                     NgayBatDau = KhuyenMai.NgayBatDau,
                     NgayKetThuc = KhuyenMai.NgayKetThuc,
                     LoaiApDung = KhuyenMai.LoaiApDung,
                     DieuKienApDung = KhuyenMai.DieuKienApDung,
                     TrangThai = KhuyenMai.TrangThai
                 };
                db. KhuyenMais.InsertOnSubmit(km);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Xoa(string maKM)
        {
            if (string.IsNullOrWhiteSpace(maKM)) return false;
            try
            {
                var del = TimKhuyenMaiBangMaKM(maKM);
                if (del == null) return false;
                db.KhuyenMais.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_KhuyenMai km)
        {
            if (km == null) return false;
            try
            {
                var capNhap = TimKhuyenMaiBangMaKM(km.MaKhuyenMai);
                capNhap.TenKhuyenMai = km.TenKhuyenMai;
                capNhap.MucGiamGia = km.MucGiamGia;
                capNhap.NgayBatDau = km.NgayBatDau;
                capNhap.NgayKetThuc = km.NgayKetThuc;
                capNhap.LoaiApDung = km.LoaiApDung; 
                capNhap.DieuKienApDung = km.DieuKienApDung;
                capNhap.TrangThai = km.TrangThai;   
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public  KhuyenMai TimKhuyenMaiBangMaKM(string maKH)
        {
            var kq = db.KhuyenMais.Where(n => n.MaKhuyenMai == maKH).FirstOrDefault();
            return kq;
        }
        public List<string> LayDanhSachMaKM()
        {
            var danhSachID = db.KhuyenMais.Select(id => id.MaKhuyenMai).ToList();
            return danhSachID;
        }
        public ET_KhuyenMaiApDungHoaDon ApDungKhuyenMaiChoHoaDon(ET_HoaDon hoaDon, DateTime tgianMua)
        {
            var query = from km in db.KhuyenMais
                        where km.LoaiApDung =="Hoá đơn"
                        && hoaDon.TongTien >= km.DieuKienApDung
                        && km.TrangThai == 1
                        && tgianMua >= km.NgayBatDau
                        && tgianMua <= km.NgayKetThuc
                        orderby km.DieuKienApDung descending
                        select new ET_KhuyenMaiApDungHoaDon
                        {
                            MaHoaDon = hoaDon.MaHoaDon ,
                            TenKhuyenMai = km.TenKhuyenMai,
                            MucGiamGia =(decimal) km.MucGiamGia,   
                            DieuKienAP = (decimal) km.DieuKienApDung
                        }
                        ;

            return query.FirstOrDefault();
        }
    }
}
