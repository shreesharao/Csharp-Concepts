using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    interface I1
    {
        void TestMethod();
    }

    interface I2
    {
        void TestMethod();
    }

    class Topic_11:I1,I2
    {
        public void Entry()
        {
            int i = 0;
            TestMethod();
            //I1 i1 = new I1();  //can not create an instance of interface and abstract class
            I1 i1 = new Topic_11();
            i1.TestMethod();

            I2 i2 = new Topic_11();
            i2.TestMethod();
        }

        public void TestMethod()
        {
            Console.WriteLine("Hello from test method");
        }

        //Explicit implementation
            //can not use access specifiers
        void I1.TestMethod()
        {
            Console.WriteLine("I1");
        }

        void I2.TestMethod()
        {
            Console.WriteLine("I2");
        }
    }
}
