using System;
using System.Collections.Generic;

namespace Listy2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() {Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13 },
            };
            ducks.Sort();
            Console.ReadKey();
            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.Size.ToString() + "-centymetrowa kaczka " + duck.Kind.ToString());
                Console.WriteLine("Koniec kaczek!");
        }
    }
}
