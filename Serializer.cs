using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public class Serializer
    {
        public static byte[] Serialize(Packet _packet)
        {
            using (var memoryStream = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(memoryStream,_packet);
                return memoryStream.ToArray();
            }
        }

        public static Object Deserialize(byte[] inBinary)
        {
            using (var MemoryStream = new MemoryStream(inBinary))
            {
                return (new BinaryFormatter()).Deserialize(MemoryStream);
            }
        }
    }
}