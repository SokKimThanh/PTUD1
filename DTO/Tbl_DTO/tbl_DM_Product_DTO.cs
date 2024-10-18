using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.tbl_DTO
{
    /// <summary>
    /// Danh mục sản phẩm
    /// </summary>
    public class tbl_DM_Product_DTO
    {
        private string pD_NAME, pD_IMAGEURL;
        private float pD_QUANTITY, pD_PRICE;

        public tbl_DM_Product_DTO()
        {
        }

        public tbl_DM_Product_DTO(string pD_NAME = null, string pD_IMAGEURL = null, float pD_QUANTITY = 0, float pD_PRICE = 0)
        {
            this.pD_NAME = pD_NAME;
            this.pD_IMAGEURL = pD_IMAGEURL;
            this.pD_QUANTITY = pD_QUANTITY;
            this.pD_PRICE = pD_PRICE;
        }

        public string PD_NAME { get => pD_NAME; set => pD_NAME = value; }
        public string PD_IMAGEURL { get => pD_IMAGEURL; set => pD_IMAGEURL = value; }
        public float PD_QUANTITY { get => pD_QUANTITY; set => pD_QUANTITY = value; }
        public float PD_PRICE { get => pD_PRICE; set => pD_PRICE = value; }
    }
}
