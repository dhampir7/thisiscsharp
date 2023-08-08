using System;
using System.IO;

namespace BinaryFileExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
            {
                // Write a long string to the file
                string longString = new string('X', 300);
                bw.Write(longString);
            }

            using (BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open)))
            {
                Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
                string readString = br.ReadString();
                Console.WriteLine($"Read String Length: {readString.Length}");
            }
        }
    }
}
