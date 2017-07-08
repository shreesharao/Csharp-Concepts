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

            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void Method2()
        {
            try
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                Console.WriteLine(stackFrame.GetMethod().DeclaringType);

                throw new NullReferenceException();
            }
            catch(Exception e)
            {
                StackTrace st = new StackTrace();
                Console.WriteLine(st.ToString());
                throw e;
            }
            
        }

    }
}
