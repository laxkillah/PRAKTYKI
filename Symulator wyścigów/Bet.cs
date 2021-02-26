using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symulator_wyścigów
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public string GetDescription()
        {
            if (Amount >= 5 && Amount <= 15)
            {
                return Bettor.Name + " postawił " + Amount + " zł na psa numer" + Dog;
            }
            else
            {
                return this.Bettor.Name + " nie zawarł zakładu";
            }
        }
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }

        }
    }
}
