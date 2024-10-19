using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO.Custom;
using DTO.tbl_DTO;

namespace DAL
{
    public class tbl_DM_AgeRating_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        // Thêm mới AgeRating
        public void Add(tbl_DM_AgeRating_DTO ageRating)
        {

            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = new tbl_DM_AgeRating
                    {
                        DELETED = 0,
                        AR_NAME = ageRating.AR_NAME,
                        AR_NOTE = ageRating.AR_NOTE,
                        CREATED = DateTime.Now,
                        CREATED_BY = "Admin",
                        CREATED_BY_FUNCTION = "Add",
                        UPDATED = DateTime.Now,
                        UPDATED_BY = "admin",
                        UPDATED_BY_FUNCTION = "Add"
                    };
                    dbContext.tbl_DM_AgeRatings.InsertOnSubmit(entity);
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }

        // Xóa AgeRating
        public void Remove(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_AgeRatings.SingleOrDefault(t => t.AR_AutoID == id);

                    if (entity != null)
                    {
                        entity.DELETED = 1;
                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = "admin";
                        entity.UPDATED_BY_FUNCTION = "Remove";
                        dbContext.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }

        // Cập nhật AgeRating
        public void Update(tbl_DM_AgeRating_DTO ageRating)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_AgeRatings.SingleOrDefault(t => t.AR_AutoID == ageRating.AR_AUTOID);
                    if (entity != null)
                    {
                        entity.AR_NAME = ageRating.AR_NAME;
                        entity.AR_NOTE = ageRating.AR_NOTE;
                        entity.UPDATED = DateTime.Now;
                        entity.UPDATED_BY = "admin";
                        entity.UPDATED_BY_FUNCTION = "Update";
                        dbContext.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }

        // Lấy danh sách AgeRating
        public List<tbl_DM_AgeRating_DTO> GetAll()
        {
            List<tbl_DM_AgeRating_DTO> result = new List<tbl_DM_AgeRating_DTO>();
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var list = dbContext.tbl_DM_AgeRatings.ToList();

                    foreach (var item in list)
                    {
                        if (item.DELETED != 1)
                        {
                            tbl_DM_AgeRating_DTO entity = new tbl_DM_AgeRating_DTO()
                            {
                                AR_AUTOID = item.AR_AutoID,
                                AR_NAME = item.AR_NAME,
                                AR_NOTE = item.AR_NOTE
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

        // Tìm kiếm AgeRating theo ID
        public tbl_DM_AgeRating_DTO Find(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    return dbContext.tbl_DM_AgeRatings
                          .Where(t => t.AR_AutoID == id)
                          .Select(ar => new tbl_DM_AgeRating_DTO
                          {
                              AR_AUTOID = ar.AR_AutoID,
                              AR_NAME = ar.AR_NAME,
                              AR_NOTE = ar.AR_NOTE
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
