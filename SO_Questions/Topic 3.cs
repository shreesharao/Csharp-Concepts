using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_3
    {
        volatile string test = string.Empty;
        public void Entry()
        {
            for (int i = 0; i < 100; i++)
            {
                CreateAndRunTasks();
            }
        }

        private void Read()
        {
            Console.WriteLine("Reading");
            Console.WriteLine(test);
        }

        public void Assign()
        {
            Console.WriteLine("Writing");
            test = "value" + System.Threading.Thread.CurrentThread.ManagedThreadId;
        }

        public void CreateAndRunTasks()
        {
            var tasks = new List<Task>{
                new Task(Assign),
                new Task(Read)
            };

            tasks.ForEach(t => t.Start());
            Task.WaitAll(tasks.ToArray());



        }
    }
}
