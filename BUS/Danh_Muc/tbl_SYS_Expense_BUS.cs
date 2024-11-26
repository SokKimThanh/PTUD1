using DAL;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;

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
        public long Add(tbl_SYS_Expense_DTO expense)
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
        public bool Update(tbl_SYS_Expense_DTO expense)
        {
            return data.Update(expense);
        }
        /// <summary>
        /// danh sach
        /// </summary>
        /// <returns></returns>
        public List<tbl_SYS_Expense_DTO> GetAll()
        {
            return data.GetAll();
        }
        /// <summary>
        /// tim 1 chi phi theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tbl_SYS_Expense_DTO Find(long id)
        {
            return data.Find(id);
        }
        /// <summary>
        /// Số lượng tồn kho của sản phẩm theo loại chi phí hiện tại
        /// </summary>
        /// <param name="id">ExpenseType_AutoID</param>
        /// <exception cref="Exception"></exception>
        public double GetQuantityProduct(long id)
        {
            return data.GetQuantityProduct(id);
        }
    }
}
