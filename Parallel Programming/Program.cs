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
            //TaskEx.TaskRun();
            //TaskEx.TaskConstructorStart();
            //TaskEx.CalculateSum();

            // new ParallelEx().Entry();
            new ParallelEx().CallPrint();
            //new ParallelEx().ForEachCallPrint();
            // System.Threading.Thread.Sleep(2000);

            //  new ThreadPoolEx().Entry();
            Console.ReadKey();
        }
    }
}
