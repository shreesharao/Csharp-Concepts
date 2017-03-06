using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int SampleDelegate(string data);
    class AsyncCallbackEx
    {
       public static void MainEntry()
        {
            SampleDelegate counter = new SampleDelegate(CountCharacters);
            SampleDelegate parser = new SampleDelegate(Parse);

            AsyncCallback callback = new AsyncCallback(DisplayResult);

            counter.BeginInvoke("hello", callback, "Counter returned {0}");
            parser.BeginInvoke("10", callback, "Parser returned {0}");

            Console.WriteLine("Main thread continuing");

            Thread.Sleep(3000);
            Console.WriteLine("Done");
        }

        static void DisplayResult(IAsyncResult result)
        {
            string format = (string)result.AsyncState;
            AsyncResult delegateResult = (AsyncResult)result;
            SampleDelegate delegateInstance = (SampleDelegate)delegateResult.AsyncDelegate;

            Console.WriteLine(format, delegateInstance.EndInvoke(result));
        }

        static int CountCharacters(string text)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Counting characters in {0}", text);
            return text.Length;
        }

        static int Parse(string text)
        {
            Thread.Sleep(100);
            Console.WriteLine("Parsing text {0}", text);
            return int.Parse(text);
        }
    }
}
