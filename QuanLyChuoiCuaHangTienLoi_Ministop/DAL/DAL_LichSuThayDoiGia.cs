using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_LichSuThayDoiGia
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = DB_Context_Custom.getDataContext();
        public List<ET_LichSuThayDoiGia> HienThiDuLieuSapXepGiamDanTheoMaCHVaMaSP(string maCH, string maSP)
        {
            var query = db.LichSuThayDoiGias.Where(ls => ls.MaCuaHang == maCH && ls.MaSanPham == maSP).OrderByDescending(ma => ma.MaLichSu).ToList();
            List<ET_LichSuThayDoiGia> ds = new List<ET_LichSuThayDoiGia>();
            foreach (var item in query)
            {
                ds.Add(new ET_LichSuThayDoiGia
                {
                    MaLichSu = item.MaLichSu,
                    MaCuaHang = item.MaCuaHang,
                    MaSanPham = item.MaSanPham,
                    GiaCu = (decimal)item.GiaCu,
                    GiaMoi = (decimal)item.GiaMoi,
                    NguoiThayDoi = item.NguoiThayDoi,
                    LyDo = item.LyDo,
                    NgayThayDoi = Convert.ToDateTime(item.NgayThayDoi)
                });

            }
            return ds;
        }
        public bool Them(ET_LichSuThayDoiGia ls)
        {
            if (ls == null) return false;
            try
            {
                LichSuThayDoiGia lsg = new LichSuThayDoiGia()
                {
                    MaLichSu = ls.MaLichSu,
                    MaCuaHang = ls.MaCuaHang,
                    MaSanPham = ls.MaSanPham,
                    GiaCu = ls.GiaCu,
                    GiaMoi = ls.GiaMoi,
                    NguoiThayDoi = ls.NguoiThayDoi,
                    LyDo = ls.LyDo,
                    NgayThayDoi = ls.NgayThayDoi
                };
                db.LichSuThayDoiGias.InsertOnSubmit(lsg);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Xoa(string maCH, string maLS)
        {
            if (string.IsNullOrWhiteSpace(maCH)) return false;
            try
            {
                var del = TimLichSuBangMaCHVaMaLS(maCH, maLS);
                if (del == null) return false;
                db.LichSuThayDoiGias.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_LichSuThayDoiGia ls)

        {

            if (ls == null) return false;
            try
            {
                var capNhat = TimLichSuBangMaCHVaMaLS(ls.MaCuaHang, ls.MaLichSu);
                if (capNhat == null) return false;
                capNhat.GiaMoi = ls.GiaMoi;
                capNhat.NgayThayDoi = ls.NgayThayDoi;
                capNhat.LyDo = ls.LyDo; 
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {


                throw ex;

            }

        }
        public decimal TinhGiaCaSanPhamTrong1thang(ET_LichSuThayDoiGia ls , DateTime tgian)
        {
            DateTime ngayBatDau = tgian.AddMonths(-1);
            var query = from lsg in db.LichSuThayDoiGias
                        where( lsg.MaCuaHang == ls.MaCuaHang 
                        && lsg.MaSanPham == ls.MaSanPham 
                        && lsg.NgayThayDoi >= ngayBatDau)
                        select lsg;
            return (decimal)query.Sum(lsg => (lsg.GiaMoi- lsg.GiaCu)/lsg.GiaCu*100);

                        
                       
        }
        

        
        public LichSuThayDoiGia TimLichSuBangMaCHVaMaLS(string maCH ,string maLS)
        {
            var query = db.LichSuThayDoiGias.Where(ls => ls.MaCuaHang == maCH && ls.MaLichSu == maLS).FirstOrDefault();
            return query;
        }

        public List<string> LayDanhSachMaLS()
        {
            var danhSachID = db.LichSuThayDoiGias.Select(id => id.MaLichSu).ToList();
            return danhSachID;
        }
        public decimal TinhTongThayDoiGiaTrongMotThang(ET_LichSuThayDoiGia ls)
        {
            DateTime ngayBatDau = ls.NgayThayDoi.AddMonths(-1);
            var phanTram = db.LichSuThayDoiGias.Where(lsg => lsg.MaCuaHang == ls.MaCuaHang && lsg.MaSanPham == ls.MaSanPham && ngayBatDau <= ls.NgayThayDoi)
                .Sum(lsg => (lsg.GiaMoi - lsg.GiaCu)/lsg.GiaCu*100);
            return (decimal)phanTram; 
        }
    }
}
