using DTO.Common;
using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    /// <summary>
    /// CRUD danh mục Loại chi phí
    /// </summary>
    public class tbl_DM_ExpenseType_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        /// <summary>
        /// them 
        /// </summary>
        /// <param name="expenseType"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public long Add(tbl_DM_ExpenseType_DTO expenseType)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = new tbl_DM_ExpenseType
                    {
                        ET_NAME = expenseType.ET_NAME,
                        ET_PRODUCT_AutoID = expenseType.ET_PRODUCT_AutoID,

                        DELETED = 0,
                        CREATED = DateTime.Now,
                        CREATED_BY = CCommon.MaDangNhap,
                        CREATED_BY_FUNCTION = "Add",
                        UPDATED = DateTime.Now,
                        UPDATED_BY = CCommon.MaDangNhap,
                        UPDATED_BY_FUNCTION = "Add"
                    };
                    dbContext.tbl_DM_ExpenseTypes.InsertOnSubmit(entity);
                    dbContext.SubmitChanges();

                    return entity.ET_AutoID; // Trả về id vừa được thêm
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
                    var entity = dbContext.tbl_DM_ExpenseTypes.SingleOrDefault(t => t.ET_AutoID == id);

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
        /// <param name="expenseType"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Update(tbl_DM_ExpenseType_DTO expenseType)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_ExpenseTypes.SingleOrDefault(t => t.ET_AutoID == expenseType.ET_AutoID);
                    if (entity != null)
                    {
                        entity.ET_AutoID = expenseType.ET_AutoID;
                        entity.ET_NAME = expenseType.ET_NAME;
                        entity.ET_PRODUCT_AutoID = expenseType.ET_PRODUCT_AutoID;

                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = CCommon.MaDangNhap;
                        entity.UPDATED_BY_FUNCTION = "Update";
                        dbContext.SubmitChanges();
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
        public List<tbl_DM_ExpenseType_DTO> GetAll()
        {
            List<tbl_DM_ExpenseType_DTO> result = new List<tbl_DM_ExpenseType_DTO>();

            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var list = dbContext.tbl_DM_ExpenseTypes.ToList();
                    foreach (var item in list)
                    {
                        if (item.DELETED != 1)
                        {
                            tbl_DM_ExpenseType_DTO entity = new tbl_DM_ExpenseType_DTO()
                            {
                                ET_AutoID = item.ET_AutoID,
                                ET_NAME = item.ET_NAME,
                                ET_PRODUCT_AutoID = item.ET_PRODUCT_AutoID,
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
        public tbl_DM_ExpenseType_DTO Find(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    return dbContext.tbl_DM_ExpenseTypes
                        .Where(t => t.ET_AutoID == id)
                        .Select(item => new tbl_DM_ExpenseType_DTO
                        {
                            ET_NAME = item.ET_NAME,
                            ET_PRODUCT_AutoID = item.ET_PRODUCT_AutoID,
                        })
                        .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }
    }
}
