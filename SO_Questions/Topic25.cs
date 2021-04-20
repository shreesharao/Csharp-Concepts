using System;
using System.Threading;

namespace DotNet_store
{
    class Topic25
    {
        // Create a new Mutex. The creating thread does not own the mutex.
        private static Mutex mut = new Mutex();
        public void Entry()
        {
            // Create the threads that will use the protected resource.
            for (int i = 0; i < 3; i++)
            {
                Thread newThread = new Thread(new ThreadStart(ThreadProc));
                newThread.Name = $"Thread{i + 1}";
                newThread.Start();
            }
        }

        private static void ThreadProc()
        {
            for (int i = 0; i < 2; i++)
            {
                UseResource();
            }
        }
        private static void UseResource()
        {
            // Wait until it is safe to enter.
            Console.WriteLine("{0} is requesting the mutex",
                              Thread.CurrentThread.Name);
            mut.WaitOne();

            Console.WriteLine("{0} has entered the protected area",
                              Thread.CurrentThread.Name);

            // Place code to access non-reentrant resources here.

            // Simulate some work.
            Thread.Sleep(500);

            Console.WriteLine("{0} is leaving the protected area",
                Thread.CurrentThread.Name);

            // Release the Mutex.
            mut.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex",
                Thread.CurrentThread.Name);
        }
    }
}
