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
        public List<ET_ChiTietKho> HienThiDuLieuSapXepGiamDanTheoMaCH(string maCH)
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
                    GiaBan = (decimal)item.GiaBan,
                    SoluongTon = item.SoLuongTon
                });
            }
            return ds;
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

                });
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
        public bool KiemTraSanPhamConHang(string maCH, ET_ChiTietHoaDon sp) {

            var query = db.ChiTietKhos.Any(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == sp.MaSanPham && ctk.SoLuongTon >= sp.SoLuong);
            return query;
        }
        public int LaySLSanpham(string maCH , string maSP)
        {
            var query = db.ChiTietKhos.Where(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == maSP).FirstOrDefault();
            if (query == null) return 0; 
            return Convert.ToInt32(query.SoLuongTon);
        }
        public bool CapNhapSLSanPham(string maCH,string loaiCapNhap, ET_ChiTietHoaDon sp, int? soLuongCu = null) 
        {
            if(maCH == null ||sp == null || loaiCapNhap == null) return false;
            try
            {

                
                var query = db.ChiTietKhos.Where(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == sp.MaSanPham ).FirstOrDefault();
                if (query == null) return false;
                if (loaiCapNhap == "Them")
                {
                    query.SoLuongTon -= sp.SoLuong;
                    
                }
                else if(loaiCapNhap == "Xoa")
                {
                    query.SoLuongTon += sp.SoLuong;
                   
                }
                else if(loaiCapNhap =="Sua" && soLuongCu.HasValue)
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
            catch(Exception ex)
            {
                throw ex;
            }
                       
        }
        public bool CapNhapGiaCuaSanPhamTaiMotCuaHang(ET_LichSuThayDoiGia lsg)
        {
            if (lsg == null) return false;
            try
            {

                var query = db.ChiTietKhos.Where(ctk => ctk.MaCuaHang == lsg.MaCuaHang && ctk.MaSanPham == lsg.MaSanPham).FirstOrDefault();
                if (query == null) return false;
                query.GiaBan = lsg.GiaMoi;
                db.SubmitChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool CapNhapChiTietKhoKhiNhapHang(string maCH, ET_ChiTietNhapHang nh, DateTime ngayNhap)
        {
            try
            {
                var chitietKho = db.ChiTietKhos
                    .FirstOrDefault(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == nh.MaSanPham);

                DAL_LichSuKho lsk = new DAL_LichSuKho();

                if (chitietKho == null)
                {
                    var maCTK = TaoMa(LayDanhSachMaCTK(), "CTK");

                    ET_ChiTietKho ctk = new ET_ChiTietKho
                    {
                        MaChiTietKho = maCTK,
                        MaCuaHang = maCH,
                        MaSanPham = nh.MaSanPham,
                        SoluongTon = nh.SoLuong,
                        GiaBan = (decimal)nh.GiaNhap,
                    };

                    Them(ctk);

                    lsk.Them(new ET_LichSuKho
                    {
                        MaLichSuKho = TaoMa(lsk.LayDanhSachMaLSK(), "LSK"),
                        MaChiTietKho = maCTK,
                        NgayThayDoi = ngayNhap,
                        SoLuongThayDoi = nh.SoLuong,
                        LoaiThayDoi = "Nhap",
                        MaThamChieu = nh.MaPhieuNhap
                    });
                }
                else
                {
                    chitietKho.SoLuongTon += nh.SoLuong;
                    //chitietKho.GiaBan = nh.GiaNhap;
                    db.SubmitChanges();
                    lsk.Them(new ET_LichSuKho
                    {
                        MaLichSuKho = TaoMa(lsk.LayDanhSachMaLSK(), "LSK"),
                        MaChiTietKho = chitietKho.MaChiTietKho,
                        NgayThayDoi = ngayNhap,
                        SoLuongThayDoi = nh.SoLuong,
                        LoaiThayDoi = "Nhap",
                        MaThamChieu = nh.MaPhieuNhap
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật kho: " + ex.Message);
            }
        }

        public bool CapNhapChiTietKhoKhiXuatHang(string maCH, ET_ChiTietXuatHang xh, DateTime ngayXuat)
        {
            try
            {
                var chitietKho = db.ChiTietKhos
                    .FirstOrDefault(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == xh.MaSanPham);

                DAL_LichSuKho lsk = new DAL_LichSuKho();

                if (chitietKho == null)
                {
                   return false;
                }
                else
                {
                    chitietKho.SoLuongTon -= xh.SoLuong;
                    db.SubmitChanges();
                    lsk.Them(new ET_LichSuKho
                    {
                        MaLichSuKho = TaoMa(lsk.LayDanhSachMaLSK(), "LSK"),
                        MaChiTietKho = chitietKho.MaChiTietKho,
                        NgayThayDoi = ngayXuat,
                        SoLuongThayDoi = -xh.SoLuong,
                        LoaiThayDoi = "Xuat",
                        MaThamChieu = xh.MaPhieuXuat
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật kho: " + ex.Message);
            }
        }

        

        private string TaoMa(List<string> DanhSachMa, string tienTo)
        {
            // lấy ra mã cuối có chứa số lớn nhất
            var maCuoi = DanhSachMa.Where(ma => ma.StartsWith(tienTo)).OrderByDescending(ma => ma).FirstOrDefault();
            if (maCuoi != null)
            {
                string soCuoi = maCuoi.Substring(tienTo.Length);
                int stt = int.Parse(soCuoi) + 1;
                int length = soCuoi.Length;
                return tienTo + stt.ToString($"D{length}");
            }
            return tienTo + "001";

        }
        public List<string> LayDanhSachMaCTK()
        {
            var danhSachID = db.ChiTietKhos.Select(id => id.MaChiTietKho).ToList();
            return danhSachID;
        }
        public ET_ChiTietKho layChiTietKhoTheoMaSPVaMaCH(string maCH , string maSP)
        {
            var chitietKho = db.ChiTietKhos.Where(ctk => ctk.MaCuaHang == maCH && ctk.MaSanPham == maSP)
                .Select(ctk => new ET_ChiTietKho
                {
                    MaChiTietKho = ctk.MaChiTietKho,
                    MaSanPham = ctk.MaSanPham,
                    GiaBan =(decimal) ctk.GiaBan,
                    SoluongTon = ctk.SoLuongTon ,
                    MaCuaHang = ctk.MaCuaHang
                });
            return chitietKho.FirstOrDefault();
        }

    }
}
