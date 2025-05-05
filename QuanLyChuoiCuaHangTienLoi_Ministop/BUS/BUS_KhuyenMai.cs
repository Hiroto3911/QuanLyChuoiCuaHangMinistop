using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        private DAL_KhuyenMai dal_KM = new DAL_KhuyenMai();

        public List<ET_KhuyenMai> HienThiDuLieuMotKMSapXepGiamDanTheoMa()
        {

            
            return dal_KM.HienThiDuLieuMotKMSapXepGiamDanTheoMa();
        }
        public List<ET_KhuyenMai> HienThiDuLieuTheoLoaiApDung(string loaiApDung)
        {

            return dal_KM.HienThiDuLieuTheoLoaiApDung(loaiApDung);
        }
        public bool Them(ET_KhuyenMai KhuyenMai)
        {
           return dal_KM.Them(KhuyenMai);
        }

        public bool Xoa(string maKM)
        {
            return dal_KM.Xoa(maKM);
        }
        public bool Sua(ET_KhuyenMai km)
        {
            return dal_KM.Sua(km);
        }
        
        public List<string> LayDanhSachMaKM()
        {
            return dal_KM.LayDanhSachMaKM();
        }
        public ET_KhuyenMaiApDungHoaDon ApDungKhuyenMaiChoHoaDon(ET_HoaDon hoaDon, DateTime tgianMua)
        {
           return dal_KM.ApDungKhuyenMaiChoHoaDon(hoaDon,tgianMua);
        }
    }
}
