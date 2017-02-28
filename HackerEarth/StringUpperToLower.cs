using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth
{
    class StringUpperToLower
    {
        public void Function()
        {
            string str = Console.ReadLine().Trim();
            char[] charArray = str.ToCharArray();
            string finalStr = string.Empty;
            foreach (var chr in charArray)
            {
                if (chr >= 65 && chr <= 90)//means character is capital
                {
                    finalStr += chr.ToString().ToLower();
                }
                else if (chr >= 97 && chr <= 122)
                {
                    finalStr += chr.ToString().ToUpper();
                }
                else
                {
                    finalStr += chr.ToString();
                }
            }
            Console.WriteLine(finalStr);
        }

    }
}
