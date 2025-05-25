using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietKiemKho
    {
        private DAL_ChiTietKiemKho dal_ChiTietKiem = new DAL_ChiTietKiemKho();

        public List<ET_ChiTietKiemKho> LayChiTietTheoMaPhieu(string maKK)
        {
            return dal_ChiTietKiem.LayChiTietTheoMaPhieu(maKK);
        }
        public bool Them(ET_ChiTietKiemKho ct)
        {
            return dal_ChiTietKiem.Them(ct);
        }
        public bool Sua(ET_ChiTietKiemKho ct)
        {
            return dal_ChiTietKiem.Sua(ct);
        }
        public bool Xoa(string maKK, string maSP)
        {
            return dal_ChiTietKiem.Xoa(maKK, maSP); 
        }

    }
}
