using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
           // TaskEx.TaskRun();

            new ParallelEx().Entry();
            Console.ReadLine();
        }
    }
}
