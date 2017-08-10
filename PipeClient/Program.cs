using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace PipeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client");
            StartClient();
        }

        private static void StartClient()
        {
            var client = new NamedPipeClientStream("PipesOfPiece");
            Console.WriteLine("trying to connect to server");
            client.Connect();
            Console.WriteLine("Connected to server");
            StreamReader reader = new StreamReader(client);
            StreamWriter writer = new StreamWriter(client);

            string input = "test line from client";
            writer.WriteLine(input);
            writer.Flush();
            //while (true)
            //{
            //    string line = reader.ReadLine();
            //    Console.WriteLine("Read:"+line);
            //}
            //Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        string input = "test line from client";
            //        writer.WriteLine(input);
            //        writer.Flush();
            //    }
            //});


            //Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        string line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //});

        }


    }
}
