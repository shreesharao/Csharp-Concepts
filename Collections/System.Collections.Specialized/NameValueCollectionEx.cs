using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Specialized
{
    class NameValueCollectionEx
    {
        NameValueCollection objNameValueCollection = new NameValueCollection();

        public void Entry()
        {
            objNameValueCollection.Add("testkey", "test");//must be string,string
            objNameValueCollection.Add("testkey", "test1");
            objNameValueCollection.Add("testkey", "test2");
            objNameValueCollection.Add(null, "test3");
            objNameValueCollection.Add(null, "test4"); //null can be a key

            foreach (var item in objNameValueCollection.AllKeys)
            {
                Console.WriteLine("{0,-10}{1}",item,objNameValueCollection[item]);
                //Console.WriteLine(item.Key+""+item.Value);
            }
        }
    }
}
