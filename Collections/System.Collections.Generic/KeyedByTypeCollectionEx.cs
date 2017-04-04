using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class KeyedByTypeCollectionEx
    {
        KeyedByTypeCollection<object> objKeyedByTypeCollection = new KeyedByTypeCollection<object>();

        public void Entry()
        {
            objKeyedByTypeCollection.Add(1);
            objKeyedByTypeCollection.Add("test");
            objKeyedByTypeCollection.Add('c');

            var item = objKeyedByTypeCollection.FindAll<int>(); //type safe
            Console.WriteLine(item);
        }
    }
}
