using System;
using System.Threading;

namespace DotNet_store
{
    class Topic_15
    {
        Topic_15TestClass objTestClass = null; 
        public void Entry()
        {
            LazyInitializer.EnsureInitialized(ref objTestClass);
            Console.WriteLine(objTestClass.Name);
        }
    }

    class Topic_15TestClass
    {
        public Topic_15TestClass()
        {
            Console.WriteLine("Topic_15TestClass constructor");
            this.Name = "test";
        }
        public string  Name { get; set; }
    }
}
