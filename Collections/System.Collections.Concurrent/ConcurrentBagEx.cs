using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Concurrent
{
    class ConcurrentBagEx
    {
        public void Entry()
        {
            // Construct and populate the ConcurrentBag
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            cb.Add(1);
            cb.Add(2);
            cb.Add(3);

            // Consume the items in the bag
            int item;
            while (!cb.IsEmpty)
            {
                if (cb.TryTake(out item))
                    Console.WriteLine(item);
                else
                    Console.WriteLine("TryTake failed for non-empty bag");
            }

            // Bag should be empty at this point
            if (cb.TryPeek(out item)) //TryPeek Attempts to return an object from the ConcurrentBag<T> without removing it.
                Console.WriteLine("TryPeek succeeded for empty bag!");
        }
    }
}
