using ET;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    GiaMacDinh = (decimal)item.GiaMacDinh
                    

                });
            }
            return ds;
        }
        public string TimTenSPBangMaSP(string maSP)
        {
            var query = db.SanPhams.Where(ma => ma.MaSanPham == maSP).Select(ma => ma.TenSanPham).FirstOrDefault();
            return query;
        }
        public bool Them(ET_SanPham sanPham)
        {
            if (sanPham == null) return false;
            try
            {

                SanPham sp = new SanPham()
                {
                   MaSanPham = sanPham.MaSanPham,
                   TenSanPham = sanPham.TenSanPham,
                   GiaMacDinh = (decimal)sanPham.GiaMacDinh,
                   DonViTinh= sanPham.DonViTinh,
                   LoaiSanPham = sanPham.LoaiSanPham
                };
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Xoa(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return false;
            try
            {
                var del = TimCuaSanPhamMaSanPham(maSP);
                if (del == null) return false;
                db.SanPhams.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_SanPham sanPham)

        {

            if (sanPham == null) return false;
            try
            {
                var capNhat = TimCuaSanPhamMaSanPham(sanPham.MaSanPham);
                if (capNhat == null) return false;
              
                capNhat.TenSanPham = sanPham.TenSanPham;
                capNhat.GiaMacDinh = sanPham.GiaMacDinh;
                capNhat.DonViTinh = sanPham.DonViTinh;
                capNhat.LoaiSanPham = sanPham.LoaiSanPham;


                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {


                throw ex;

            }

        }
        public List<ET_SanPham> TimSanPhamBangTen(string name)
        {
            var sanPham = from sp in db.SanPhams
                          where (sp.TenSanPham.StartsWith(name))
                          select sp;
                          
            List<ET_SanPham> ds = new List<ET_SanPham>();
            foreach (var item in sanPham)
            {
                ds.Add(new ET_SanPham
                {
                    MaSanPham = item.MaSanPham,
                    TenSanPham = item.TenSanPham,
                    LoaiSanPham = item.LoaiSanPham,
                    DonViTinh = item.DonViTinh,
                    GiaMacDinh = (decimal)item.GiaMacDinh


                });
            }
            return ds;
        }
        public List<ET_SanPham> HienThiSanPhamBangLoaiSanPham(string loaiSP)
        {
            var sanPham = from sp in db.SanPhams
                          where (sp.LoaiSanPham == loaiSP)
                          select sp;

            List<ET_SanPham> ds = new List<ET_SanPham>();
            foreach (var item in sanPham)
            {
                ds.Add(new ET_SanPham
                {
                    MaSanPham = item.MaSanPham,
                    TenSanPham = item.TenSanPham,
                    LoaiSanPham = item.LoaiSanPham,
                    DonViTinh = item.DonViTinh,
                    GiaMacDinh = (decimal)item.GiaMacDinh


                });
            }
            return ds;
        }

        public List<string> LayDanhSachMaSP()
        {
            var danhSachID = db.SanPhams.Select(id => id.MaSanPham).ToList();
            return danhSachID;
        }
        private SanPham TimCuaSanPhamMaSanPham(string maSP)
        {
            var kq = db.SanPhams.Where(n => n.MaSanPham == maSP).FirstOrDefault();
            return kq;
        }
    }
}
