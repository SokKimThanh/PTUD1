using DTO.Custom;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tbl_DM_Movie_DAL
    {
        //Them
        public void Add(tbl_DM_Movie_DTO movie)
        {
            try
            {
                // Ket noi db giải phóng bộ nhớ
                using (CM_Cinema_DBDataContext dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    tbl_DM_Movie tbl_DM_Movie = new tbl_DM_Movie()
                    {
                        MV_DESCRIPTION = movie.MV_DESCRIPTION,
                        MV_NAME = movie.MV_NAME,
                        MV_DURATION = movie.MV_DURATION,
                        MV_POSTERURL = movie.MV_POSTERURL,
                        MV_PRICE = movie.MV_PRICE,
                    };
                    dbContext.tbl_DM_Movies.InsertOnSubmit(tbl_DM_Movie);
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xoa
        public void Remove(long id)
        {
            try
            {
                // Ket noi db giải phóng bộ nhớ
                using (CM_Cinema_DBDataContext dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    var movie = dbContext.tbl_DM_Movies.Where(t => t.MV_AutoID == id).FirstOrDefault();
                    dbContext.tbl_DM_Movies.DeleteOnSubmit(movie);
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Sua
        public void Update(tbl_DM_Movie_DTO movie)
        {
            try
            {
                using (CM_Cinema_DBDataContext dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    var _movie = dbContext.tbl_DM_Movies.SingleOrDefault(t => t.MV_AutoID == movie.MV_AutoID);
                    _movie.MV_NAME = movie.MV_NAME;
                    _movie.MV_DURATION = movie.MV_DURATION;
                    _movie.MV_POSTERURL = movie.MV_POSTERURL;
                    _movie.MV_DESCRIPTION  = movie.MV_DESCRIPTION;
                    _movie.MV_PRICE = movie.MV_PRICE;
                    dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //LayDanhSach - lam moi
        public List<tbl_DM_Movie_DTO> GetAll()
        {
            List<tbl_DM_Movie_DTO> tbl_DM_Movies = new List<tbl_DM_Movie_DTO>();
            try
            {
                using (CM_Cinema_DBDataContext dbContext = new CM_Cinema_DBDataContext(CConfig.CM_Cinema_DB_ConnectionString))
                {
                    var movies = dbContext.tbl_DM_Movies.ToList();

                    // Ánh xạ dữ liệu từ thực thể sang DTO
                    tbl_DM_Movies = movies.Select(ob => new tbl_DM_Movie_DTO
                    {
                        MV_AutoID = ob.MV_AutoID,
                        MV_NAME = ob.MV_NAME,
                        MV_DESCRIPTION = ob.MV_DESCRIPTION,
                        MV_POSTERURL = ob.MV_POSTERURL,
                        MV_DURATION = ob.MV_DURATION,
                        MV_PRICE = ob.MV_PRICE,
                    }).ToList();

                    return tbl_DM_Movies; // Trả về List<tbl_DM_Movie_DTO>
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
