using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Collections.System.Collections.Concurrent
{
    class ConcurrentStackEx
    {
        ConcurrentStack<string> objConcurrentStack = new ConcurrentStack<string>();

        public void Entry()
        {
            var tasks = new List<Task>{
               new Task(Insert),
            new Task(Insert),
           };

            tasks.ForEach(t => t.Start());
            Task.WaitAll(tasks.ToArray());

            objConcurrentStack.All(item => { Console.WriteLine(item); return true; });
        }

        public void Insert()
        {
            // Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                
             //   objConcurrentStack.PushRange()
                objConcurrentStack.Push(string.Format("{0}:{1}", Thread.CurrentThread.ManagedThreadId, i));
            }

        }
    }
}
