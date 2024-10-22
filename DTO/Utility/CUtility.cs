using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Utility
{
    public sealed class CUtility
    {
        /// <summary>
        /// Hàm này dùng để mã hóa 1 chuỗi kí tự thành chuẩn MD 5
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static string MD5_Encrypt(string strData)
        {
            // Bước 1: Tạo đối tượng MD5
            using (MD5 objMD5 = MD5.Create())
            {
                // Bước 2: Chuyển chuỗi đầu vào thành mảng byte
                byte[] arrBytes = Encoding.UTF8.GetBytes(strData);

                // Bước 3: Mã hóa mảng byte bằng MD5
                byte[] arrHashBytes = objMD5.ComputeHash(arrBytes);

                // Bước 4: Chuyển kết quả hash thành chuỗi dạng hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte bByte in arrHashBytes)
                {
                    sb.Append(bByte.ToString("x2")); // "x2" định dạng byte thành 2 ký tự hex
                }

                // Trả về chuỗi đã mã hóa
                return sb.ToString();
            }

        }

        public static void Clone_Entity(object objSource, object objTarget)
        {
            // Lấy danh sách các thuộc tính của objSource và objTarget
            PropertyInfo[] arrPropSources = objSource.GetType().GetProperties();
            PropertyInfo[] arrPropTarget = objTarget.GetType().GetProperties();

            // Duyệt qua từng thuộc tính của objSource
            foreach (PropertyInfo objPropSoucre in arrPropSources)
            {
                // Tìm thuộc tính tương ứng trong objTarget theo tên
                PropertyInfo objPropTarget = arrPropTarget.FirstOrDefault(p => p.Name == objPropSoucre.Name);

                // Kiểm tra nếu thuộc tính có thể đọc từ source và ghi vào target
                if (objPropTarget != null && objPropTarget.CanWrite && objPropSoucre.CanRead)
                {
                    // Lấy giá trị từ objSource
                    object objValue = objPropSoucre.GetValue(objSource);

                    // Gán giá trị vào objTarget
                    objPropTarget.SetValue(objTarget, objValue);
                }
            }
        }

    }
}
