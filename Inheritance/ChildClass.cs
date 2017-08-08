using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ChildClass:ParentClass
    {
        public override void Display()
        {
            Console.WriteLine("Message from child class");
        }

        //public new void Display()      //we can not have method with same parameter type
        //{
        //    Console.WriteLine("Message from child class");
        //}

        public void AnotherMethod()
        {
            Console.WriteLine("Another method in child class");
        }
    }
}
