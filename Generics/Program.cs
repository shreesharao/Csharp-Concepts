using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //int array
            GenericArray<int> array = new GenericArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                array.SetItem('A', i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array.GetItem(i));
            }

            //string array
            GenericArray<string> sArray = new GenericArray<string>(5);
            for (int i = 0; i < 5; i++)
            {
                sArray.SetItem("AA", i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sArray.GetItem(i));
            }

            //generic swap
            int x = 10, y = 20;
            Console.WriteLine("before:" + x + ":" + y);
            GenericSwap gSwap = new GenericSwap();
            gSwap.Swap(ref x, ref y);
            Console.WriteLine("after:" + x + ":" + y);

            string sx = "ten", sy = "twenty";
            Console.WriteLine("before:" + sx + ":" + sy);
            GenericSwap gsSwap = new GenericSwap();
            gsSwap.Swap(ref sx, ref sy);
            Console.WriteLine("after:" + sx + ":" + sy);

            //default keyword usage
            gSwap.ReturnDefault(ref x);
            Console.WriteLine(x);
            gsSwap.ReturnDefault(ref sx);
            Console.WriteLine(sx);

            Console.Read();
        }
    }
}
