using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KiemKho
    {
        private DAL_KiemKho dal_KiemKho = new DAL_KiemKho();
        public List<ET_KiemKho> HienThiDuLieuTheoMaCH(string maCH)
        {
            return dal_KiemKho.HienThiDuLieuTheoMaCH(maCH);
        }

        public bool Them(ET_KiemKho kk)
        {
            return dal_KiemKho.Them(kk);
        }

        public bool Xoa(string maCH, string maKK)
        {
            return dal_KiemKho.Xoa(maCH, maKK);
        }

        public List<string> LayDanhSachMaKK()
        {
            return dal_KiemKho.LayDanhSachMaKK();
        }
    }
}
