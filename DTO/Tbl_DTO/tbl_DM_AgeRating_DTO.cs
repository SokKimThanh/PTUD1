using System;
namespace DTO.tbl_DTO
{
    /// <summary>
    /// Danh mục đánh giá độ tuổi
    /// </summary>
    public class tbl_DM_AgeRating_DTO
    {
        private long _aR_AUTOID;
        private string _aR_NAME;
        private string _aR_NOTE;

        // Constructor mặc định
        public tbl_DM_AgeRating_DTO()
        {
        }
        // Constructor combobox
        public tbl_DM_AgeRating_DTO(long aR_AUTOID, string aR_NAME)
        {
            this.AR_AutoID = aR_AUTOID;
            this.AR_NAME = aR_NAME;
        }
        // Constructor với tham số
        public tbl_DM_AgeRating_DTO(long aR_AUTOID, string aR_NAME, string aR_NOTE)
        {
            this.AR_AutoID = aR_AUTOID;
            this.AR_NAME = aR_NAME;
            this.AR_NOTE = aR_NOTE;
        }

        // Thuộc tính AR_NAME
        public string AR_NAME
        {
            get => _aR_NAME;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nhãn đánh giá độ tuổi không được để trống.");
                }
                if (value.Length > 150)
                {
                    throw new Exception("Nhãn đánh giá độ tuổi không được quá 150 kí tự");
                }
                _aR_NAME = value;
            }
        }

        // Thuộc tính AR_NOTE
        public string AR_NOTE
        {
            get => _aR_NOTE;
            set
            {
                _aR_NOTE = value;
            }
        }

        // Thuộc tính AR_AutoID
        public long AR_AutoID
        {
            get => _aR_AUTOID;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("AR_AutoID phải lớn hơn 0.");
                }
                _aR_AUTOID = value;
            }
        }
        // Phương thức để dễ dàng hiển thị thông tin đối tượng
        public override string ToString()
        {
            return $"Tên: {AR_NAME}, Ghi chú: {AR_NOTE}";
        }
    }
}