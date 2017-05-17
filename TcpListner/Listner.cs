using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Sockets = System.Net.Sockets;
using System.IO;

namespace TcpListner
{
    public class Listner
    {
        IPAddress _ip = null;
        int _port = 0;
        Sockets.TcpListener _tcpListener = null;

        public Sockets.TcpListener TcpListener
        {
            get
            {
                if (_tcpListener == null)
                {
                    _tcpListener = new Sockets.TcpListener(_ip, _port);
                }
                return _tcpListener;
            }

        }
        public Listner(string ip, int port)
        {
            _ip = IPAddress.Parse(ip);
            _port = port;
        }

        public void BeginListening()
        {
            TcpListener.Start();
            IAsyncResult asynResult = TcpListener.BeginAcceptSocket(new AsyncCallback(StartSocket), TcpListener);
        }

        private void StartSocket(IAsyncResult asyncResult)
        {
            Sockets.TcpListener listener = asyncResult.AsyncState as Sockets.TcpListener;
            Sockets.Socket socket = listener.EndAcceptSocket(asyncResult);
            socket.SetSocketOption(Sockets.SocketOptionLevel.Socket, Sockets.SocketOptionName.Linger, new Sockets.LingerOption(true, 1));

            using (Stream stream = new Sockets.NetworkStream(socket))
            {
                byte[] reqBuf = new byte[sizeof(Int32)];
                byte[] reqSizeBuf = new byte[sizeof(Int32)];
                int bytesRead = stream.Read(reqSizeBuf, 0, sizeof(Int32));
                int requestSize = BitConverter.ToInt32(reqSizeBuf, 0) - sizeof(Int32);
                string request = Encoding.UTF8.GetString(reqBuf);
            }

            using (Stream stream = new Sockets.NetworkStream(socket))
            {
                string response = "response message";
                stream.Write(Encoding.UTF8.GetBytes(response), 0, response.Length);
                socket.Shutdown(Sockets.SocketShutdown.Send);
            }
        }

    }
}
