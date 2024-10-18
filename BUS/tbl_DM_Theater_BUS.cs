using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tbl_DM_Theater_BUS
    {
        private tbl_DM_Theater_DAL dal = new tbl_DM_Theater_DAL();
        public bool AddData(tbl_DM_Theater_DTO obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lấy danh sách các phòng chiếu
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<tbl_DM_Theater_DTO> GetList()
        {
            return dal.GetList();
        }

        public bool RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateData(tbl_DM_Theater_DTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
