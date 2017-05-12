using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sockets = System.Net.Sockets;

namespace TcpClient
{
    public class Client
    {
        private int _port;
        private string _ip = string.Empty;
        Sockets.TcpClient _tcpClinet = null;
        Sockets.NetworkStream _netwrokStream = null;

        public Sockets.NetworkStream NetworkStream
        {
            get
            {
                if (_netwrokStream == null)
                {
                    _netwrokStream = TcpClient.GetStream();

                }
                return _netwrokStream;
            }
        }

        public Sockets.TcpClient TcpClient
        {
            get
            {
                if (_tcpClinet == null)
                {
                    _tcpClinet = new Sockets.TcpClient(_ip, _port);
                }
                return _tcpClinet;
            }
        }
        public Client(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public void WriteRquest(string query)
        {
            NetworkStream.Write(Encoding.UTF8.GetBytes(query), 0, query.Length);
        }

        public string ReadResponse()
        {
            byte[] respBytes=new byte[sizeof(Int32)];
            NetworkStream.Read(respBytes, 0, sizeof(Int32));
            var resp = Encoding.UTF8.GetString(respBytes);
            return resp;
        }


    }
}
