using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Programming
{
    class ParallelEx
    {
        public void Entry()
        {
            Console.WriteLine("Entry Main thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Parallel.Invoke(() => Method1(), () => Method2());
        }
        public void Method1()
        {
            Console.WriteLine("Method1 running on Thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Message from method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2 running on Thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Message from method 2");
        }
    }


}
