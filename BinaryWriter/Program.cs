using System;
using System.IO;

namespace WriterBinary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string stringValue = "Witaj!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            using (FileStream output = File.Create("danebinarne.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(byteArray);
                writer.Write(floatValue);
                writer.Write(charValue);
            }
            byte[] dataWritten = File.ReadAllBytes("danebinarne.dat");
            foreach (byte b in dataWritten)
                Console.Write("{0:x2} ", b);
            Console.WriteLine(" - {0} bajtów", dataWritten.Length);
            Console.ReadKey();

            using (FileStream input = File.OpenRead("danebinarne.dat"))
            using (BinaryReader reader = new BinaryReader(input))
            {
                int intRead = reader.ReadInt32();
                string stringRead = reader.ReadString();
                byte[] byteArrayRead = reader.ReadBytes(4);
                float floatRead = reader.ReadSingle();
                char charRead = reader.ReadChar();

                Console.Write("int: {0} string: {1} bajty: ", intRead, stringRead);
                foreach (byte b in byteArrayRead)
                    Console.Write("{0} ", b);
                Console.Write(" float: {0} char: {1} ", floatRead, charRead);
            }
            Console.ReadKey();

            using (StreamReader reader = new StreamReader(@"c:\Users\mzdro\Desktop\1.txt"))
            using (StreamWriter writer = new StreamWriter(@"c:\Users\mzdro\Desktop\2.txt", false))
            {
                int position = 0;
                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += charactersRead;
                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = String.Format("{0:x2}", (byte)buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else
                            writer.Write("   ");
                        if (i == 7) { writer.Write("--"); }
                        if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = '.'; }
                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine("   " + bufferContents.Substring(0, charactersRead));
                }
            }    

        }
    }
}
