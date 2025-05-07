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
        public bool Them(ET_SanPham sanPham)
        {
            return dal_SP.Them(sanPham);
        }

        public bool Xoa(string maSP)
        {
            return dal_SP.Xoa(maSP);
        }
        public bool Sua(ET_SanPham sanPham)

        {
          return  dal_SP.Sua(sanPham);

        }
        public List<string> LayDanhSachMaSP()
        {
            
            return dal_SP.LayDanhSachMaSP();
        }
        public List<ET_SanPham> TimSanPhamBangTen(string name)
        {
           
                         
            return dal_SP.TimSanPhamBangTen(name);
        }
        public List<ET_SanPham> HienThiSanPhamBangLoaiSanPham(string loaiSP)
        {
           return dal_SP.HienThiSanPhamBangLoaiSanPham(loaiSP);
        }
    }
}
