using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietKho
    {
        private DAL_ChiTietKho dal_CTK = new DAL_ChiTietKho();
        public List<ET_ChiTietKho> HienThiDuLieuSapXepGiamDanTheoMaCH(string maCH)
        {

            return dal_CTK.HienThiDuLieuSapXepGiamDanTheoMaCH(maCH);
        }
        public double LayGiaBanCuaSanPhamCuaMotCH(string maCH, string maSP)
        {

            return dal_CTK.LayGiaBanCuaSanPhamCuaMotCH(maCH, maSP);

        }
        public bool KiemTraSanPhamConHang(string maCH, ET_ChiTietHoaDon sp)
        {

            return dal_CTK.KiemTraSanPhamConHang(maCH, sp);
        }
        public bool CapNhapSLSanPham(string maCH, string loaiCapNhap, ET_ChiTietHoaDon sp, int? soLuongCu = null)
        {
            return dal_CTK.CapNhapSLSanPham(maCH, loaiCapNhap, sp, soLuongCu);

        }
        public bool Them(ET_ChiTietKho ct)
        {
            return dal_CTK.Them(ct);
        }

        public bool Xoa(string mact)
        {
            return dal_CTK.Xoa(mact);
        }
        public bool CapNhapChiTietKhoKhiNhapHang(string maCH, ET_ChiTietNhapHang nh, DateTime ngayNhap)
        {
            return dal_CTK.CapNhapChiTietKhoKhiNhapHang(maCH, nh, ngayNhap);
        }
        public bool CapNhapChiTietKhoKhiXuatHang(string maCH, ET_ChiTietXuatHang xh, DateTime ngayXuat)
        {
            return dal_CTK.CapNhapChiTietKhoKhiXuatHang(maCH,xh,ngayXuat);
        }
    } 
}
