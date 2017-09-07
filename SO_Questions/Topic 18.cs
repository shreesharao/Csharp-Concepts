using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_18
    {
        public void Entry()
        {
            Topic_18_TestClass<string> obj = new Topic_18_TestClass<string>();
            obj[0] = "test";

            Console.WriteLine(obj[0]);
            Console.WriteLine(obj["test"]);
        }
    }

    public interface ISomeInterface<T>
    {
        //...

        // Indexer declaration:
        T this[int index]
        {
            get;
            set;
        }
    }

    class Topic_18_TestClass<T>:ISomeInterface<T>
    {
        private T[] _genArray = new T[100];
        public T this[int i]
        {
            get
            {
                return _genArray[i];
            }
            set
            {
                _genArray[i] = value;
            }
        }

        //indexer overload
        public T this[string key]
        {
            get
            {
                return GetValue(key);
            }
            
        }

        public T GetValue(string key)
        {
            T ret=default(T);
            ret= _genArray.Where(v => v.ToString() == key).FirstOrDefault();
            return ret;
        }

       
    }
}
