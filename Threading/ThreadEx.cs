using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    class ThreadEx
    {

        #region ThreadStart
        public static void ThreadStart()
        {
            Thread thread = new Thread(WriteY);
            thread.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("X");
            }
        }

        private static void WriteY(object obj)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Y");
            }

        }
        #endregion

        #region ParameterizedThreadStart
        public static void ParamThreadStart()
        {
            Thread thread = new Thread(ObjMsgPrint);
            thread.Start("Hello");
        }

        private static void ObjMsgPrint(object msg)
        {
            Console.WriteLine(msg);
        }
        #endregion

        #region using lambda expression
        public static void LambdaThreadStart()
        {
            Thread thread = new Thread(()=>StringMsgPrint("Hello"));
            thread.Start();
        }

        private static void StringMsgPrint(string msg)
        {
            Console.WriteLine(msg);
        }
        #endregion

        #region Separate Memory Stack
        public static void MemStack()
        {
            new Thread(Print).Start();
            Print();
        }

        private static void Print()
        {

            char c = 'a';//each thread will have separate copy of c and i
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}:i-{1}:Thread:{2}", c, i, Thread.CurrentThread.ManagedThreadId);
            }
        }
        #endregion

        #region common reference to the same object instance

        bool done = false;
        public static void ObjectEx()
        {
            ThreadEx obj = new ThreadEx();
            new Thread(obj.ObjectPrint).Start();
            obj.ObjectPrint();
        }

        private void ObjectPrint()
        {

            if (!done) //done is shared by both threads
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("{0}:i-{1}:Thread:{2}", done, i, Thread.CurrentThread.ManagedThreadId);
                }
                done = true;
            }

        }
        #endregion

        #region Static fields are shared
        static bool sharedDone = false;
        public static void StaticEx()
        {
            ThreadEx obj = new ThreadEx();
            new Thread(obj.StaticPrint).Start();
            obj.StaticPrint();
        }

        private void StaticPrint()
        {
            Console.WriteLine("Processor count:{0}", System.Environment.ProcessorCount);
            if (!sharedDone) //sharedDone is shared by all threads
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}:i-{1}:Thread:{2}", done, i, Thread.CurrentThread.ManagedThreadId);
                }
                done = true;
            }

        }
        #endregion

        #region Exclusive lock
        Object objLocker = new object();

        static bool lockDone = false;
        public static void LockEx()
        {
            ThreadEx obj = new ThreadEx();
            new Thread(obj.LockPrint).Start();
            obj.LockPrint();
        }

        private void LockPrint()
        {
            lock (objLocker)
            {
                if (!lockDone) //sharedDone is shared by all threads
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}:i-{1}:Thread:{2}", done, i, Thread.CurrentThread.ManagedThreadId);
                    }
                    done = true;
                }
            }
        }
        #endregion

        #region Join
        public static void JoinEx()
        {
            ThreadEx obj = new ThreadEx();
            Thread thread = new Thread(JoinPrint);
            thread.Start();
            thread.Join(1000);//returns true if method ends.retrun false on timeout
        }

        private static void JoinPrint()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello");
            }

        }

        #endregion

        #region Sleep
        public static void SleepEx()
        {
            ThreadEx obj = new ThreadEx();
            Thread thread = new Thread(SleepPrint);
            thread.Start();
            Thread.Sleep(1000);//returns true if method ends.retrun false on timeout
        }

        private static void SleepPrint()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello");
            }

        }
        #endregion
    }
}
