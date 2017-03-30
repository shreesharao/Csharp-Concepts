using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Specialized
{
    class StringDictionaryEx
    {
        StringDictionary objStringDictionary = new StringDictionary();
        public void Entry()
        {
            objStringDictionary.Add("key", "value"); //Key must be a string
        }
    }
}
