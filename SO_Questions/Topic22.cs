using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DotNet_store
{
    public class Topic22
    {
        public void Entry()
        {
            CustomCollection<int> customCollection = new CustomCollection<int>();

            for (int i = 0; i < 10; i++)
            {
                customCollection.Add(i);
            }
            var num = customCollection.First();

            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    class CustomCollection<T> : IEnumerable<T>, IEnumerator<T>
    {
        List<T> list = new List<T>();
        T _current = default(T);
        int _counter = 0;

        public T this[int index]
        {
            get
            {

                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }

        public void Add(T i)
        {
            list.Add(i);
        }

        public T Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_counter >= list.Count)
            {
                return false;
            }
            _current = list[_counter];
            _counter++;
            return true;
        }

        public void Reset()
        {
            _counter = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
