using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_10
    {
        public static void Entry()
        {
            Driver.MainMethod();
        }
    }

    class Test
    {
        public static string x = EchoAndReturn("In type initializer");

        public static string EchoAndReturn(string s)
        {
            Console.WriteLine(s);
            return s;
        }
    }

    class Driver
    {
        public static void MainMethod()
        {
            Console.WriteLine("Starting Main");
            // Invoke a static method on Test
            Test.EchoAndReturn("Echo!");
            Console.WriteLine("After echo");
            // Reference a static field in Test
            string y = Test.x;
            // Use the value just to avoid compiler cleverness
            if (y != null)
            {
                Console.WriteLine("After field access");
            }
        }
    }
}
