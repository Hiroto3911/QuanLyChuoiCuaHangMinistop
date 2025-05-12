using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_LichSuKho
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        public List<ET_LichSuKho> HienThiTatCa()
        {
            return db.LichSuKhos.Select(l => new ET_LichSuKho
            {
                MaLichSuKho = l.MaLichSuKho,
                MaChiTietKho = l.MaChiTietKho,
                NgayThayDoi = (DateTime)l.NgayThayDoi,
                SoLuongThayDoi = (int)l.SoLuongThayDoi,
                LoaiThayDoi = l.LoaiThayDoi,
                MaThamChieu = l.MaThamChieu
            }).ToList();
        }

        public List<ET_LichSuKho> LayLichSuTheoMaCTK(string maCTK)
        {
            return db.LichSuKhos
                .Where(lss => lss.MaChiTietKho.Equals(maCTK))
                .Select(ct => new ET_LichSuKho
                {
                    MaLichSuKho = ct.MaLichSuKho,
                    MaChiTietKho = ct.MaChiTietKho,
                    NgayThayDoi = (DateTime)ct.NgayThayDoi,
                    SoLuongThayDoi = (int)ct.SoLuongThayDoi,
                    LoaiThayDoi = ct.LoaiThayDoi,
                    MaThamChieu = ct.MaThamChieu
                }).ToList();
        }

        public bool Them(ET_LichSuKho ls)
        {
            try
            {
                db.LichSuKhos.InsertOnSubmit(new LichSuKho
                {
                    MaLichSuKho = ls.MaLichSuKho,
                    MaChiTietKho = ls.MaChiTietKho,
                    NgayThayDoi = ls.NgayThayDoi,
                    SoLuongThayDoi = ls.SoLuongThayDoi,
                    LoaiThayDoi = ls.LoaiThayDoi,
                    MaThamChieu = ls.MaThamChieu
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }


        public bool Xoa(string maLS)
        {
            var obj = db.LichSuKhos.FirstOrDefault(l => l.MaLichSuKho == maLS);
            if (obj == null) return false;
            db.LichSuKhos.DeleteOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }
        public List<string> LayDanhSachMaLSK()
        {
            var danhSachID = db.LichSuKhos.Select(id => id.MaLichSuKho).ToList();
            return danhSachID;
        }

    }
}
