using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*WHAT I OBSERVED
     * interfaces can not contain fields ex:int x. but can contain properties
     * interfaces can  only contain function declarations
     * inheriting class must provide definition of interface members
     * the method must be public in child class otherwise we will get error
     * interfaces can not call other members in the class
     * interfaces help us to achieve runtime polymorphism..check TestRuntimePolymorphism method.
     * using interfaces we can invoke functions from different classes using the same interface reference
     * interfaces resolve the multiple inheritance problem.check program2 class
     * how can we have an implementation of xyz that is specific to interface abc and implementation of xyz that is specific to abc2 inside class program3? Well, for this we need to use the fully qualified names
     * when using fully qualified name we should not use public access specifiers.otherwise we will get Error- 'The modifier 'public' is not valid for this item
     * Interfaces support inheritance.check interface3 and program4 class
     * even if interface abc2 inherits from the interface abc, the fully qualified name of the function xyz() remains as abc.xyz and not abc2.xyz
     * */
    class Program
    {
        static void Main(string[] args)
        {
            program2 obj2 = new program2();
            program3 obj = new program3();
            Test(obj);
            TestRuntimePolymorphism(obj2);
            TestRuntimePolymorphism(obj);
            Console.Read();
           
        }

        public static void Test(object o)
        {
            Iabc abc = (Iabc)o;
            Iabc2 abc2 = (Iabc2)o;
            abc.xyz();
            abc2.xyz();
        }

        public static void TestRuntimePolymorphism(Iabc obj)
        {
            obj.xyz();
        }

        
    }

    class program2:Iabc,Iabc2
    {
        public void xyz()
        {
            Console.WriteLine("i am from program2");
        }

        public void abc()
        {

        }

    }
    class program3 : Iabc,Iabc2
    {
         void Iabc.xyz()
        {
            Console.WriteLine("i am xyz for abc");
        }

         void Iabc2.xyz()
        {
            Console.WriteLine("i am xyz for abc2");
        }

    }

    class program4 : interface3
    {
       public void xyz()
        { }

    }


    interface Iabc
    {
        void xyz();
    }

    interface Iabc2
    {
        void xyz();
    }

   interface  interface3:Iabc
   { }
}
