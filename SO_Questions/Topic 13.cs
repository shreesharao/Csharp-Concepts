using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_13
    {
        public void Entry()
        {
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(1,2,3));
            Console.WriteLine(Sum(new int[] { 1, 2, 3 }));
            //Console.WriteLine(Sum("1")); //The best overloaded method match for 'DotNet_store.Topic_13.Sum(params int[])' has some invalid arguments
        }

        private int Sum(params int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }

    }
}
