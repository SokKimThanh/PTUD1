using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO.Custom;
using DTO.tbl_DTO;

namespace DAL
{
    public class tbl_DM_AgeRating_DAL : BasicMethods<tbl_DM_AgeRating_DAL>
    {

        // Thêm mới AgeRating
        public void Add(tbl_DM_AgeRating_DTO ageRating)
        {
            ExecuteDbOperation(dbContext =>
            {
                var entity = new tbl_DM_AgeRating
                {
                    AR_NAME = ageRating.AR_NAME,
                    AR_NOTE = ageRating.AR_NOTE
                };
                dbContext.tbl_DM_AgeRatings.InsertOnSubmit(entity);
                dbContext.SubmitChanges();
            });
        }

        // Xóa AgeRating
        public void Remove(long id)
        {
            ExecuteDbOperation(dbContext =>
            {
                var entity = dbContext.tbl_DM_AgeRatings.SingleOrDefault(t => t.AR_AutoID == id);
                if (entity != null)
                {
                    dbContext.tbl_DM_AgeRatings.DeleteOnSubmit(entity);
                    dbContext.SubmitChanges();
                }
            });
        }

        // Cập nhật AgeRating
        public void Update(tbl_DM_AgeRating_DTO ageRating)
        {
            ExecuteDbOperation(dbContext =>
            {
                var entity = dbContext.tbl_DM_AgeRatings.SingleOrDefault(t => t.AR_AutoID == ageRating.AR_AUTOID);
                if (entity != null)
                {
                    entity.AR_NAME = ageRating.AR_NAME;
                    entity.AR_NOTE = ageRating.AR_NOTE;
                    dbContext.SubmitChanges();
                }
            });
        }

        // Lấy danh sách AgeRating
        public List<tbl_DM_AgeRating_DTO> GetAll()
        {
            return ExecuteDbQuery(dbContext =>
                dbContext.tbl_DM_AgeRatings.Select(ar => new tbl_DM_AgeRating_DTO
                {
                    AR_AUTOID = ar.AR_AutoID,
                    AR_NAME = ar.AR_NAME,
                    AR_NOTE = ar.AR_NOTE
                }).ToList());
        }

        // Tìm kiếm AgeRating theo ID
        public tbl_DM_AgeRating_DTO Find(long id)
        {
            return ExecuteDbQuery(dbContext =>
                dbContext.tbl_DM_AgeRatings
                .Where(t => t.AR_AutoID == id)
                .Select(ar => new tbl_DM_AgeRating_DTO
                {
                    AR_AUTOID = ar.AR_AutoID,
                    AR_NAME = ar.AR_NAME,
                    AR_NOTE = ar.AR_NOTE
                })
                .SingleOrDefault());
        }

        // Hàm tiện ích để thực thi các thao tác DB (CRUD)
        private void ExecuteDbOperation(Action<CM_Cinema_DBDataContext> action)
        {
            try
            {

                action(DBDataContext);

            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi thao tác với DB: {ex.Message}");
            }
        }

        // Hàm tiện ích cho các truy vấn trả về dữ liệu
        private T ExecuteDbQuery<T>(Func<CM_Cinema_DBDataContext, T> query)
        {
            try
            {

                return query(DBDataContext);

            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi thực thi truy vấn với DB: {ex.Message}");
            }
        }

        public override bool AddData(tbl_DM_AgeRating_DAL obj)
        {
            throw new NotImplementedException();
        }
        public override bool RemoveData(int id)
        {
            throw new NotImplementedException();
        }
        public override List<tbl_DM_AgeRating_DAL> GetList()
        {
            throw new NotImplementedException();
        }

        public override bool UpdateData(tbl_DM_AgeRating_DAL obj)
        {
            throw new NotImplementedException();
        }
    }
}
