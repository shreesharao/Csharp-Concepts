using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            new NLogHelper.FileLogging().Entry();
            Console.Read();
        }
    }
}
