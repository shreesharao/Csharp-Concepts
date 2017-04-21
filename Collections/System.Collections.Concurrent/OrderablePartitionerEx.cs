using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Collections.System.Collections.Concurrent
{
    class OrderablePartitionerEx
    {
        int[] input = new int[50000];
        int[] output = new int[50000];
        ManualResetEventSlim mre = new ManualResetEventSlim(false);
        Random rand = new Random();
        public void Entry()
        {
            //create some dummy data
            Task setupTask = Task.Factory.StartNew(() =>
            {
                Parallel.For(0, input.Length, (i) =>
                {
                    input[i] = rand.Next(2, 10);
                });
                mre.Set();
            });


            Task timerTask3 = Task.Factory.StartNew(() =>
            {
                // create an chunking orderable partitioner
                Stopwatch watch = new Stopwatch();
                watch.Reset();
                watch.Start();
                OrderablePartitioner<Tuple<int, int>> chunkPart = Partitioner.Create(0, input.Length, 5000);
                Console.WriteLine("KeysNormalized:{0}", chunkPart.KeysNormalized);
                Console.WriteLine("KeysOrderedAcrossPartitions:{0}", chunkPart.KeysOrderedAcrossPartitions);
                Console.WriteLine("KeysOrderedInEachPartition:{0}", chunkPart.KeysOrderedInEachPartition);
                Console.WriteLine("SupportsDynamicPartitions:{0}", chunkPart.SupportsDynamicPartitions); 

                Parallel.ForEach(chunkPart, chunkRange =>
                {
                    for (int i = chunkRange.Item1; i < chunkRange.Item2; i++)
                    {
                        output[i] = input[i] * input[i];
                    }
                });
                watch.Stop();
                Console.WriteLine("0 in input {0}", input.Where(x => x == 0).Count());
                // output.ToList().ForEach(x => Console.WriteLine(x));
                Console.WriteLine("time ellapsed for custom Partitioner version {0}ms",
                                  watch.ElapsedMilliseconds);
                Console.WriteLine("Number of results with 0 as square : {0}, " +
                     "which proves each element was hit\r\n",
                    (output.Where(x => x == 0)).Count()); mre.Set();
                mre.Set();
            });
        }


    }
}
