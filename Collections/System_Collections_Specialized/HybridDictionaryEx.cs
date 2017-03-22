using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Specialized
{
    class HybridDictionaryEx
    {
        HybridDictionary objHybridDictionary = new HybridDictionary();
    
        public void Entry()
        {
            objHybridDictionary.Add("", "test"); //key can not be null

            foreach (DictionaryEntry item in objHybridDictionary)
            {
                Console.WriteLine(item.Key+""+item.Value);
            }
        }
    }
}
