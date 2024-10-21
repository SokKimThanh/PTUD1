using DAL;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Product_BUS
    {
        private tbl_DM_Product_DAL data = new tbl_DM_Product_DAL();

        // Thêm mới Product
        public long Add(tbl_DM_Product_DTO product)
        {
            return data.Add(product);
        }

        // Xóa Product
        public bool Remove(long id)
        {
            return data.Remove(id);
        }

        // Cập nhật Product
        public bool Update(tbl_DM_Product_DTO product)
        {
            return data.Update(product);
        }

        // Lấy danh sách Product
        public List<tbl_DM_Product_DTO> GetAll()
        {
            return data.GetAll();
        }
        // Tìm kiếm Product theo ID
        public tbl_DM_Product_DTO Find(long id)
        {
            return data.Find(id);
        }
        /// <summary>
        /// Danh sách combobox phim
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_Product_DTO> GetCombobox()
        {
            return data.GetCombobox();
        }
    }
}
