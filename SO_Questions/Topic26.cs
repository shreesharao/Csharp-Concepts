using System;
using System.Collections.Generic;
using System.Threading;

namespace DotNet_store
{
    class Topic26
    {
        //define a local semaphore. initialCount argument specifies the number of semaphores free initially
        private static Semaphore semaphore = new Semaphore(3, 3);
        private static List<string> resources = new List<string> { "apple", "grape", "banana" };
        public void Entry()
        {
            // Create the threads that will use the protected resource.
            for (int i = 0; i < 4; i++)
            {
                Thread newThread = new Thread(new ThreadStart(ThreadProc));
                newThread.Name = $"Thread{i + 1}";
                newThread.Start();
            }
        }

        private static void ThreadProc()
        {
            for (int i = 0; i < 3; i++)
            {
                UseResource();
            }
        }
        private static void UseResource()
        {
            // Wait until it is safe to enter.
            Console.WriteLine($"{Thread.CurrentThread.Name} is requesting the semaphore. Resources {resources.Count}");
            semaphore.WaitOne();

            // Place code to access non-reentrant resources here.
            var resource = resources[0];
            resources.Remove(resource);
            Console.WriteLine($"{Thread.CurrentThread.Name} has taken {resource}");
            Thread.Sleep(2000);

            resources.Add(resource);
            Console.WriteLine($"{Thread.CurrentThread.Name} has released {resource}");

            // Release the semaphore.
            semaphore.Release();
            Console.WriteLine($"{Thread.CurrentThread.Name} has released the semaphore");
        }
    }
}
