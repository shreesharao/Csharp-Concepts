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
            ParentClass realParentObject = new ParentClass();
            //ParentClass pObj = new ParentClass();   //Cannot create an instance of the abstract class or interface 'Inheritance.ParentClass'

            //ChildClass cObj =new ParentClass(); //object creation does not support contrvariance
            ChildClass cObj = new ChildClass();

            Console.WriteLine(cObj==pObj);// False as references are not same.
            realParentObject.Display();
            pObj.Display(); //calls child class Display() method when overriden.calls parent class Display() method when 'new' keyword is used and child class Display() method is hidden.
            cObj.Display(); //calls child class Display() method.
            cObj.AnotherMethod();
            
            Console.Read();
        }
    }
}
