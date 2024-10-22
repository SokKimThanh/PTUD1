using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Sys
{
    public class Ultilities
    {
        public static bool isNumber(string text)
        {
            foreach( char item in text )
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
