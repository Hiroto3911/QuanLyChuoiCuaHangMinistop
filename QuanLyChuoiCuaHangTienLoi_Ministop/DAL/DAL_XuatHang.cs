using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_XuatHang
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();

        public List<ET_XuatHang> HienThiDuLieuTheoMaCH(string maCH)
        {
            return db.PhieuXuats.Where(pn => pn.MaCuaHang == maCH).Select(p => new ET_XuatHang
            {
                MaPhieuXuat = p.MaPhieuXuat,
                MaCuaHang = p.MaCuaHang,
                MaNhanVien = p.MaNhanVien,
                NgayXuat = Convert.ToDateTime(p.NgayXuat),
                LoaiXuat = p.LoaiXuat
            }).OrderByDescending(nh => nh.MaPhieuXuat).ToList();
        }

        public bool Them(ET_XuatHang px)
        {
            try
            {
                db.PhieuXuats.InsertOnSubmit(new PhieuXuat
                {
                    MaPhieuXuat = px.MaPhieuXuat,
                    MaCuaHang = px.MaCuaHang,
                    MaNhanVien = px.MaNhanVien,
                    NgayXuat = px.NgayXuat,
                    LoaiXuat = px.LoaiXuat
                });
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Xoa(string maPX)
        {
            try
            {

                var obj = db.PhieuXuats.FirstOrDefault(p => p.MaPhieuXuat == maPX);
                if (obj == null) return false;
                db.PhieuXuats.DeleteOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool Sua(ET_XuatHang px)
        {
            try
            {

                var obj = db.PhieuXuats.FirstOrDefault(p => p.MaPhieuXuat == px.MaPhieuXuat);
                if (obj == null) return false;
                obj.MaCuaHang = px.MaCuaHang;
                obj.MaNhanVien = px.MaNhanVien;
                obj.NgayXuat = px.NgayXuat;
                obj.LoaiXuat = px.LoaiXuat;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public List<string> LayDanhSachMaXH()
        {
            var danhSachID = db.PhieuXuats.Select(id => id.MaPhieuXuat).ToList();
            return danhSachID;
        }
    }
}
