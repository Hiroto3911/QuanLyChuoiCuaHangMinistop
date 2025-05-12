using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaoMaTuDong
    {
        /// <summary>
        /// Hàm tạo mã 
        /// </summary>
        /// <param name="DanhSachMa"> danh sách mã </param>
        /// <param name="tienTo">tiền tố của mã đó VD NV001 Thì NV là tiền tố</param>
        /// <returns> mã số </returns>
        public static string TaoMa(List<string>DanhSachMa,string tienTo)
        {
            // lấy ra mã cuối có chứa số lớn nhất
            var maCuoi = DanhSachMa.Where(ma => ma.StartsWith(tienTo)).OrderByDescending(ma => ma).FirstOrDefault();
            if(maCuoi != null)
            {
                string soCuoi = maCuoi.Substring(tienTo.Length);
                int stt = int.Parse(soCuoi)+1;
                int length = soCuoi.Length;
                return tienTo + stt.ToString($"D{length}");
            }
            return tienTo + "1";

        }
    }
}
