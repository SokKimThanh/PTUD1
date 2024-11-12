using DAL;
using DTO.Common;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    /// <summary>
    /// Connection CRUD Danh mục Loại chi phí
    /// </summary>
    public class tbl_DM_ExpenseType_BUS
    {
        private tbl_DM_ExpenseType_DAL data = new tbl_DM_ExpenseType_DAL();

        /// <summary>
        /// them 
        /// </summary>
        /// <param name="expenseType"></param>
        /// <returns></returns>
        public long Add(tbl_DM_ExpenseType_DTO expenseType)
        {
            return data.Add(expenseType);
        }
        /// <summary>
        /// xoa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remove(long id)
        {
            return data.Remove(id);
        }
        /// <summary>
        /// cap nhat
        /// </summary>
        /// <param name="expenseType"></param>
        /// <returns></returns>
        public bool Update(tbl_DM_ExpenseType_DTO expenseType)
        {
            return data.Update(expenseType);
        }
        /// <summary>
        /// danh sach
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_ExpenseType_DTO> GetAll()
        {
            return data.GetAll();
        }
        /// <summary>
        /// tim 1 chi phi theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tbl_DM_ExpenseType_DTO Find(long id)
        {
            return data.Find(id);
        }
    }
}
