using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using TcpClient;
using TcpListner;

namespace TcpExecutor
{
    class Program
    {
       static Client _client = null;

        static void Main(string[] args)
        {
            var _ip = "127.0.0.1";
            var _port = 9169;


           // InitTcpListner(_ip, _port);
            SendRequest(_ip,_port);
            var resp = ReadResponse();
            Console.WriteLine(resp);
            Console.Read();
        }

        private static string ReadResponse()
        {
            var resp = _client.ReadResponse();
            return resp;
        }

        private static void SendRequest(string ip,int port)
        {
            _client= new Client(ip,port);
            _client.WriteRquest(GetQuery());

        }

        private static string GetQuery()
        {
            string queries =File.ReadAllText(@"../../Queries.txt");
            return queries.Trim();
        }

        private static void InitTcpListner(string ip,int port)
        {
            Listner listner = new Listner(ip, port);
            listner.BeginListening();
        }
    }
}
