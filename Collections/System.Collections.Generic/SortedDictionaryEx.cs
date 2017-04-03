using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class SortedDictionaryEx
    {
        SortedDictionary<int, string> objSortedDictionary = new SortedDictionary<int, string>();

        public void Entry()
        {
            objSortedDictionary.Add(2, "test");
            objSortedDictionary.Add(1, "test1");

            foreach (KeyValuePair<int,string> item in objSortedDictionary)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
