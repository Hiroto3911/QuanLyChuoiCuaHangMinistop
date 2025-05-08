using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class DAL_NhaCungCap
    {
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = new DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext();
        public List<ET_NhaCungCap> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            var query = db.NhaCungCaps.OrderByDescending(ma => ma.MaNCC).ToList();
            List<ET_NhaCungCap> ds = new List<ET_NhaCungCap>();
            foreach (var item in query)
            {
                ds.Add(new ET_NhaCungCap
                {
                    MaNcc = item.MaNCC,
                    TenNcc = item.TenNCC,
                    DiaChi = item.DiaChi,
                    SoDienThoai = item.SoDienThoai,
                    Email = item.Email


                });
            }
            return ds;
        }



        public bool Them(ET_NhaCungCap nhaCungCap)
        {
            if (nhaCungCap == null) return false;
            try
            {

                NhaCungCap sp = new NhaCungCap()
                {
                    MaNCC = nhaCungCap.MaNcc,
                    TenNCC = nhaCungCap.TenNcc,
                    DiaChi = nhaCungCap.DiaChi,
                    SoDienThoai = nhaCungCap.SoDienThoai,
                    Email = nhaCungCap.Email
                };
                db.NhaCungCaps.InsertOnSubmit(sp);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Xoa(string maNCC)
        {
            if (string.IsNullOrWhiteSpace(maNCC)) return false;
            try
            {
                var del = TimCuaSanPhamMaSanPham(maNCC);
                if (del == null) return false;
                db.NhaCungCaps.DeleteOnSubmit(del);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }
        public bool Sua(ET_NhaCungCap maNCC)

        {

            if (maNCC == null) return false;
            try
            {
                var capNhat = TimCuaSanPhamMaSanPham(maNCC.MaNcc);
                if (capNhat == null) return false;

                capNhat.TenNCC = maNCC.TenNcc;
                capNhat.DiaChi = maNCC.DiaChi;
                capNhat.SoDienThoai = maNCC.SoDienThoai;
                capNhat.Email = maNCC.Email;


                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {


                throw ex;

            }

        }
        public List<string> LayDanhSachMaNCC()
        {
            var danhSachID = db.NhaCungCaps.Select(id => id.MaNCC).ToList();
            return danhSachID;
        }
        private NhaCungCap TimCuaSanPhamMaSanPham(string maNCC)
        {
            var kq = db.NhaCungCaps.Where(n => n.MaNCC == maNCC).FirstOrDefault();
            return kq;
        }
    }
}
