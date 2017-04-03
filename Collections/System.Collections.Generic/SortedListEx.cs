using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class SortedListEx
    {
        SortedList<int, string> objSortedList = new SortedList<int, string>();

        public void Entry()
        {
            objSortedList.Add(2, "test2");
            objSortedList.Add(1, "test1");

            foreach (KeyValuePair<int,string> item in objSortedList)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
