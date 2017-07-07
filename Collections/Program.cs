using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Collections_Ex = Collections.System.Collections;
using System_Collections_Specialized_Ex = Collections.System.Collections.Specialized;
using System_Collections_Generic_Ex = Collections.System.Collections.Generic;
using System_Collections_Concurrent_Ex = Collections.System.Collections.Concurrent;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //new System_Collections_Ex.SortedListEx().AddToList();
            //new System_Collections_Ex.ArrayListEx().Entry();
            //new System_Collections_Ex.BitArrayEx().Entry();
            //new System_Collections_Ex.HashtableEx().Entry();
            //new System_Collections_Ex.SortedListEx().Entry();

            //new System_Collections_Specialized_Ex.HybridDictionaryEx().Entry();
            //new System_Collections_Specialized_Ex.NameValueCollectionEx().Entry();
           //new System_Collections_Specialized_Ex.OrderedDictionaryEx().Entry();
           // new System_Collections_Generic_Ex.HashSetEx().Entry();
            //new System_Collections_Generic_Ex.ListEx().Entry();
            //new System_Collections_Generic_Ex.LinkedListEx().Entry();
            //new System_Collections_Generic_Ex.SortedDictionaryEx().Entry();
            //new System_Collections_Generic_Ex.KeyedByTypeCollectionEx().Entry();
            //new System_Collections_Generic_Ex.SynchronizedReadOnlyCollectionEx().Entry();
            
            //new System_Collections_Concurrent_Ex.BlockingCollectionEx().Entry();
            //new System_Collections_Concurrent_Ex.ConcurrentBagEx().Entry();
            //new System_Collections_Concurrent_Ex.ConcurrentDictionaryEx().Entry();
            //new System_Collections_Concurrent_Ex.ConcurrentStackEx().Entry();
            //new System_Collections_Concurrent_Ex.ConcurrentQueueEx().Entry();
            new System_Collections_Concurrent_Ex.OrderablePartitionerEx().Entry();
           // new System_Collections_Concurrent_Ex.PartitionerEx().Entry();
            Console.Read();
        }
    }
}
