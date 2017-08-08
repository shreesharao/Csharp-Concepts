using System;
using System.Collections.Generic;
using System.Text;

namespace Extention_Methods
{
    /*WHAT I OBSERVED
     * Introduced in c# 3.0
     *Extension methods enable you to add methods to existing types
     without creating a new derived type, recompiling, or otherwise modifying the original type
     * It must be a static method but they are called as if they were instance methods on the extended type.
     * Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.
     * There is no need for inheriting the class.
     * when the class is sealed there is no way to extend the functionality
     * 
     * An extension method must be defined in a top-level static class.
     * An extension method with the same name and signature as an instance method will not be called.
     * Extension methods cannot be used to override existing methods.
     * The concept of extension methods cannot be applied to fields, properties or events.
     * Overuse of extension methods is not a good style of programming.
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            OriginalType obj = new OriginalType();
            obj.Draw();
            obj.Print();

            string value = "shr";
            var i=value.Convert(value);
            Console.WriteLine(i); ;

            Console.Read();
        }
    }
}
