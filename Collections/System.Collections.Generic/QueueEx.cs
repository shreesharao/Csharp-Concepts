using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class QueueEx
    {
        Queue<int> objQueue = new Queue<int>();

        public void Entry()
        {
            objQueue.Enqueue(1);

            foreach (var item in objQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
