using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections
{
    class HashtableEx
    {
        Hashtable objHashtable = new Hashtable();

        public void Entry()
        {
            objHashtable.Add(1, 1);
            objHashtable.Add(2, "test");
            objHashtable.Add("test", 1);

            foreach (var item in objHashtable.Values)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
