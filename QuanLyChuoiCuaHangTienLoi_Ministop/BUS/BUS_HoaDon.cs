using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        private DAL_HoaDon dal_HoaDon = new DAL_HoaDon();
        public List<ET_HoaDon> HienThiDuLieuMotCHSapXepGiamDanTheoMa(string maCH)
        {
            return dal_HoaDon.HienThiDuLieuMotCHSapXepGiamDanTheoMa(maCH);
        }
        public bool Them(ET_HoaDon hoaDon)
        {
            return dal_HoaDon.Them(hoaDon);
        }

        public bool Xoa(string maHD)
        {
            return dal_HoaDon.Xoa(maHD);
        }
        public bool Sua(ET_HoaDon hoaDon)
        {
            return dal_HoaDon.Sua(hoaDon);
        }
        public HoaDon TimHoaDonBangMaHD(string maHD)
        {
            return dal_HoaDon.TimHoaDonBangMaHD(maHD);
        }
        public List<string> LayDanhSachMaHD()
        {
            
            return dal_HoaDon.LayDanhSachMaHD();
        }
    }
}
