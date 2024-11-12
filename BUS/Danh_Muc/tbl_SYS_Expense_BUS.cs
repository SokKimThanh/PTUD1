using DAL;
using DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Danh_Muc
{
    /// <summary>
    /// Connection CRUD Danh mục chi phí
    /// </summary>
    public class tbl_SYS_Expense_BUS
    {
        private tbl_SYS_Expense_DAL data = new tbl_SYS_Expense_DAL();

        /// <summary>
        /// them 
        /// </summary>
        /// <param name="expense"></param>
        /// <returns></returns>
        public long Add(tbl_SYS_Expense expense)
        {
            return data.Add(expense);
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
        /// <param name="expense"></param>
        /// <returns></returns>
        public bool Update(tbl_SYS_Expense expense)
        {
            return data.Update(expense);
        }
        /// <summary>
        /// danh sach
        /// </summary>
        /// <returns></returns>
        public List<tbl_SYS_Expense> GetAll()
        {
            return data.GetAll();
        }
        /// <summary>
        /// tim 1 chi phi theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tbl_SYS_Expense Find(long id)
        {
            return data.Find(id);
        }
    }
}
