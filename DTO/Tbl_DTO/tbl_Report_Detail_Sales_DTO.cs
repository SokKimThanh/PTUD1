using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    public class tbl_Report_Detail_Sales_DTO
    {
        /// <summary>
        /// Tên phim
        /// </summary>
        public string MovieName { get; set; }
        /// <summary>
        /// Thời gian chiếu
        /// </summary>
        public DateTime ShowTime { get; set; }
        /// <summary>
        /// Giá vé
        /// </summary>
        public decimal TicketPrice { get; set; }
        /// <summary>
        /// Thời gian bán
        /// </summary>
        public DateTime? SaleTime { get; set; }
        /// <summary>
        /// Phòng chiếu
        /// </summary>
        public string TheaterName { get; set; }
    }
}
