using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth
{
    class Palindrome
    {
        public void CheckPalindrome()
        {
            string str = Console.ReadLine().Trim().ToLower();

            //foreach (char c in str)//this is possible because string has a public definition for GetEnumrator
            //{

            //}
            char[] arr = str.ToCharArray();

            Array.Reverse(arr);
            string rev = new string(arr);

            if (str == rev)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
