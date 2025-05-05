using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;// chứa lớp mã hoá sha256
using System.Text; // dùng để chuyển chuỗi thành mảng byte

namespace ET
{
    public class SimpleHash
    {
        /// <summary>
        /// Hàm dùng để mã hoá mật khẩu
        /// </summary>
        /// <param name="input">là trường mật khẩu cần mã hoá </param>
        /// <returns>chuỗi pass đã được mã hoá</returns>
        public static string hash(string input)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input); // chuyển chuỗi pass thành mảng byte
                byte[] hash = sha.ComputeHash(bytes);// dùng sha để băm mảng byte
                return Convert.ToBase64String(hash);// mã hoá mảng byte thành chuỗi

            }
        }
        /// <summary>
        /// Hàm dùng để xác thực mật khẩu có trùng khớp không
        /// </summary>
        /// <param name="input">mật khẩu vừa nhập </param>
        /// <param name="hashBase64">mật khẩu đã được mã hoá </param>
        /// <returns>true nếu mật khẩu khớp với chuỗi mã hoá và ngược lại là false</returns>
        public static bool Verify(string input, string hashBase64)
        {
            return hash(input) == hashBase64;
        }
    }
}
