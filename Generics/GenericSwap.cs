using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericSwap
    {
        public void Swap<T>(ref T param1, ref T param2)
        {
            var temp = param2;
            param2 = param1;
            param1 = temp;
        }

        public void ReturnDefault<T>(ref T temp)
        {
            T temp1 = default(T);
            temp = temp1;
        }
    }
}
