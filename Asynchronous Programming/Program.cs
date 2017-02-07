using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //string async; //async is an identifier here

            //call sync method
            new AsyncAwait().MethodAsync();
            Console.WriteLine("This must be the first line");
            Console.Read();
        }
    }
}
