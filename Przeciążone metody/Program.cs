using System;

namespace Przeciążone_metody
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            Console.WriteLine(doesItMatch);
        }
    }
}
