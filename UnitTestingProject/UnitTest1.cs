using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestingProject
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            Write(string.Format("UnitTest1 Constructor:Threadid-{0}", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }
        [AssemblyInitialize]
        public static void InitializeAssembly(TestContext context)
        {
            Write("UnitTest1 assembly initialize");
        }

        [ClassInitialize]
        public static void InitializeClass(TestContext context)
        {
            Write("UnitTest1 class init");
        }

        [TestInitialize]
        public void InitializeTest()
        {
            Write("UnitTest1 test method init");
        }

        [TestCleanup]
        public  void CleanupTest()
        {
            Write("UnitTest1 test method cleanup");
        }
        [ClassCleanup]
        public static void CleanupClass()
        {
           Write(string.Format("UnitTest1 class cleanup:Threadid-{0}", System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        [AssemblyCleanup]
        public static void CleanupAssembly()
        {
            Write("UnitTest1 assembly cleanup");
        }

        [TestMethod]
        public void MethodA()
        {
            Write("MethodA");
        }

        [TestMethod]
        public void MethodE()
        {
            Write("MethodE");
        }

        [TestMethod]
        public void MethodF()
        {
            Write("MethodF");
        }

        [TestMethod]
        public void MethodG()
        {
            Write("MethodG");
        }

        [TestMethod]
        public void Test()
        {
            Write("Test");
        }
        public static void Write(string message)
        {
            string file = "../../output.txt";

            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(message);
                writer.Flush();
            }
        }
    }
}
