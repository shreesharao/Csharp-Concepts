using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections
{
    class StackEx
    {
        Stack objStack = new Stack(); //object collection with LIFO functionality

        public void Entry()
        {
            objStack.Push("string");
            objStack.Push(1); //this involves boxing and unboxing cost
            objStack.Push(1.11);

            Console.WriteLine("we can also:"+objStack.Pop());
            foreach (var item in objStack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
