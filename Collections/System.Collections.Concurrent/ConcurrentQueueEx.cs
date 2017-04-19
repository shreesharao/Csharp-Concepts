using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Concurrent
{
    class ConcurrentQueueEx
    {
        ConcurrentQueue<string> objConcurrentQueue = new ConcurrentQueue<string>();

        public void Entry()
        {
            var tasks = new List<Task>{
               new Task(Insert),
                new Task(Insert),
           };

            tasks.ForEach(t => t.Start());
            Task.WaitAll(tasks.ToArray());

            objConcurrentQueue.All(item => { Console.WriteLine(item); return true; });
        }

        public void Insert()
        {
            // Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                objConcurrentQueue.Enqueue(string.Format("{0}:{1}", Thread.CurrentThread.ManagedThreadId, i));
            }

        }
    }
}
