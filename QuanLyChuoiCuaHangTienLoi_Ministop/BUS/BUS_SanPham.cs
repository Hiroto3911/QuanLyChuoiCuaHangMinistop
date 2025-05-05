using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SanPham
    {
        private DAL_SanPham dal_SP = new DAL_SanPham();
        public List<ET_SanPham> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            return dal_SP.HienThiDuLieuSapXepGiamDanTheoMa();
        }
        public string TimTenSPBangMaSP(string maSP)
        {
            
            return dal_SP.TimTenSPBangMaSP(maSP);
        }
    }
}
