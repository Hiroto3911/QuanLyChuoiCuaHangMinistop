using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class BUS_LichSuThayDoiGia
    {
        private DAL_LichSuThayDoiGia dal_LSG = new DAL_LichSuThayDoiGia();
        public List<ET_LichSuThayDoiGia> HienThiDuLieuSapXepGiamDanTheoMaCHVaMaSP(string maCH, string maSP)
        {
            
            
            return dal_LSG.HienThiDuLieuSapXepGiamDanTheoMaCHVaMaSP(maCH,maSP);
        }
        public bool Them(ET_LichSuThayDoiGia ls)
        {
            return dal_LSG.Them(ls);
        }

        public bool Xoa(string maCH, string maLS)
        {
            return dal_LSG.Xoa(maCH, maLS);
        }
        public bool Sua(ET_LichSuThayDoiGia ls)

        {

            return dal_LSG.Sua(ls);

        }
        public decimal TinhGiaCaSanPhamTrong1thang(ET_LichSuThayDoiGia ls, DateTime tgian)
        {
            return dal_LSG.TinhGiaCaSanPhamTrong1thang(ls, tgian);



        }


        public List<string> LayDanhSachMaLS()
        {
            return dal_LSG.LayDanhSachMaLS();
        }
    }
}
