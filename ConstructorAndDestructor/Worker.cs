using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
    public class Worker:IDisposable
    {
        public Worker()
        {
            Console.WriteLine("Constructor");
        }
        private Worker(string param1)
        {
            Console.WriteLine("Parameterized constructor");
        }
        static Worker()
        {
            Console.WriteLine("Static Constructor");
        }
        ~Worker()
        {
            Console.WriteLine("Destructor");
        }
        public void Test()
        {
            Console.WriteLine("test method called");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}
