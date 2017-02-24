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

            //printDelegate is MulticastDelegate=true //all delegates in c# are multicast delegates

            int x = printDelegate("Hello");

        }

        private static int PrintMsg(string msg)
        {
            Console.WriteLine("Msg from PrintMsg:{0}", msg);
            return 0;
        }

        private static int PrintAnotherMsg(string msg)
        {
            Console.WriteLine("Msg from PrintAnotherMsg:{0}", msg);
            return 10;
        }

        #endregion

        #region Get individual results from multicast delegate
        private delegate int MultiValueDelegate();
        public static void CallMulticastIndividualResult()
        {
            MultiValueDelegate valueDelegate = new MultiValueDelegate(ReturnNumber);
            valueDelegate += ReturnAnotherNumber;

            foreach (MultiValueDelegate del in valueDelegate.GetInvocationList())
            {
                Console.WriteLine("value returned from {0} is {1}", del.Method, del());
            }
        }

        private static int ReturnNumber()
        {
            return 5;
        }

        private static int ReturnAnotherNumber()
        {
            return 10;
        }
        #endregion


    }
}
