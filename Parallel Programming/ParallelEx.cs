using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_Programming
{
    class ParallelEx
    {
        static int sum = 0;
        #region Parallel.Invoke
        public void Entry()
        {
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
            Console.WriteLine("Method2 running on Thread:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Message from method 2");
        }
        #endregion

        #region Parallel.For
        public void CallPrint()
        {

            int workerThreads, completionPortThreads;
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("MaxThreads in CallPrint.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("AvailableThreads in CallPrint.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);

            Parallel.For(0,10,Print);
        }

        public void Print(int i)
        {
            int workerThreads, completionPortThreads;
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine("AvailableThreads in Print.workerThreads:{0},completionThreads{1}", workerThreads, completionPortThreads);


            Console.WriteLine("Message from print method.i:{0}.Threadid:{1}",i,System.Threading.Thread.CurrentThread.ManagedThreadId);
        }
        #endregion 

        #region Parallel.ForEach
        public void ForEachCallPrint()
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Parallel.ForEach(intList, ForEachPrint);
        }

        

        public void ForEachPrint(int i)
        {
            Console.WriteLine("Sum before:{0}",sum);
            sum = sum + i;
            Console.WriteLine("i:{0}. Threadid:{1}. Sum after:{2}", i, System.Threading.Thread.CurrentThread.ManagedThreadId,sum);
        }


        #endregion
    }


}
