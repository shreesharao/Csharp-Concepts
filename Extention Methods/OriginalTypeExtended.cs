using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods
{
    
    static class OriginalTypeExtended
    {
        public static void Draw(this Extention_Methods.OriginalType obj)
        {
            
            Console.WriteLine("I am in the extended type");
        }
    }
}
