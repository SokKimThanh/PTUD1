using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS.Danh_Muc
{
    public class tbl_DM_Theater_BUS
    {
        private tbl_DM_Theater_DAL dal = new tbl_DM_Theater_DAL();

        /// <summary>
        /// Thêm dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void AddData(tbl_DM_Theater_DTO obj)
        {
            try
            {
                tbl_DM_Theater_DTO theater_Found = dal.FindByName(obj.Name);
                if (theater_Found == null)
                {
                    dal.AddData(obj);
                }
                else
                {
                    if (theater_Found.Deleted == 0)
                        throw new Exception(theater_Found.Name + " đã có trong danh sách !");
                    else
                    {
                        theater_Found.Deleted = 0;
                        theater_Found.Status = obj.Status;
                        dal.UpdateData(theater_Found);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách các phòng chiếu
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<tbl_DM_Theater_DTO> GetList()
        {
            try
            {
                return dal.GetList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Ẩn dữ liệu khỏi view
        /// </summary>
        /// <param name="id"></param>
        public void RemoveData(int id)
        {
            try
            {
                dal.RemoveData(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Cập nhật thông tin dữ liệu
        /// </summary>
        /// <param name="obj"></param>
        public void UpdateData(tbl_DM_Theater_DTO obj)
        {
            try
            {
                dal.UpdateData(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_DM_Theater_DTO FindByID(long id)
        {
            try
            {
                return dal.FindByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
