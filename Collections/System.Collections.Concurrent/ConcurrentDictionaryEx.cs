using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
namespace Collections.System.Collections.Concurrent
{
    class ConcurrentDictionaryEx
    {


        ConcurrentDictionary<int, string> objConcurrentDictionary;
        //Dictionary<int, string> objConcurrentDictionary = new Dictionary<int, string>();
        public async void Entry()
        {
            // We know how many items we want to insert into the ConcurrentDictionary.
            // So set the initial capacity to some prime number above that, to ensure that
            // the ConcurrentDictionary does not need to be resized while initializing it.
            //int NUMITEMS = 64;
            int initialCapacity = 101;

            // The higher the concurrencyLevel, the higher the theoretical number of operations
            // that could be performed concurrently on the ConcurrentDictionary.  However, global
            // operations like resizing the dictionary take longer as the concurrencyLevel rises. 
            // For the purposes of this example, we'll compromise at numCores * 2.
            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;

            objConcurrentDictionary = new ConcurrentDictionary<int, string>(concurrencyLevel, initialCapacity);

            await Task.Run(() =>
             {
                 Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                 for (int i = 0; i < 10; i++)
                 {
                     objConcurrentDictionary.TryAdd(i, "value" + i);
                     //objConcurrentDictionary.Add(i, "value" + i);
                 }

             });

            await Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("existing:" + objConcurrentDictionary[i]);
                    //objConcurrentDictionary.TryAdd(i, "value" + i);
                    objConcurrentDictionary.AddOrUpdate(i, "value" + i, (key, value) => "updatedvalue" + i + 1);
                    //objConcurrentDictionary.Add(i, "value" + i);
                }
            });

            Task.WaitAll();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            foreach (var item in objConcurrentDictionary)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }

    }
}
