using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_XuatHang
    {
        private DAL_XuatHang dal = new DAL_XuatHang();

       
        public List<ET_XuatHang> HienThiDuLieuTheoMaCH(string maCH)
        {
            return dal.HienThiDuLieuTheoMaCH(maCH);
        }
    

        public bool Them(ET_XuatHang px)
        {
            return dal.Them(px);
        }

        public bool Xoa(string maPX)
        {
            return dal.Xoa(maPX);
        }

        public bool Sua(ET_XuatHang px)
        {
            return dal.Sua(px);
        }
        public List<string> LayDanhSachMaXH()
        {
            return dal.LayDanhSachMaXH();
        }
    }
}
