﻿using System;
using System.Collections.Generic;
using System.Text;

namespace virtual_i_override
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }
        private string writtenDownCombination = null;
        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }
        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }

}
