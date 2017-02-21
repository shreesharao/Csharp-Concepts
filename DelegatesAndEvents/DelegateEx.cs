using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class DelegateEx
    {
        private delegate void PrintDelegate();

        public static void Call()
        {
            PrintDelegate printDelegate = new PrintDelegate(Print);
            printDelegate.Invoke();
        }
        private static void Print()
        {
            Console.WriteLine("Message from Print method");
        }

    }
}
