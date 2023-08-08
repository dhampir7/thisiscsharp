using System;
using System.IO;

namespace ReadSeqNRandFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream inStream = new FileStream("a.dat", FileMode.Open);

            byte[] rbytes = new byte[8];
            int bytesRead;

            while ((bytesRead = inStream.Read(rbytes, 0, 8)) > 0)
            {
                long readValue = BitConverter.ToInt64(rbytes, 0);
                Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
            }

            inStream.Close();
        }
    }
}
