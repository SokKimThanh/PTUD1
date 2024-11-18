using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace DAL
{
    /// <summary>
    /// CRUD danh mục chi phí
    /// </summary>
    public class tbl_SYS_Expense_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        /// <summary>
        /// them 
        /// </summary>
        /// <param name="expense"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public long Add(tbl_SYS_Expense_DTO expense)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = new tbl_SYS_Expense
                    {
                        EX_EXTYPE_AutoID = expense.EX_EXTYPE_AutoID,
                        EX_PRICE = expense.EX_PRICE,
                        EX_QUANTITY = expense.EX_QUANTITY,
                        EX_REASON = expense.EX_REASON,
                        EX_STATUS = expense.EX_STATUS,

                        DELETED = 0,
                        CREATED = DateTime.Now,
                        CREATED_BY = CCommon.MaDangNhap,
                        CREATED_BY_FUNCTION = "Add",
                        UPDATED = DateTime.Now,
                        UPDATED_BY = CCommon.MaDangNhap,
                        UPDATED_BY_FUNCTION = "Add"
                    };
                    dbContext.tbl_SYS_Expenses.InsertOnSubmit(entity);
                    dbContext.SubmitChanges();

                    UpdateQuantityProduct(expense.EX_EXTYPE_AutoID);// cập nhật số lượng tồn kho khi thêm chi phí

                    return entity.EX_AutoID; // Trả về id vừa được thêm
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
        /// <summary>
        /// xoa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Remove(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_SYS_Expenses.SingleOrDefault(t => t.EX_AutoID == id);

                    if (entity != null)
                    {
                        entity.DELETED = 1;
                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = CCommon.MaDangNhap;
                        entity.UPDATED_BY_FUNCTION = "Remove";
                        dbContext.SubmitChanges();
                        return true; // Thao tác thành công
                    }
                    return false; // Không tìm thấy entity để xóa
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
        /// <summary>
        /// cap nhat
        /// </summary>
        /// <param name="expense"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Update(tbl_SYS_Expense_DTO expense)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_SYS_Expenses.SingleOrDefault(t => t.EX_AutoID == expense.EX_AutoID);
                    if (entity != null)
                    {

                        entity.EX_AutoID = expense.EX_AutoID;
                        entity.EX_EXTYPE_AutoID = expense.EX_EXTYPE_AutoID;
                        entity.EX_PRICE = expense.EX_PRICE;
                        entity.EX_QUANTITY = expense.EX_QUANTITY;
                        entity.EX_REASON = expense.EX_REASON;
                        entity.EX_STATUS = expense.EX_STATUS;

                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = CCommon.MaDangNhap;
                        entity.UPDATED_BY_FUNCTION = "Update";
                        dbContext.SubmitChanges();
                        
                        

                        UpdateQuantityProduct(expense.EX_EXTYPE_AutoID); // cập nhật số lượng tồn kho khi sửa chi phí


                        return true; // Thao tác thành công
                    }
                    return false; // Không tìm thấy entity để cập nhật
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
        /// <summary>
        /// danh sach
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<tbl_SYS_Expense_DTO> GetAll()
        {
            List<tbl_SYS_Expense_DTO> result = new List<tbl_SYS_Expense_DTO>();

            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var list = dbContext.tbl_SYS_Expenses.ToList();
                    foreach (var item in list)
                    {
                        if (item.DELETED != 1)
                        {
                            tbl_SYS_Expense_DTO entity = new tbl_SYS_Expense_DTO()
                            {
                                EX_AutoID = item.EX_AutoID,
                                EX_STATUS = item.EX_STATUS,
                                EX_REASON = item.EX_REASON,
                                EX_PRICE = item.EX_PRICE,
                                EX_QUANTITY = item.EX_QUANTITY,
                                EX_EXTYPE_AutoID = item.EX_EXTYPE_AutoID,
                            };
                            result.Add(entity);
                        }
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
        /// <summary>
        /// tim 1 chi phi theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public tbl_SYS_Expense_DTO Find(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    return dbContext.tbl_SYS_Expenses
                        .Where(t => t.EX_AutoID == id)
                        .Select(item => new tbl_SYS_Expense_DTO
                        {
                            EX_AutoID = item.EX_AutoID,
                            EX_STATUS = item.EX_STATUS,
                            EX_REASON = item.EX_REASON,
                            EX_PRICE = item.EX_PRICE,
                            EX_QUANTITY = item.EX_QUANTITY,
                            EX_EXTYPE_AutoID = item.EX_EXTYPE_AutoID,
                        })
                        .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
        /// <summary>
        /// Cập nhật số lượng tồn kho của sản phẩm theo loại chi phí mỗi khi nhập thêm hàng mới
        /// </summary>
        /// <param name="id">ExpenseType_AutoID</param>
        /// <exception cref="Exception"></exception>
        private void UpdateQuantityProduct(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var expenseListByExpenseType = dbContext.tbl_SYS_Expenses.Where(item => item.EX_EXTYPE_AutoID == id).ToList();

                    var result = expenseListByExpenseType.Sum(item => item.EX_QUANTITY);

                    var expenseType = dbContext.tbl_DM_ExpenseTypes.SingleOrDefault(item => item.ET_AutoID == id);

                    var product = dbContext.tbl_DM_Products.SingleOrDefault(item => item.PD_AutoID == expenseType.ET_PRODUCT_AutoID);

                    product.PD_QUANTITY = result;

                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
        /// <summary>
        /// Số lượng tồn kho của sản phẩm theo loại chi phí hiện tại
        /// </summary>
        /// <param name="id">ExpenseType_AutoID</param>
        /// <exception cref="Exception"></exception>
        public double GetQuantityProduct(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var result = dbContext.tbl_SYS_Expenses.
                        Where(item => item.EX_EXTYPE_AutoID == id).
                        Sum(item => item.EX_QUANTITY);
                    var expenseType = dbContext.tbl_DM_ExpenseTypes.SingleOrDefault(item => item.ET_AutoID == id);
                    var product = dbContext.tbl_DM_Products.SingleOrDefault(item => item.PD_AutoID == expenseType.ET_PRODUCT_AutoID);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
    }
}
