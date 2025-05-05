using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CuaHang
    {
        private DAL_CuaHang dal_CH = new DAL_CuaHang();
        public List<ET_CuaHang> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            return dal_CH.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        public bool Them(ET_CuaHang cuaHang)
        {
            return dal_CH.Them(cuaHang);
        }

        public bool Xoa(string maCH)
        {
            return dal_CH.Xoa(maCH);
        }
        public bool Sua(ET_CuaHang cuaHang)
        {
            return dal_CH.Sua(cuaHang);

        }
        public List<string> LayDanhSachMaCH()
        {
            return dal_CH.LayDanhSachMaCH();
        }
    }
}
