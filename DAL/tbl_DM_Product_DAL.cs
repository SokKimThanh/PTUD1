using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class tbl_DM_Product_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        // Thêm mới Product
        public long Add(tbl_DM_Product_DTO product)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = new tbl_DM_Product
                    {
                        DELETED = 0,
                        PD_NAME = product.PD_NAME,
                        PD_QUANTITY = product.PD_QUANTITY,
                        PD_IMAGEURL = product.PD_IMAGEURL,
                        PD_PRICE = product.PD_PRICE,


                        CREATED = DateTime.Now,
                        CREATED_BY = "Admin",
                        CREATED_BY_FUNCTION = "Add",
                        UPDATED = DateTime.Now,
                        UPDATED_BY = "admin",
                        UPDATED_BY_FUNCTION = "Add"
                    };
                    dbContext.tbl_DM_Products.InsertOnSubmit(entity);
                    dbContext.SubmitChanges();

                    return entity.PD_AutoID; // Trả về id vừa được thêm
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }

        // Xóa Product
        public bool Remove(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_Products.SingleOrDefault(t => t.PD_AutoID == id);

                    if (entity != null)
                    {
                        entity.DELETED = 1;
                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = "admin";
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

        // Cập nhật Product
        public bool Update(tbl_DM_Product_DTO product)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_Products.SingleOrDefault(t => t.PD_AutoID == product.PD_AutoID);
                    if (entity != null)
                    {
                        entity.PD_IMAGEURL = product.PD_IMAGEURL;
                        entity.PD_QUANTITY = product.PD_QUANTITY;
                        entity.PD_NAME = product.PD_NAME;
                        entity.PD_PRICE = product.PD_PRICE;

                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = "admin";
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

        // Lấy danh sách Product
        public List<tbl_DM_Product_DTO> GetAll()
        {
            List<tbl_DM_Product_DTO> result = new List<tbl_DM_Product_DTO>();
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var list = dbContext.tbl_DM_Products.ToList();

                    foreach (var item in list)
                    {
                        if (item.DELETED != 1)
                        {
                            tbl_DM_Product_DTO entity = new tbl_DM_Product_DTO()
                            {
                                PD_AutoID = item.PD_AutoID,
                                PD_IMAGEURL = item.PD_IMAGEURL,
                                PD_QUANTITY = item.PD_QUANTITY,
                                PD_NAME = item.PD_NAME,
                                PD_PRICE = item.PD_PRICE,
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
        // Tìm kiếm Product theo ID
        public tbl_DM_Product_DTO Find(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    return dbContext.tbl_DM_Products
                          .Where(t => t.PD_AutoID == id)
                          .Select(item => new tbl_DM_Product_DTO
                          {
                              PD_AutoID = item.PD_AutoID,
                              PD_IMAGEURL = item.PD_IMAGEURL,
                              PD_QUANTITY = item.PD_QUANTITY,
                              PD_NAME = item.PD_NAME,
                              PD_PRICE = item.PD_PRICE,
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
        /// Danh sách combobox phim
        /// </summary>
        /// <returns></returns>
        public List<tbl_DM_Product_DTO> GetCombobox()
        {
            List<tbl_DM_Product_DTO> result = new List<tbl_DM_Product_DTO>();
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var list = dbContext.tbl_DM_Products.ToList();

                    foreach (var item in list)
                    {
                        if (item.DELETED != 1)
                        {
                            tbl_DM_Product_DTO entity = new tbl_DM_Product_DTO(
                                pD_AutoID: item.PD_AutoID,
                                pD_NAME: item.PD_NAME
                                );

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
    }
}
