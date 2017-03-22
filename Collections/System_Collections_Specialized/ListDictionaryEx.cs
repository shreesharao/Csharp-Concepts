using System;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Specialized
{
    class ListDictionaryEx
    {
        ListDictionary objListDictionary = new ListDictionary();

        public void Entry()
        {
            objListDictionary.Add("", "test");

            foreach (DictionaryEntry item in objListDictionary)
            {
                Console.WriteLine(item.Key+""+item.Value);
            }
        }
    }
}
