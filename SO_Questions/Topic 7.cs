using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DotNet_store
{
    class Topic_7
    {
        public void Entry()
        {
            ExampleClass exampleClass = new ExampleClass();

            ///way1
            dynamic d = exampleClass;
            int t=d.MyProperty1;

            //way2
            PropertyInfo[] properties = exampleClass.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(string.Format("{0}:{1}", property.Name, property.GetValue(exampleClass)));
            }
        }
    }

    class ExampleClass
    {
        public int MyProperty1
        {
            get;
            set;
        }
        public string MyProperty2 { get; set; }
        public bool MyProperty3 { get; set; }
        public long MyProperty4 { get; set; }
        public char MyProperty5 { get; set; }
        public List<string> MyProperty6 { get; set; }

    }
}
