using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    class AsyncAwait
    {
        public async void MethodAsync()
        {
            CancellationTokenSource src = new CancellationTokenSource();
            CancellationToken token = src.Token;
            src.Cancel();
            var result = 0;
            try
            {
                result = await AsyncMethod(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            Console.WriteLine("MethodAsync:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("MethodAsync:IsThreadPoolThread:" + System.Threading.Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine("result of async method:" + result);
        }

        private async Task<int> AsyncMethod(CancellationToken token)
        {
            try
            {
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
                await Task.Delay(5000);
                Console.WriteLine("AsyncMethod:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("AsyncMethod:IsThreadPoolThread:" + System.Threading.Thread.CurrentThread.IsThreadPoolThread);
                Console.WriteLine("i am from async method");
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
                return 1;
            }
            finally
            {
                Console.WriteLine("Finally is reached");
            }

        }
    }
}
