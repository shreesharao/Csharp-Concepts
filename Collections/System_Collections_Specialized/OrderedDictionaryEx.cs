using System;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Specialized
{
    class OrderedDictionaryEx
    {
        OrderedDictionary objOrderedDictionary = new OrderedDictionary();
        Dictionary<string, string> objDictionary = new Dictionary<string, string>();

        public void Entry()
        {
            objOrderedDictionary.Add("key1", "test1");//object , object
            objOrderedDictionary.Add("key2", "test2");
            objOrderedDictionary.Add("key3", "test3");

            objDictionary.Add("key1", "test1");//object , object
            objDictionary.Add("key2", "test2");
            objDictionary.Add("key3", "test3");

            objOrderedDictionary.Remove("key2");
            objDictionary.Remove("key2");

            foreach (DictionaryEntry item in objOrderedDictionary)
            {
                Console.WriteLine(item.Key+""+item.Value);
            }

            foreach (var item in objDictionary)
            {
                Console.WriteLine(item.Key + "" + item.Value);
            }
        }
    }
}
