using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            // DelegateEx.Call();
            // DelegateEx.CallMulticast();
            //DelegateEx.CallMulticastIndividualResult();

            EventsEx.Write();

            AsyncCallbackEx.MainEntry();

            Console.Read();
        }
    }
}
