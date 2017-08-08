using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods
{
    static class StringExtended
    {
        public static int Convert(this string obj,string value)
        {
            var intVlaue=0;
            if(int.TryParse(value,out intVlaue))
            {
                return intVlaue;
            }
            else
            {
                return 0;
            }
        }
    }
}
