namespace BUS.Sys
{
    public class Ultilities
    {
        public static bool isNumber(string text)
        {
            foreach (char item in text)
            {
                if (!char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
