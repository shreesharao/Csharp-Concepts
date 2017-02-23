using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class DelegateEx
    {
        #region Simple Delegate
        //declare
        private delegate void PrintDelegate();

        public static void Call()
        {
            //instantiate
            PrintDelegate printDelegate = new PrintDelegate(Print);

            //use
            printDelegate.Invoke();
        }
        private static void Print()
        {
            Console.WriteLine("Message from Print method");
        }
        #endregion

        #region Multicast Delagate
        private delegate int MultiPrintDelegate(string msg);

        public static void CallMulticast()
        {
            MultiPrintDelegate printDelegate = new MultiPrintDelegate(PrintMsg);
            printDelegate += PrintAnotherMsg;
            printDelegate("Hello");

        }

        private static int PrintMsg(string msg)
        {
            Console.WriteLine("Msg from PrintMsg:{0}",msg);
            return 0;
        }

        private static int PrintAnotherMsg(string msg)
        {
            Console.WriteLine("Msg from PrintAnotherMsg:{0}", msg);
            return 0;
        }

        #endregion


    }
}
