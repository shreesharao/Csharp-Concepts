using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass pObj = new ChildClass();

            //ChildClass cObj =new ParentClass(); //object creation does not support contrvariance
            ChildClass cObj = new ChildClass();

            pObj.Display();

            cObj.AnotherMethod();

            Console.Read();
        }
    }
}
