using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    class AsyncAwait
    {
        public async void MethodAsync()
        {
            int result = await AsyncMethod();
            Console.WriteLine("result of async method:" + result);
        }

        private async Task<int> AsyncMethod()
        {
            try
            {
                await Task.Delay(5000);
                Console.WriteLine("i am from async method");
                return 1;
            }
            finally
            {
                Console.WriteLine("Finally is reached");
            }
           
        }
    }
}
