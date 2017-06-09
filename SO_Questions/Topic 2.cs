using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    /*I'M TRYING TO FIGURE OUT HOW TO DEFINE IF STRING CONTAINS/DOES NOT CONTAINS LIST VALUE AND
     * IF CONTAINS BUT WITH OTHER VALUE.
     * 
     */
    class Topic_2
    {
        private static string opDisplay;
        
        public static void Run()
        {
            string inputString = "zero was one ";
            var numbList = new List<string> { "zero", "one", "two" };
            #region My Answer
            //if (numbList.All(x => inputString.Contains(x)))
            //{
            //    if (numbList.Any(x => inputString.Trim().StartsWith(x) && inputString.Trim().EndsWith(x)))
            //    {
            //        Console.WriteLine("string contains list value");
            //    }
            //    else
            //    {
            //        Console.WriteLine("string contains list value and other words");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("string does not contains list value");
            //} 
            #endregion

            #region Accepted answer
            if (inputString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).All(x => numbList.Contains(x)))
            {
                opDisplay = "string contains list value";
            }
            else if (numbList.Any(x => inputString.Contains(x)))
            {
                opDisplay = "string contains list value and other words";
            }
            else
            {
                opDisplay = "string does not contains list value";
            }
            Console.WriteLine(opDisplay);
            #endregion
        }

    }
}
