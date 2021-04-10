using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idź_na_ryby
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        public Deck(string FileName)
        {
            cards = new List<Card>();
            StreamReader reader = new StreamReader(FileName);
            while (!reader.EndOfStream)
            {
                bool invalidCard = false;
                string nextCard = reader.ReadLine();
                string[] cardParts = nextCard.Split(new char[] { ' ' });
                Values value = Values.Ace;
                switch (cardParts[0])
                {
                    case "Ace": value = Values.Ace; break;
                    case "Two": value = Values.Two; break;
                    case "Three": value = Values.Three; break;
                    case "Four": value = Values.Four; break;
                    case "Five": value = Values.Five; break;
                    case "Six": value = Values.Six; break;
                    case "Seven": value = Values.Seven; break;
                    case "Eight": value = Values.Eight; break;
                    case "Nine": value = Values.Nine; break;
                    case "Ten": value = Values.Ten; break;
                    case "Jack": value = Values.Jack; break;
                    case "Queen": value = Values.Queen; break;
                    case "King": value = Values.King; break;
                    default: invalidCard = true; break;
                }
                Suits suit = Suits.Clubs;
                switch (cardParts[2])
                {
                    case "Spades": suit = Suits.Spades; break;
                    case "Clubs": suit = Suits.Clubs; break;
                    case "Hearts": suit = Suits.Hearts; break;
                    case "Diamonds": suit = Suits.Diamonds; break;
                    default: invalidCard = true; break;
                }
                if (!invalidCard)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }
        public int Count { get { return cards.Count; } }
        public void Add(Card cartToAdd)
        {
            cards.Add(cartToAdd);
        }
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }
        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_byValue());
        }
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }
        public Card Deal()
        {
            return Deal(0);
        }
        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }
        public void WriteCards(string FileName)
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    writer.WriteLine(cards[i].Name);
                }
            }
        }
    }
}
