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
        private long pD_AutoID;
        private string pD_NAME, pD_IMAGEURL;
        private float pD_QUANTITY, pD_PRICE;

        public tbl_DM_Product_DTO()
        {
        }

        /// <summary>
        /// constructor for combobox
        /// </summary>
        /// <param name="pD_AutoID"></param>
        /// <param name="pD_NAME"></param>
        public tbl_DM_Product_DTO(long pD_AutoID, string pD_NAME)
        {
            this.pD_AutoID = pD_AutoID;
            this.pD_NAME = pD_NAME;
        }

        public tbl_DM_Product_DTO(string pD_NAME = null, string pD_IMAGEURL = null, float pD_QUANTITY = 0, float pD_PRICE = 0, long pD_AutoID = 0)
        {
            this.pD_NAME = pD_NAME;
            this.pD_IMAGEURL = pD_IMAGEURL;
            this.pD_QUANTITY = pD_QUANTITY;
            this.pD_PRICE = pD_PRICE;
            this.pD_AutoID = pD_AutoID;
        }

        public string PD_NAME
        {
            get => pD_NAME;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 250)
                {
                    pD_NAME = value;
                }
                else
                {
                    throw new ArgumentException("PD_NAME không được để trống và bắt buộc nhỏ hơn hoặc bằng 250 kí tự.");
                }
            }
        }

        public string PD_IMAGEURL
        {
            get => pD_IMAGEURL;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    pD_IMAGEURL = value;
                }
                else
                {
                    throw new ArgumentException("PD_IMAGEURL không được để trống");
                }
            }
        }

        public float PD_QUANTITY
        {
            get => pD_QUANTITY;
            set
            {
                if (value >= 0)
                {
                    pD_QUANTITY = value;
                }
                else
                {
                    throw new ArgumentException("PD_QUANTITY bắt buộc lớn hơn hoặc bằng 0");
                }
            }
        }

        public float PD_PRICE
        {
            get => pD_PRICE;
            set
            {
                if (value >= 0)
                {
                    pD_PRICE = value;
                }
                else
                {
                    throw new ArgumentException("PD_PRICE must be greater than or equal to 0.");
                }
            }
        }

        public long PD_AutoID
        {
            get => pD_AutoID;
            set
            {
                if (value > 0)
                {
                    pD_AutoID = value;
                }
                else
                {
                    throw new ArgumentException("PD_AutoID must be greater than 0.");
                }
            }
        }

    }
}
