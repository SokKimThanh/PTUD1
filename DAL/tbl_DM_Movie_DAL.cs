using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO.Custom;
using DTO.tbl_DTO;

namespace DAL
{
    public class tbl_DM_Movie_DAL
    {
        private readonly string _connectionString = CConfig.CM_Cinema_DB_ConnectionString;

        // Thêm mới Movie
        public long Add(tbl_DM_Movie_DTO movie)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = new tbl_DM_Movie
                    {
                        DELETED = 0,
                        MV_NAME = movie.MV_NAME,
                        MV_DESCRIPTION = movie.MV_DESCRIPTION,
                        MV_DURATION = movie.MV_DURATION,
                        MV_POSTERURL = movie.MV_POSTERURL,
                        MV_PRICE = movie.MV_PRICE,
                        MV_AGERATING_AutoID = movie.MV_AGERATING_AutoID,


                        CREATED = DateTime.Now,
                        CREATED_BY = "Admin",
                        CREATED_BY_FUNCTION = "Add",
                        UPDATED = DateTime.Now,
                        UPDATED_BY = "admin",
                        UPDATED_BY_FUNCTION = "Add"
                    };
                    dbContext.tbl_DM_Movies.InsertOnSubmit(entity);
                    dbContext.SubmitChanges();

                    return entity.MV_AutoID; // Trả về id vừa được thêm
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }

        // Xóa Movie
        public bool Remove(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_Movies.SingleOrDefault(t => t.MV_AutoID == id);

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

        // Cập nhật Movie
        public bool Update(tbl_DM_Movie_DTO movie)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var entity = dbContext.tbl_DM_Movies.SingleOrDefault(t => t.MV_AutoID == movie.MV_AutoID);
                    if (entity != null)
                    {
                        entity.MV_POSTERURL = movie.MV_POSTERURL;
                        entity.MV_DESCRIPTION = movie.MV_DESCRIPTION;
                        entity.MV_DURATION = movie.MV_DURATION;
                        entity.MV_NAME = movie.MV_NAME;
                        entity.MV_PRICE = movie.MV_PRICE;
                        entity.MV_AGERATING_AutoID = movie.MV_AGERATING_AutoID;

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

        // Lấy danh sách Movie
        public List<tbl_DM_Movie_DTO> GetAll()
        {
            List<tbl_DM_Movie_DTO> result = new List<tbl_DM_Movie_DTO>();
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    var list = dbContext.tbl_DM_Movies.ToList();

                    foreach (var item in list)
                    {
                        if (item.DELETED != 1)
                        {
                            tbl_DM_Movie_DTO entity = new tbl_DM_Movie_DTO()
                            {
                                MV_AutoID = item.MV_AutoID,
                                MV_POSTERURL = item.MV_POSTERURL,
                                MV_DESCRIPTION = item.MV_DESCRIPTION,
                                MV_DURATION = item.MV_DURATION,
                                MV_NAME = item.MV_NAME,
                                MV_PRICE = item.MV_PRICE,
                                MV_AGERATING_AutoID = item.MV_AGERATING_AutoID,
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

        // Tìm kiếm Movie theo ID
        public tbl_DM_Movie_DTO Find(long id)
        {
            try
            {
                using (var dbContext = new CM_Cinema_DBDataContext(_connectionString))
                {
                    return dbContext.tbl_DM_Movies
                          .Where(t => t.MV_AutoID == id)
                          .Select(item => new tbl_DM_Movie_DTO
                          {
                              MV_AutoID = item.MV_AutoID,
                              MV_POSTERURL = item.MV_POSTERURL,
                              MV_DESCRIPTION = item.MV_DESCRIPTION,
                              MV_DURATION = item.MV_DURATION,
                              MV_NAME = item.MV_NAME,
                              MV_PRICE = item.MV_PRICE,
                              MV_AGERATING_AutoID = item.MV_AGERATING_AutoID,
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
