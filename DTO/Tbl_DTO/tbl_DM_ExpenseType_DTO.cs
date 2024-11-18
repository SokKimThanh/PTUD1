using System;

namespace DTO.tbl_DTO
{
    /// <summary>
    /// Danh mục quản lý loại chi phí
    /// </summary>
    public class tbl_DM_ExpenseType_DTO
    {
        private long eT_AutoID;
        private string eT_NAME;
        private long? eT_PRODUCT_AutoID;
        private int deleted;
        private DateTime created;
        private string createdBy;
        private string createdByFunction;
        private DateTime updated;
        private string updatedBy;
        private string updatedByFunction;

        public tbl_DM_ExpenseType_DTO() { }

        public tbl_DM_ExpenseType_DTO(long eT_AutoID, string eT_NAME, long? eT_PRODUCT_AutoID)
        {
            this.eT_AutoID = eT_AutoID;
            this.eT_NAME = eT_NAME;
            this.eT_PRODUCT_AutoID = eT_PRODUCT_AutoID;
        }

        public long ET_AutoID { get => eT_AutoID; set => eT_AutoID = value; }
        public string ET_NAME
        {
            get => eT_NAME;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 50)
                    eT_NAME = value;
                else
                    throw new ArgumentException("ET_NAME không được trống và không dài hơn 50 ký tự.");
            }
        }
        public long? ET_PRODUCT_AutoID { get => eT_PRODUCT_AutoID; set => eT_PRODUCT_AutoID = value; }

        // Các property với ràng buộc dữ liệu
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
