using System;
using System.Collections.Generic;
using System.Text;

namespace virtual_i_override
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuje za zwrócenie klejnotów! " + safeContents.Sparkle());
        }
    }
}
