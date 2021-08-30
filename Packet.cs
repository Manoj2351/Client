using System.Text;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public class Packet
    {
        public byte[] ReadableBuffer;
        public List<byte> Buffer;

        public Packet(string Msg)
        {
            Buffer = new List<byte>();
            Write(Msg);
        }
        public void Write(string _string)
        {
            Buffer.InsertRange(0,Encoding.ASCII.GetBytes(_string)); 
        }

        public byte[] ConvertToArray()
        {
            ReadableBuffer = Buffer.ToArray();
            return ReadableBuffer;
        }        
        
        //reference https://github.com/tom-weiland/tcp-udp-networking/blob/8692304a76abb56fc3145fd01cd09339b1347b2b/GameClient/Assets/Scripts/Packet.cs#L131

        #region ShitCode

//        public string Message;
//
//         public Packet(string _Message)
//         {
//             Message = _Message;
//         }
//         
//
//         /*TODO for now I dont have opika to implement stuff but here is a small note
//         1) Add a serialization class which can take care of all the serialisation and vice versa
//         2)Ig u can use the inbuilt Stream.sendbytes() func for sending and recieve bytes for recieving try 
//         Experimenting
//
//         Code snippet from stack overflow
//         https://stackoverflow.com/questions/15012549/send-typed-objects-through-tcp-or-sockets
//         */


        #endregion
    }
    
}
