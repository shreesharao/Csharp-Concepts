using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DotNet_store
{
    class Topic_1
    {
        public static void Entry()
        {
            string s = "test";
            string s2 = s + "test1";
            Console.WriteLine("s and s2 are same? {0}", s == s2);
            
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            sb.Append("test");
            sb2 = sb.Append("test2");
            Console.WriteLine("s and s2 are same? {0}", sb == sb2);

            Stopwatch sw = new Stopwatch();

            string s3 = string.Empty;
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                s3 += i.ToString() + " ";
            }
            sw.Stop();
            Console.WriteLine("time taken:{0}",sw.ElapsedTicks);

            sw.Reset();
            StringBuilder sb3 = new StringBuilder();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                sb3 .Append(i.ToString() + " ");
            }
            sw.Stop();
            Console.WriteLine("time taken:{0}", sw.ElapsedTicks);
        }
    }
}
