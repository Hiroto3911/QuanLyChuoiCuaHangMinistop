using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_DangNhap
    {
        ET_NhanVien nv = new ET_NhanVien();
        private DB_QuanLyChuoiCuaHangTienLoiMinistopDataContext db = DB_Context_Custom.getDataContext();
        /// <summary>
        /// Hàm dùng để kiểm tra tài khoản mà người dùng đăng nhập
        /// </summary>
        /// <param name="taiKhoan">tài khoản người dùng nhập</param>
        /// <param name="matKhau">mật khẩu người dùng nhập </param>
        /// <returns>true nếu tài khoản và mật khẩu trùng khớp và ngược lại là false</returns>
        public bool KiemTraDangNhap(string taiKhoan, string matKhau, string vaiTro)
        {
            var user = db.NhanViens.Where(nv => nv.VaiTro == vaiTro && nv.TaiKhoan == taiKhoan).FirstOrDefault();// lấy ra người dùng có tài khoản trùng khớp
            if (user == null) return false;// nếu không có trả về false
            return SimpleHash.Verify(matKhau, user.MatKhau);

        }
    }
}
