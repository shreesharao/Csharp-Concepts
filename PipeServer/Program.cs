using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace PipeServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server");
            StartServer();
            Console.Read();
        }

        private static void StartServer()
        {
            var server = new NamedPipeServerStream("PipesOfPiece");
            Console.WriteLine("started waiting for client to connect ");
            //server.WaitForConnection();
           var result= server.BeginWaitForConnection(BeginWaitForConnectionCallBack, server);
          
            //Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        string input = "test line from server";
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

        private static void BeginWaitForConnectionCallBack(IAsyncResult ar)
        {
            Console.WriteLine("client connected");
            StreamReader reader = new StreamReader((NamedPipeServerStream)ar.AsyncState);
            StreamWriter writer = new StreamWriter((NamedPipeServerStream)ar.AsyncState);
            //while (true)
            //{
            //    string input = "test line from server";
            //    writer.WriteLine(input);
            //    writer.Flush();
            //}

            var line = reader.ReadLine();
            Console.WriteLine("Read:"+line);

         
        }
    }
}
