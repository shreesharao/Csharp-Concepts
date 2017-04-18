using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Concurrent
{
    class BlockingCollectionEx
    {
        BlockingCollection<string> objBlockingCollection = new BlockingCollection<string>(10);
        public async void Entry()
        {
            await Task.Run(() =>
             {
                 while (objBlockingCollection.Count < 9)
                 {
                     Console.WriteLine("Adding");
                     var item = GetString();
                     objBlockingCollection.Add(item);//This method is blocked when maximum limit is reached
                     //objBlockingCollection.TryAdd(item,1000);//If the add operation is not completed within the timespan value then TryAdd method returns with false value.
                 }
                 objBlockingCollection.CompleteAdding();

             });
            await Task.Run(() =>
            {
                while (!objBlockingCollection.IsCompleted)//IsCompleted property is used by consumer threads. It returns true when IsAddingCompleted is true and the BlockingCollection is empty.
                //That means when IsCompleted is true there are no items in the collection and other producer threads will not add any new item.
                {
                    Console.WriteLine(objBlockingCollection.Take());//Take method is blocked when the collection is empty. It'll unblock when any item is added by other thread.
                    //string item = string.Empty;
                    //objBlockingCollection.TryTake(out item);//If the collection is empty then this method will wait for time specify in timeout parameter. If new item is not added within the timeout value, then it returns false.
                }
                Console.WriteLine("No more items to takeout");
            });
        }

        private string GetString()
        {
            string str = "str";
            str = str + new Random().Next();
            return str;
        }


    }
}
