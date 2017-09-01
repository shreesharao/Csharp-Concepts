using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DotNet_store
{
    
    class Topic_17
    {
        Topic_17Test topic_17Test = null;
        Topic_17TestChild topic_17TestChild = null;
        public void Entry()
        {
            topic_17Test = new Topic_17Test();
            topic_17TestChild = new Topic_17TestChild();
            TestParentAttributes();
            TestChildAttributes();
            GetCallerInformation();

        }
        public void TestParentAttributes()
        {
            var attrs = Attribute.GetCustomAttributes(topic_17Test.GetType());
            foreach (var attr in attrs)
                if (attr is Topic_17AtrAttribute)
                    Console.WriteLine(attr.ToString());
        }

        public void TestChildAttributes()
        {
            var attrs = Attribute.GetCustomAttributes(topic_17TestChild.GetType());
            foreach (dynamic attr in attrs)
                if (attr is Topic_17AtrAttribute)
                {
                    Console.WriteLine(attr.ToString());
                    Console.WriteLine(attr.DisplayInfo());
                }
                   
        }

        public void GetCallerInformation([CallerMemberName]string memberName="",[CallerLineNumber]int lineNumber=0,[CallerFilePath]string filePath="")  //use System.Runtime.CompilerServices;
        {
            Console.WriteLine("Member Name:"+memberName);
            Console.WriteLine("Line Number:"+lineNumber);
            Console.WriteLine("File Path:"+filePath);
        }
    }

    [Topic_17Atr("hello",CustomDescription = "custom description")]
    [Topic_17Atr("hello", CustomDescription = "another custom description ")]
    class Topic_17Test
    {
        [method: Topic_17Atr("hello", CustomDescription = "custom description")] //another way of specifying attribute target
        public Topic_17Test()
        {
            Console.WriteLine("Topic_17Test class constructor");
        }
    }

    class Topic_17TestChild:Topic_17Test
    {
        public Topic_17TestChild()
        {
            Console.WriteLine("Topic_17TestChild class constructor");
        }
    }

    [AttributeUsage(AttributeTargets.All,AllowMultiple=true,Inherited=false)]    
    class Topic_17AtrAttribute : Attribute
    {
      
        public Topic_17AtrAttribute() //this is never called beacuse i have a parameterized constructor
        {
            Console.WriteLine("I am here. I'm the attribute default constructor!");
        }
        public Topic_17AtrAttribute(string defaultDescription)
        {
            DefaultDescription = defaultDescription;
            Console.WriteLine("I am here. I'm the attribute parameterized constructor!");
        }
        public String CustomDescription { get; set; }
        public String DefaultDescription { get; set; }

        public override string ToString()
        {
            return String.Format("Custom: {0}; Default: {1}", CustomDescription, DefaultDescription);
        }

        public string DisplayInfo()
        {
            return String.Format("Custom: {0}; Default: {1}", CustomDescription, DefaultDescription);
        }
    }
}
