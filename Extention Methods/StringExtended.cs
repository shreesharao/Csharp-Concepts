using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods
{
    static class StringExtended
    {
        public static string Reverse(this string obj)
        {
            List<char> arr = obj.ToArray().Reverse().ToList();
            return new string(arr.ToArray());
        }
    }
}
