using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    /// <summary>
    /// Danh mục đánh giá độ tuổi
    /// </summary>
    public class tbl_DM_AgeRating_DTO
    {
        private string aR_NAME, aR_NOTE;

        public tbl_DM_AgeRating_DTO()
        {
        }

        public tbl_DM_AgeRating_DTO(string aR_NAME, string aR_NOTE)
        {
            this.AR_NAME = aR_NAME;
            this.AR_NOTE = aR_NOTE;
        }

        public string AR_NAME
        {
            get => aR_NAME; set
            {
                aR_NAME = value;
            }
        }
        public string AR_NOTE
        {
            get => aR_NOTE; set
            {
                aR_NOTE = value;
            }
        }
    }
}
