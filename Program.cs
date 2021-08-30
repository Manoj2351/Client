using System;

namespace Client
{

    class Program
    {
        static void Main(string[] args)
        {
            TCPClient.Connect();
            Console.Read();
        }
    }
}
