using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BaoCao
    {
        private DAL_BaoCao dal_BaoCao = new DAL_BaoCao();
        public List<ET_DoanhThuCuaHangTheoThang> BaoCaoDoanhThuCuaHangTheoThang(string maCH =null)
        {
            
            return dal_BaoCao.BaoCaoDoanhThuCuaHangTheoThang(maCH);

        }
        public List<ET_TongDoanhThu> TongDoanhThuTheoThang()
        {
            return dal_BaoCao.TongDoanhThuTheoThang();
        }
        public List<ET_BaoCaoTonKho> BaoCaoTonKhoTrongCuaHang(int nam, int thang, string maCH)
        {
            
            return dal_BaoCao.BaoCaoTonKhoTrongCuaHang(nam,thang,maCH);


        }
    }
}
