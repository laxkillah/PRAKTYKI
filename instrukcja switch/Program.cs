using System;
using System.IO;

namespace instrukcja_switch
{
    class Program
    {
        enum BodyPart
        {
            Head,
            Shoulders,
            Knees,
            Toes
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private void WritePartInfo(BodyPart part, StreamWriter writer)
        {
            if (part == BodyPart.Head)
                writer.WriteLine("głowa jest owłosiona");
            else if (part == BodyPart.Shoulders)
                writer.WriteLine("ramiona są szerokie");
            else if (part == BodyPart.Knees)
                writer.WriteLine("kolana są guzowate");
            else if (part == BodyPart.Toes)
                writer.WriteLine("palce są malutkie");
            else
                writer.WriteLine("nieokreślona część jest nieokreślona");
        }
        private void WritePartInfo2(BodyPart part, StreamWriter writer)
        {
            switch (part)
            {
                case BodyPart.Head:
                    writer.WriteLine("głowa jest owłosiona");
                    break;
                case BodyPart.Shoulders:
                    writer.WriteLine("ramiona są szerokie");
                    break;
                case BodyPart.Knees:
                    writer.WriteLine("kolana są guzowate");
                    break;
                case BodyPart.Toes:
                    writer.WriteLine("palce są młode");
                    break;
                default:
                    writer.WriteLine("nieokreślona część jest nieokreślona");
                    break;
            }
        }
    }
}
