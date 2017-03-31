using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class DictionaryEx
    {
        List<string> objList = new List<string>();
        Dictionary<int, List<string>> objDictionary = new Dictionary<int, List<string>>();

        public void Entry()
        {
            objList.Add("value1");
            objDictionary.Add(1, objList);

            foreach (KeyValuePair<int,List<string>> item in objDictionary)
            {
                Console.WriteLine(item.Key +""+ item.Value);
            }
        }
    }
}
