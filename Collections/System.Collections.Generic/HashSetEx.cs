using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class HashSetEx
    {
        HashSet<int> objHashSet = new HashSet<int>();
        HashSet<int> objHashSetAnother = new HashSet<int>();
        
        public void Entry()
        {
            var res = false;
           
            res = objHashSet.Add(1);
            res = objHashSet.Add(2);
            //Console.WriteLine(objHashSet[1]); indexing is not possible as it does not implement IList
            res = objHashSetAnother.Add(3);
            res = objHashSetAnother.Add(4);

            objHashSet.UnionWith(objHashSetAnother); //Union,IntersectWith
            foreach (var item in objHashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
