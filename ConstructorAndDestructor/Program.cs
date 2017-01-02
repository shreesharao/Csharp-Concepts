using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
    /*
     problem with destructor
     * problem with finalize
     * singleton pattern
     * garbage collection
     */

    /*
                 * A constructor looks like a special method having no return type and its name is same with the class name.
            constructor can be overloaded as well, meaning we can have several constructors, with the same name, but different parameters. 
            If we do not declare constructor explicitly for a class, compiler will create a default constructor at run time.
            Access modifiers of constructor can be public, private, protected, internal and extern.

            Private constructors generally used in classes that contain static members only.
            A private constructor cannot be externally called. It is used to ensure higher-quality code bases on complex projects. A private constructor forces the class to provide a controlled and unified access pattern.
            A private constructor restricts access to the constructor. It ensures the object can only be created by a member in the type.Therefore:
            The private constructor is a desirable part of the singleton pattern implementation in the C# language.

            Static constructor is used to initialize static data members as soon as the class is referenced first time.
            A static constructor does not take access modifiers or have parameters and can't access any non-static data member of a class.
            The static constructor for a class executes after the static field initializers (if any) for the class
            Since static constructor is a class constructor, they are guaranteed to be called as soon as we refer to that class or by creating an instance of that class.
            static constructors are helpful when we want to initialize static members conditionally.
            A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
 
            Since C# is garbage collected, meaing that the framework will free the objects that you no longer use, 
            there may be times where you need to do some manual cleanup.
            A destructor, a method called once an object is disposed, can be used to cleanup resources used by the object.
            Once the object is collected by the garbage collector, this method is called.
     * */
    class Program
    {

        static void Main(string[] args)
        {
            Worker worker;
            worker = new Worker();
            Console.WriteLine("Program ended");
            worker = null;
            GC.Collect();
            worker = new Worker();
            Console.WriteLine("worker.ToString() called");
            // worker.ToString();


        }

    }
}
