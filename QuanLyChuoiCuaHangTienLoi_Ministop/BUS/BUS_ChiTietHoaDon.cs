using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        private DAL_ChiTietHoaDon dal_cthd = new DAL_ChiTietHoaDon();
        public List<ET_ChiTietHoaDon> HienThiDuLieuSapXepGiamDanTheoMaHD(string maHD)
        {
            
            return dal_cthd.HienThiDuLieuSapXepGiamDanTheoMaHD(maHD);
        }
        public bool Them(ET_ChiTietHoaDon chiTietHD)
        {
           return dal_cthd.Them(chiTietHD); 
        }

        public bool Sua(ET_ChiTietHoaDon chiTietHD)
        {
            return dal_cthd.Sua(chiTietHD); 
        }
        public bool Xoa(string maCTHD)
        {
           return dal_cthd.Xoa(maCTHD); 
        }
        
        public List<string> LayDanhSachMaCTHD()
        {
           
            return dal_cthd.LayDanhSachMaCTHD();
        }
        public decimal TinhTongTienTheoMaHD(string maHD)
        {
           
            return dal_cthd.TinhTongTienTheoMaHD(maHD);
        }
        public int LaySLCuaChiTietHDTheoMaCTHD(string maHD, string maCTHD)
        {
           return dal_cthd.LaySLCuaChiTietHDTheoMaCTHD(maHD, maCTHD);
        }
        public bool CapNhapThanhTien(ET_ChiTietHoaDon chiTietHD)
        {
            return dal_cthd.CapNhapThanhTien(chiTietHD);
        }
    }
}
