using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhapHang
    {
        private DAL_NhapHang dal_NhapHang = new DAL_NhapHang();

        // Hiển thị tất cả phiếu nhập
        public List<ET_NhapHang> HienThiDuLieuTheoMaCH(string maCH)
        {
            return dal_NhapHang.HienThiDuLieuTheoMaCH(maCH);
        }

        // Thêm phiếu nhập mới
        public bool Them(ET_NhapHang phieuNhap)
        {
            return dal_NhapHang.Them(phieuNhap);
        }

        // Xoá phiếu nhập theo mã
        public bool Xoa(string maPhieuNhap)
        {
            return dal_NhapHang.Xoa(maPhieuNhap);
        }

        // Sửa thông tin phiếu nhập
        public bool Sua(ET_NhapHang phieuNhap)
        {
            return dal_NhapHang.Sua(phieuNhap);
        }

        public List<string> LayDanhSachMaNH()
        {
            return dal_NhapHang.LayDanhSachMaNH();
        }
    }
}
