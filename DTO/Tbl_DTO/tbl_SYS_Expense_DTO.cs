using System;

namespace DTO.tbl_DTO
{
    /// <summary>
    /// Danh mục quản lý chi phí
    /// </summary>
    public class tbl_SYS_Expense_DTO
    {
        private long eX_AutoID;
        private long eX_EXTYPE_AutoID;
        private double eX_QUANTITY;
        private double eX_PRICE;
        private string eX_REASON;
        private int? eX_STATUS;
        private int deleted;
        private DateTime created;
        private string createdBy;
        private string createdByFunction;
        private DateTime updated;
        private string updatedBy;
        private string updatedByFunction;

        public tbl_SYS_Expense_DTO()
        {
        }


        public tbl_SYS_Expense_DTO(long eX_AutoID, long eX_EXTYPE_AutoID, double eX_QUANTITY, double eX_PRICE, string eX_REASON, int eX_STATUS)
        {
            this.eX_AutoID = eX_AutoID;
            this.eX_EXTYPE_AutoID = eX_EXTYPE_AutoID;
            this.eX_QUANTITY = eX_QUANTITY;
            this.eX_PRICE = eX_PRICE;
            this.eX_REASON = eX_REASON;
            this.eX_STATUS = eX_STATUS;
        }

        public long EX_AutoID { get => eX_AutoID; set => eX_AutoID = value; }
        public long EX_EXTYPE_AutoID { get => eX_EXTYPE_AutoID; set => eX_EXTYPE_AutoID = value; }
        public double EX_QUANTITY
        {
            get => eX_QUANTITY;
            set
            {
                if (value >= 0)
                    eX_QUANTITY = value;
                else
                    throw new ArgumentException("EX_QUANTITY phải lớn hơn hoặc bằng 0.");
            }
        }

        public double EX_PRICE
        {
            get => eX_PRICE;
            set
            {
                if (value >= 0)
                    eX_PRICE = value;
                else
                    throw new ArgumentException("EX_PRICE phải lớn hơn hoặc bằng 0.");
            }
        }


        public string EX_REASON
        {
            get => eX_REASON;
            set
            {
                if (value.Length <= 100)
                    eX_REASON = value;
                else
                    throw new ArgumentException("EX_REASON không được dài hơn 100 ký tự.");
            }
        }

        public int? EX_STATUS
        {
            get => eX_STATUS;
            set
            {
                // Giả sử EX_STATUS chỉ có các giá trị từ 0 đến 3
                if (value >= 0 && value <= 3)
                    eX_STATUS = value;
                else
                    throw new ArgumentException("EX_STATUS chỉ được phép có giá trị từ 0 đến 3.");
            }
        }

        // Các property với ràng buộc dữ liệu bổ sung
        public int DELETED
        {
            get => deleted;
            set
            {
                if (value == 0 || value == 1) // Giả sử DELETED là 0 hoặc 1 để biểu thị trạng thái
                    deleted = value;
                else
                    throw new ArgumentException("DELETED chỉ được phép là 0 hoặc 1.");
            }
        }

        public DateTime CREATED
        {
            get => created;
            set => created = value;
        }

        public string CREATED_BY
        {
            get => createdBy;
            set
            {
                if (value.Length <= 50)
                    createdBy = value;
                else
                    throw new ArgumentException("CREATED_BY không được dài hơn 50 ký tự.");
            }
        }

        public string CREATED_BY_FUNCTION
        {
            get => createdByFunction;
            set
            {
                if (value.Length <= 100)
                    createdByFunction = value;
                else
                    throw new ArgumentException("CREATED_BY_FUNCTION không được dài hơn 100 ký tự.");
            }
        }

        public DateTime UPDATED
        {
            get => updated;
            set => updated = value;
        }

        public string UPDATED_BY
        {
            get => updatedBy;
            set
            {
                if (value.Length <= 50)
                    updatedBy = value;
                else
                    throw new ArgumentException("UPDATED_BY không được dài hơn 50 ký tự.");
            }
        }

        public string UPDATED_BY_FUNCTION
        {
            get => updatedByFunction;
            set
            {
                if (value.Length <= 100)
                    updatedByFunction = value;
                else
                    throw new ArgumentException("UPDATED_BY_FUNCTION không được dài hơn 100 ký tự.");
            }
        }
    }
}
