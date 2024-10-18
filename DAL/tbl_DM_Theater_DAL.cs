using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class tbl_DM_Theater_DAL : BasicMethods<tbl_DM_Theater_DTO>
    {

        /// <summary>
        /// Lấy danh sách các phòng chiếu
        /// </summary>
        /// <returns></returns>
        public override List<tbl_DM_Theater_DTO> GetList()
        {
            // Khởi tạo danh sách các phòng chiếu
            List<tbl_DM_Theater_DTO> list = new List<tbl_DM_Theater_DTO>();
            // Chuyển kiểu dữ liệu từ context sang DTO
            foreach (tbl_DM_Theater item in DBDataContext.tbl_DM_Theaters.ToList())
            {
                // Nếu không bị xóa khỏi context view thì thêm vào danh sách DTO
                if (item.DELETED != 1)
                {
                    // Thêm context vào danh sách DTO
                    list.Add(new tbl_DM_Theater_DTO(item.TT_AutoID, item.TT_NAME, item.TT_STATUS));
                }
            }
            return list;
        }

        public override bool AddData(tbl_DM_Theater_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool RemoveData(int id)
        {
            throw new NotImplementedException();
        }

        public override bool UpdateData(tbl_DM_Theater_DTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
