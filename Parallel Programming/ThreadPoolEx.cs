using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_Programming
{
    class ThreadPoolEx
    {
        public void Entry()
        {
            int workerThreads, completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("MaxThreads before creating tasks.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("AvailableThreads before creating tasks.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);


            Console.WriteLine("Entry Main thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Parallel.Invoke(() => Method1(), () => Method2());
            Console.WriteLine("This point is reached after calling method1 and method2.thread is:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
        }
        public void Method1()
        {
            Console.WriteLine("Method1 running on Thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Message from method 1");
        }
        public void Method2()
        {
            int workerThreads, completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("MaxThreads in Method2.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("AvailableThreads in Method2.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);


            Console.WriteLine("Method2 running on Thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Message from method 2");
        }
    }
}
