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
        private long _aR_AUTOID;
        private string _aR_NAME;
        private string _aR_NOTE;

        // Constructor mặc định
        public tbl_DM_AgeRating_DTO()
        {
        }

        // Constructor với tham số
        public tbl_DM_AgeRating_DTO(long aR_AUTOID, string aR_NAME, string aR_NOTE)
        {
            this.AR_AUTOID = aR_AUTOID;
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
                    throw new ArgumentException("AR_NAME không được để trống.");
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

        // Thuộc tính AR_AUTOID
        public long AR_AUTOID
        {
            get => _aR_AUTOID;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("AR_AUTOID phải lớn hơn 0.");
                }
                _aR_AUTOID = value;
            }
        }

        // Phương thức để dễ dàng hiển thị thông tin đối tượng
        public override string ToString()
        {
            return $"ID: {AR_AUTOID}, Tên: {AR_NAME}, Ghi chú: {AR_NOTE}";
        }
    }
}