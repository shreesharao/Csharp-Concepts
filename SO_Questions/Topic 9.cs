using System;
using System.Diagnostics;

namespace DotNet_store
{
    class Topic_9
    {
        public void Entry()
        {
            Method1();
        }

        public void Method1()
        {
            StackFrame stackFrame = new StackFrame(2);
            Console.WriteLine(stackFrame.GetMethod().DeclaringType);
        }
        
    }
}
