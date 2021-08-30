using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class TCPClient
    {
        static TcpClient client;
        private static NetworkStream networkStream;

        private static byte[] ReceiveBuffer = new byte[4096];
        public static void Connect()
        {
            client = new TcpClient("127.0.0.1",8888);
            networkStream = client.GetStream();
            networkStream.BeginRead(ReceiveBuffer, 0, 4096, ReceiveCallback,null);
            //this func may take time 
        }

        static void ReceiveCallback(IAsyncResult _result)
        {
            Console.WriteLine("Received data");
            int _byteLength = networkStream.EndRead(_result);
            byte[] _data = new byte[_byteLength];
            
            Array.Copy(ReceiveBuffer,_data,_byteLength);
            Array.Clear(ReceiveBuffer,0,_byteLength);
            Console.WriteLine(_data);
            Packet receivedPacket = (Packet) Serializer.Deserialize(_data);
            
            Console.WriteLine(receivedPacket.Message);
            networkStream.BeginRead(ReceiveBuffer, 0, 4096, ReceiveCallback,null);
            
        }
    }
}