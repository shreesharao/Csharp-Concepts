using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
    public class Worker
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
    }
}
