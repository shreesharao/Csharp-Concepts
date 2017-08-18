using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   class ParentClass
    {
        public virtual void Display()
        {
            Console.WriteLine(GetMessage());
        }

       private string GetMessage()
        {
            return "Message from parent class";
        }
    }
}
