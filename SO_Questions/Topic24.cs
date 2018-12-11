using System;

namespace DotNet_store
{
    class Topic24
    {
        public void Entry()
        {
            int two = 2; //010

            int four = two << 1; //left shift operator - 100
            int one = two >> 1; //right shift operator - 001

            Console.WriteLine(four);
            Console.WriteLine(one);

            int three = 3; //011
            int twelve = three << 2; //1100
            int zero = three >> 2; //000

            Console.WriteLine(twelve);
            Console.WriteLine(zero);
        }
    }
}
