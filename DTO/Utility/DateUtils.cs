using System;

namespace DTO.Utility
{
    public class DateUtils
    {
        // Lấy ngày đầu năm
        public static DateTime GetStartOfYear(DateTime date)
        {
            return new DateTime(date.Year, 1, 1);
        }

        // Lấy ngày cuối năm
        public static DateTime GetEndOfYear(DateTime date)
        {
            return new DateTime(date.Year, 12, 31);
        }
    }

}
