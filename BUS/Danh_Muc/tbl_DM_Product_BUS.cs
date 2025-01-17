﻿using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

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
        public List<tbl_DM_Product_DTO> GetAll(int deleted)
        {
            return data.GetAll(deleted);
        }

        // Lấy danh sách sản phẩm có thể bán
        public List<tbl_DM_Product_DTO> GetAvailable()
        {
            try
            {
                return data.GetAvailable();
            }catch(Exception ex)
            {
                throw ex;
            }
        }


        // Tìm kiếm Product theo ID
        public tbl_DM_Product_DTO Find(long id)
        {
            return data.Find(id);
        }
        // Tìm kiếm Product theo tên
        public tbl_DM_Product_DTO Find(string name)
        {
            return data.Find(name);
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
