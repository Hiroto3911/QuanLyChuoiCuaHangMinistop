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
        public List<ET_ChiTietKho> HienThiDuLieuSapXepGiamDanTheoMaSP(string maCH)
        {
           
            return dal_CTK.HienThiDuLieuSapXepGiamDanTheoMaSP(maCH);
        }
        public double LayGiaBanCuaSanPhamCuaMotCH(string maCH, string maSP)
        {
            
            return dal_CTK.LayGiaBanCuaSanPhamCuaMotCH(maCH,maSP);

        }
        public bool KiemTraSanPhamConHang(string maCH, ET_ChiTietHoaDon sp)
        {

            return dal_CTK.KiemTraSanPhamConHang(maCH,sp);
        }
        public bool CapNhapSLSanPham(string maCH, string loaiCapNhap, ET_ChiTietHoaDon sp,int? soLuongCu = null)
        {
            return dal_CTK.CapNhapSLSanPham(maCH,loaiCapNhap, sp,soLuongCu);

        }
    }
}
