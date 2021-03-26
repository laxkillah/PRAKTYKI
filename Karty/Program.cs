using System;
using System.Collections.Generic;

namespace Karty
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Pięć losowych kart");
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits)random.Next(4),
                    (Values)random.Next(1, 14)));
                Console.WriteLine(cards[i].Name);
            }

            Console.WriteLine();
            Console.WriteLine("Te same karty posortowane:");
            cards.Sort(new CardComparer());
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadKey();
        }
    }
}
