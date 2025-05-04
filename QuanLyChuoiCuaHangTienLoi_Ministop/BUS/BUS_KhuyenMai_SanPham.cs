using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuyenMai_SanPham
    {
        private DAL_KhuyenMai_SanPham dal_km_sp = new DAL_KhuyenMai_SanPham();
        public List<ET_KhuyenMai_SanPham> HienThiDuLieuMotKMSapXepGiamDanTheoMaKM(string maKM)
        {

           
            return dal_km_sp.HienThiDuLieuMotKMSapXepGiamDanTheoMaKM(maKM);
        }
        public bool Them(ET_KhuyenMai_SanPham ctkm)
        {
            return dal_km_sp.Them(ctkm);
        }

        public bool Xoa(string maKM, string maSP)
        {
            return dal_km_sp.Xoa(maKM, maSP);
        }
        public bool Sua(ET_KhuyenMai_SanPham km)
        {
            return dal_km_sp.Sua(km);
        }
        public bool KiemTraDoUuTien(ET_KhuyenMai_SanPham ctkm)
        {
           return dal_km_sp.KiemTraDoUuTien(ctkm);

        }
        public ET_KhuyenMaiApDung ApDungKhuyenMaiChoSanPham(ET_ChiTietHoaDon cthd, DateTime tgianMua)
        {
           return dal_km_sp.ApDungKhuyenMaiChoSanPham(cthd, tgianMua);
        }
    }
}
