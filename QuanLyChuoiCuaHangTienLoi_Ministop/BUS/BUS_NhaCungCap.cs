using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        private DAL_NhaCungCap dal_NhaCungCap = new DAL_NhaCungCap();
        public List<ET_NhaCungCap> HienThiDuLieuSapXepGiamDanTheoMa()
        {
            return dal_NhaCungCap.HienThiDuLieuSapXepGiamDanTheoMa();
        }

        public bool Them(ET_NhaCungCap nhaCungCap)
        {
           return dal_NhaCungCap.Them(nhaCungCap);
        }

        public bool Xoa(string maNCC)
        {
           return dal_NhaCungCap.Xoa(maNCC);
        }
        public bool Sua(ET_NhaCungCap maNCC)

        {

           return dal_NhaCungCap.Sua(maNCC);
        }
        public List<string> LayDanhSachMaNCC()
        {
           return dal_NhaCungCap.LayDanhSachMaNCC();
        }
       
    }
}
