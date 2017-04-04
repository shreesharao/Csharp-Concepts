using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class SynchronizedReadOnlyCollectionEx
    {
        List<int> objList=new List<int>();
        

        public void Entry()
        {
            objList.Add(1);
            object syncRoot = new object();
            SynchronizedReadOnlyCollection<int> objSynchronizedReadOnlyCollection = new SynchronizedReadOnlyCollection<int>(syncRoot,objList);
            foreach (var item in objSynchronizedReadOnlyCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
