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
        public tbl_DM_AgeRating_DTO Find(long id)
        {
            return data.Find(id);
        }
    }
}
