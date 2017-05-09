using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace DotNet_store
{
    class Topic_6
    {
        private int i = 0; //changing i to static variable will crash the compiler.It is a bug in native compiler
        public void Entry()
        {
            for (int i = 0; i < 100; i++)
            {
                var tasks = new List<Task>{
                new Task(IncrementCounter),
                new Task(IncrementCounter)
            };

                tasks.ForEach(t => t.Start());
                Task.WaitAll(tasks.ToArray());
            }
        }

        private async void IncrementCounter()
        {
            Console.WriteLine("i={0} updated by {1}", i, Thread.CurrentThread.ManagedThreadId);
            Interlocked.Increment(ref i);
            Interlocked.Exchange(ref i, await RandomValue());
            Console.WriteLine("after updating i:{0}", i);
        }

        public Task<int> RandomValue()
        {
            return Task.FromResult(0);
        }
    }
}
