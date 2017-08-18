using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ChildClass : ParentClass
    {
        public override void Display()
        {
            Console.WriteLine(GetMessage());
        }

        private string GetMessage()
        {
            return "Message from ChildClass GetMessage";
        }

        //public new void Display()      //we can not have method with same parameter type
        //{
        //    Console.WriteLine(GetMessage());
        //    Console.WriteLine("Message from child class new method");
        //}

        public void AnotherMethod()
        {
            Console.WriteLine("Another method in child class");
        }
    }
}
