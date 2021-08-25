using System;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class TCPClient
    {
        static TcpClient client;
        public static void Connect()
        {
            client = new TcpClient("127.0.0.1",8888);
    
        }
    }
}