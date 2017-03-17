using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Specialized
{
    class StringCollectionEx
    {
        StringCollection objStringCollection = new StringCollection();

        public void Entry()
        {
            objStringCollection.Add("string"); // we can add only string
            objStringCollection.Add("string");
            foreach (var item in objStringCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
