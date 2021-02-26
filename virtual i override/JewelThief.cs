using System;
using System.Collections.Generic;
using System.Text;

namespace virtual_i_override
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
         override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Kradnę zawarość sejfu! " + stolenJewels.Sparkle());
        }
    }
}
