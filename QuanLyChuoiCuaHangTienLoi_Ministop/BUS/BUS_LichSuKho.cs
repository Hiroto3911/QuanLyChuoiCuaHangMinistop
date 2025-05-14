using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BUS
{
    public class BUS_LichSuKho
    {
        private DAL_LichSuKho dal = new DAL_LichSuKho();

        // Hiển thị toàn bộ lịch sử kho
        public List<ET_LichSuKho> LayTatCaLichSuKho()
        {
            return dal.HienThiTatCa();
        }

        // Thêm mới một mục lịch sử kho
        public bool ThemLichSuKho(ET_LichSuKho lichSuKho)
        {
            if (lichSuKho == null)
                return false;

            return dal.Them(lichSuKho);
        }

        // Xoá một mục lịch sử kho theo mã
        public bool XoaLichSuKho(string maLichSuKho)
        {
            if (string.IsNullOrEmpty(maLichSuKho))
                return false;

            return dal.Xoa(maLichSuKho);
        }

        public List<ET_LichSuKho> LayLichSuKhoTheoMaCTK(string maCTK)
        {
            return dal.LayLichSuTheoMaCTK(maCTK);
        }
        public List<ET_LichSuKho> LayLichSuTheoMaLoai(string maCTK, string loaiThayDoi)
        {
            return dal.LayLichSuTheoMaLoai(maCTK, loaiThayDoi);
        }
        public List<string> LayDanhSachMaLSK()
        {
            return dal.LayDanhSachMaLSK();
        }
    }
}
