using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Collections_Ex = Collections.System.Collections;
using System_Collections_Specialized_Ex = Collections.System.Collections.Specialized;
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
            new System_Collections_Specialized_Ex.NameValueCollectionEx().Entry();
            Console.Read();
        }
    }
}
