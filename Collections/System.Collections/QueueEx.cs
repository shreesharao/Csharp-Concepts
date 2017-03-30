using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System_Collections
{
    class QueueEx
    {
        Queue objQueue = new Queue();

        public void Entry()
        {
            objQueue.Enqueue("stirng");
            objQueue.Enqueue(1);
            objQueue.Enqueue(1.11);
            Console.WriteLine(objQueue.Dequeue());
            Console.WriteLine(objQueue.Peek());

        }
    }
}
