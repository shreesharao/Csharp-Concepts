using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class StackEx
    {
        Stack<string> objStack = new Stack<string>(); //string collection..it is type safe

        public void Entry()
        {
            objStack.Push("test");

            foreach (var item in objStack)
            {
                Console.WriteLine(item);               
            }
        }
    }
}
