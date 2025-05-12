using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietNhapHang
    {
        private DAL_ChiTietNhapHang dal_CTNhap = new DAL_ChiTietNhapHang();

        public List<ET_ChiTietNhapHang> HienThiTatCa()
        {
            return dal_CTNhap.HienThiTatCa();
        }

        public bool Them(ET_ChiTietNhapHang ct)
        {
            return dal_CTNhap.Them(ct);
        }

        public bool Xoa(string maPhieuNhap, string maSanPham)
        {
            return dal_CTNhap.Xoa(maPhieuNhap, maSanPham);
        }

        public bool Sua(ET_ChiTietNhapHang ct)
        {
            return dal_CTNhap.Sua(ct);
        }

        public List<ET_ChiTietNhapHang> LayChiTietTheoMaPhieu(string maPhieuNhap)
        {
            return dal_CTNhap.LayChiTietTheoMaPhieu(maPhieuNhap);
        }
    }
}
