using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_14
    {

        Lazy<TestClass> objTestClass = new Lazy<TestClass>();
        Lazy<AnotherTestClass> objAnotherTestClass = new Lazy<AnotherTestClass>(AnotherTestClass.Init);//initialization logic can be written here
        Lazy<AnotherTestClass> objYetAnotherTestClass = new Lazy<AnotherTestClass>(() => new AnotherTestClass("test")); //call paramterized construcotr
        public Topic_14()
        {
            Console.WriteLine("Topic_14 class constructor");
        }
        public void Entry()
        {
            Console.WriteLine(objTestClass.Value.Prop1);
            Console.WriteLine(objTestClass.Value.Prop2);
            Console.WriteLine(objAnotherTestClass.Value.Name);
            Console.WriteLine("objAnotherTestClass.IsValueCreated:" + objAnotherTestClass.IsValueCreated);
        }
    }

    class TestClass
    {
        public int Prop1
        {
            get
            {
                return 10;
            }
        }
        public string Prop2
        {
            get
            {
                return "test";
            }
        }
        static TestClass()
        {
            Console.WriteLine("Test class static constructor");
        }
        public TestClass()
        {
            Console.WriteLine("test class constructor");
        }
    }

    class AnotherTestClass
    {
        public string Name
        {
            get;

            set;
        }
        public AnotherTestClass()
        {
            Console.WriteLine("AnotherTestClass constructor");
        }

        public AnotherTestClass(string name)
        {
            this.Name = name;
            Console.WriteLine("AnotherTestClass parameterized constructor");
        }

        public static AnotherTestClass Init()
        {
            Console.WriteLine("AnotherTestclass Init Method");
            return new AnotherTestClass();
        }
    }
}
