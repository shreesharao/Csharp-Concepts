using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Subscriber
    {
        public static void WriteString()
        {
            Console.WriteLine("string read");
        }

        public static void WriteInt()
        {
            Console.WriteLine("int read");
        }
    }
}
