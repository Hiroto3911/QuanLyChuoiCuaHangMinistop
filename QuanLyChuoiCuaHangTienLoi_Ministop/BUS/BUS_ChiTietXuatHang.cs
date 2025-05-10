using ET;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietXuatHang
    {
        private DAL_ChiTietXuatHang dal = new DAL_ChiTietXuatHang();

        public List<ET_ChiTietXuatHang> HienThiTatCa()
        {
            return dal.HienThiTatCa();
        }

        public List<ET_ChiTietXuatHang> LayChiTietTheoMaPhieu(string maPhieu)
        {
            return dal.LayChiTietTheoMaPhieu(maPhieu);
        }

        public bool Them(ET_ChiTietXuatHang ct)
        {
            return dal.Them(ct);
        }

        public bool Sua(ET_ChiTietXuatHang ct)
        {
            return dal.Sua(ct);
        }

        public bool Xoa(string maPhieu, string maSP)
        {
            return dal.Xoa(maPhieu, maSP);
        }
    }
}
