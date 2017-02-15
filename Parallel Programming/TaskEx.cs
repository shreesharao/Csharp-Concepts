using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threads = System.Threading.Thread;
namespace Parallel_Programming
{
    class TaskEx
    {

        public static async Task TaskRun()
        {
            Console.WriteLine("Threadid before entering Task.Run:" + Threads.CurrentThread.ManagedThreadId);
            await Task.Run(async () =>
             {
                 Console.WriteLine("Threadid after entering Task.Run:" + Threads.CurrentThread.ManagedThreadId);
                 Console.WriteLine("Message from TaskRun");
                 await Task.Delay(5000);
                 Console.WriteLine("Message from TaskRun after delay");
             });
        }

        public static async Task TaskFactoryStartNew()
        {
            Console.WriteLine("Threadid before entering Task.Run:" + Threads.CurrentThread.ManagedThreadId);
            await Task.Factory.StartNew(async () =>
            {
                Console.WriteLine("Threadid after entering Task.Run:" + Threads.CurrentThread.ManagedThreadId);
                Console.WriteLine("Message from TaskRun");
                await Task.Delay(5000);
                Console.WriteLine("Message from TaskRun after delay");
            });
        }

        #region TaskConstructorStart
        public static async Task TaskConstructorStart()
        {
            Console.Write(string.Empty);
            //avoid this way
            Task task = new Task(new Action(() => NamedMethod()), TaskCreationOptions.LongRunning);
            task.Start();
            //await task; //no use of await i think
            await task.ContinueWith(t =>
            {
                Console.WriteLine("Message from continuewith");
            });


        }

        public static void NamedMethod()
        {
            Console.WriteLine("Message from named method");
        }
        #endregion

        #region TaskFromResult
        public async Task TaskFromResult()
        {
            int res = await Task.FromResult<int>(GetSum(4, 5));
        }

        private int GetSum(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region Task<Tresult>.Result
        public static void CalculateSum()
        {
            Task<double>[] taskArray ={
                                       Task<double>.Factory.StartNew(()=>sum(2,3)),
                                       Task<double>.Factory.StartNew(()=>sum(4,6))
                                   };
            for (int i = 0; i < taskArray.Length; i++)
            {
                Console.WriteLine("Result:"+taskArray[i].Result);
            }
        }
        public static double sum(int a, int b)
        {
            return a + b;
        }
        #endregion

    }
}
