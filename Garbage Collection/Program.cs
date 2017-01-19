using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var obj = new ChildSampleClass())
            {
                //work on the object here
                //once the control leaves this block Dispose method on
                //this object is automatically called
            }
        }
    }
}
