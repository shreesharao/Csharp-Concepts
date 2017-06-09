using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;


namespace UnitTestingProject
{

    [TestClass]
    public class UnitTest2 : CommonTest
    {
        public UnitTest2()
        {
            UnitTest1.Write(string.Format("UnitTest2 Constructor:Threadid-{0}", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        //AssemblyInitialize and AssemblyCleanup can be included only once

        //[AssemblyInitialize]
        //public static void InitializeAssembly(TestContext context)
        //{
        //   UnitTest1.Write("UnitTest2 assembly initialize");
        //}

        [ClassInitialize]
        public static void InitializeClass(TestContext context)
        {
            UnitTest1.Write("UnitTest2 class init");
        }

        [TestInitialize]
        public void InitializeTest()
        {
            UnitTest1.Write("UnitTest2 test method init");
        }

        [TestCleanup]
        public void CleanupTest()
        {
            UnitTest1.Write("UnitTest2 test method cleanup");
        }
        [ClassCleanup]
        public static void CleanupClass()
        {
            UnitTest1.Write(string.Format("UnitTest2 class cleanup:Threadid-{0}", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        //[AssemblyCleanup]
        //public static void CleanupAssembly()
        //{
        //   UnitTest1.Write("UnitTest2 assembly cleanup");
        //}

        [TestMethod]
        public void MethodB()
        {
            UnitTest1.Write("MethodB");
            Trace.WriteLine("MethodB"); //writes to test output window
            Debug.WriteLine("MethodB"); //writes to output window
        }

        [TestMethod]
        public void MethodC()
        {
            UnitTest1.Write("MethodC");
            Trace.WriteLine("MethodC");
        }

        [TestMethod]
        public void MethodD()
        {
            UnitTest1.Write("MethodD");
            Trace.WriteLine("MethodD");
        }

        [TestMethod]
        public void MethodH()
        {
            UnitTest1.Write("MethodH");
        }

        [TestMethod]
        public void MethodI()
        {
            UnitTest1.Write("MethodI");
        }
    }
}
