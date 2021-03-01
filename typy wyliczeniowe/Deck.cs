using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typy_wyliczeniowe
{
    class Deck
    {
        List<Card> cards = new List<Card>();
        cards.Add(new Card(Suits.Diamonds, Values.King));
        cards.Add(new Card(Suits.Clubs, Values.Three));
        cards.Add(new Card(Suits.Hearts, Values.Ace));

        private Card[] cards =
        {
            new Card(Suits.Spades, Values.Ace),
            new Card(Suits.Spades, Values.Two),
            new Card(Suits.Spades, Values.Three),
            //...
            new Card(Suits.Diamonds, Values.Queen),
            new Card(Suits.Diamonds, Values.King),

            

        };
        public void PrintCards()
        {
            for (int i = 0; i < cards.Length; i++)
                Console.WriteLine(cards[i].Name);
        }
        
    }
}
