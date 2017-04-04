using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class SynchronizedCollectionEx
    {
        SynchronizedCollection<int> objSynchronizedCollection = new SynchronizedCollection<int>();

        public void Entry()
        {
            objSynchronizedCollection.Add(1);
            objSynchronizedCollection.Add(2);

            foreach (var item in objSynchronizedCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
