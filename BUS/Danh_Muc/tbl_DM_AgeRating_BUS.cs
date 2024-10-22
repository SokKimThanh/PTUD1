using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_AgeRating_BUS
    {
        tbl_DM_AgeRating_DAL data = new tbl_DM_AgeRating_DAL();

        //Them
        public void Add(tbl_DM_AgeRating_DTO ageRating)
        {
            try
            {
                data.Add(ageRating);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xoa
        public void Remove(long id)
        {
            try
            {
                data.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Sua
        public void Update(tbl_DM_AgeRating_DTO ageRating)
        {
            try
            {
                data.Update(ageRating);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //LayDanhSach - lam moi
        public List<tbl_DM_AgeRating_DTO> GetAll()
        {
            try
            {
                return data.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Hàm lấy dgv_selected_id
        /// </summary>
        /// <param name="id">dgv_selected_id || cboAgeRating_selected_id</param>
        /// <returns></returns>
        public tbl_DM_AgeRating_DTO Find(long id)
        {
            return data.Find(id);
        }
        /// <summary>
        /// Lấy danh sách combobox
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_AgeRating_DTO> GetCombobox()
        {
            return data.GetCombobox();
        }
    }
}
