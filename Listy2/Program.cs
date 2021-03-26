using System;
using System.Collections.Generic;

namespace Listy2
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            DuckComparer comparer = new DuckComparer();
            Duck[] duckArray = new Duck[6];
            duckArray.GetEnumerator();
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() {Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13 },
            };
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck);
            Console.WriteLine("Koniec kaczek!");
        }
        
    }
}
