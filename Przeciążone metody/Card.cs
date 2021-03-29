using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciążone_metody
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }


        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }
        public override string ToString()
        {
            return Name;
        }
        public static bool DoesCardMatch(Card CardToCheck, Suits Suit)
        {
            if (CardToCheck.Suit == Suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DoesCardMatch(Card CardToCheck, Values Value)
        {
            if(CardToCheck.Value == Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
