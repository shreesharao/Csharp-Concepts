using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    class Example
    {
        #region EXAMPLE1
        //EXAMPLE1:WE CAN AWAIT ANY METHOD WHICH RETURNS TASK
        public async Task NewStuffAsync()
        {
            // Use await and have fun with the new stuff.
            //await ...
        }

        public Task MyOldTaskParallelLibraryCode()
        {
            // Note that this is not an async method, so we can't use await in here.
            //...
            return null;
        }

        public async Task ComposeAsync()
        {
            // We can await Tasks, regardless of where they come from.
            await NewStuffAsync();
            await MyOldTaskParallelLibraryCode();
        }
        #endregion

        #region Example2
        //I mentioned that when you await a built-in awaitable,
        //then the awaitable will capture the current “context” and later apply it to the remainder of the async method
        // ASP.NET example
        protected async void MyButton_Click(object sender, EventArgs e)
        {
            // Since we asynchronously wait, the ASP.NET thread is not blocked by the file download.
            // This allows the thread to handle other requests while we're waiting.
            //await DownloadFileAsync(...);

            // Since we resume on the ASP.NET context, we can access the current request.
            // We may actually be on another *thread*, but we have the same ASP.NET request context.
            //Response.Write("File downloaded!");
        }
        #endregion

        #region Example3
        //Contexts in example2 can be avoided using ConfigureAwait(false)
        private async Task DownloadFileAsync(string fileName)
        {
            //Use HttpClient or whatever to download the file contents.
            // var fileContents = await DownloadFileContentsAsync(fileName).ConfigureAwait(false);

            //Note that because of the ConfigureAwait(false), we are not on the original context here.
            //Instead, we're running on the thread pool.

            //Write the file contents out to a disk file.
            //await WriteToDiskAsync(fileName, fileContents).ConfigureAwait(false);

            // The second call to ConfigureAwait(false) is not *required*, but it is Good Practice.
        }

        #endregion

        #region Example4:WhenAll
        Task[] tasks = new Task[3];
        //tasks[0] = DoOperation0Async();
        //tasks[1] = DoOperation1Async();
        //tasks[2] = DoOperation2Async();

        // At this point, all three tasks are running at the same time.

        // Now, we await them all.
        //await Task.WhenAll(tasks);
        #endregion

        #region Example5:WhenAny
        public async Task<int> GetFirstToRespondAsync()
        {
            // Call two web services; take the first response.
            //Task<int>[] tasks = new[] { WebService1Async(), WebService2Async() };

            // Await for the first one to respond.
            //Task<int> firstTask = await Task.WhenAny(tasks);

            // Return the result.
            // return await firstTask;
            return 0;//to avoid build error
        }
        #endregion

        #region Task Cnacellation
        // public async Task<int> CancelAsync()
        // {
        //    try
        //    {
        //        var tokenSource2 = new CancellationTokenSource();
        //        CancellationToken ct = tokenSource2.Token;
        //        Console.WriteLine("entered CancelAsync");
        //        await Task.Run(() =>
        //        {
        //            Console.WriteLine("Task.Run:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
        //            try
        //            {
        //                // Were we already canceled?
        //                ct.ThrowIfCancellationRequested();

        //                bool moreToDo = true;
        //                while (moreToDo)
        //                {
        //                    // Poll on this property if you have to do
        //                    // other cleanup before throwing.
        //                    if (ct.IsCancellationRequested)
        //                    {
        //                        // Clean up here, then...
        //                        ct.ThrowIfCancellationRequested();
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //                throw;
        //            }

        //        }, tokenSource2.Token); // Pass same token to StartNew.

        //        Console.WriteLine("cancelling..");
        //        tokenSource2.Cancel();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw ex;
        //    }
        //    return 0;
        //}

        //public async Task CancelAsyncCaller()
        //{
        //  int result=  await CancelAsync();
        // }
        #endregion

        #region Task Progress
        //        private async void btnDownload_Click(object sender, RoutedEventArgs e)  
        //{
        //    btnDownload.IsEnabled = false;
        //    try
        //    {
        //        txtResult.Text = await DownloadStringAsync(txtUrl.Text, 
        //            new Progress<int>(p => pbDownloadProgress.Value = p));
        //    }
        //    finally { btnDownload.IsEnabled = true; }
        //}

        #endregion

    }
}
