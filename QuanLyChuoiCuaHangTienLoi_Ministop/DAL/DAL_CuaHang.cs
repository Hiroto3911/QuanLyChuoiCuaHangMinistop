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
        public bool Them(ET_CuaHang cuaHang)
        {
            if (cuaHang == null) return false;
            try
            {
                CuaHang ch = new CuaHang()
                {

                    MaCuaHang = cuaHang.MaCH,
                    TenCuaHang = cuaHang.TenCH,
                    SoDienThoai = cuaHang.SDT,
                    DiaChi = cuaHang.DChi
                };
                db.CuaHangs.InsertOnSubmit(ch);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Xoa(string maCH)
        {
            if (string.IsNullOrWhiteSpace(maCH)) return false;
            try
            {
                var del = TimCuaHangBangMaCuaHang(maCH);
                if (del == null) return false;
                db.CuaHangs.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_CuaHang cuaHang)

        {

            if (cuaHang == null) return false;
            try
            {
                var capNhat = TimCuaHangBangMaCuaHang(cuaHang.MaCH);
                if (capNhat == null) return false;
                capNhat.TenCuaHang = cuaHang.TenCH;
                capNhat.SoDienThoai = cuaHang.SDT;
                capNhat.MaQuanLy = cuaHang.NguoiQL;
                capNhat.DiaChi = cuaHang.DChi;
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {


                throw ex;

            }

        }

        public CuaHang TimCuaHangBangMaCuaHang(string maCH)
        {
            var kq = db.CuaHangs.Where(n => n.MaCuaHang == maCH).FirstOrDefault();
            return kq;
        }
        public List<string> LayDanhSachMaCH()
        {
            var danhSachID = db.CuaHangs.Select(id => id.MaCuaHang).ToList();
            return danhSachID;
        }
    }
}
