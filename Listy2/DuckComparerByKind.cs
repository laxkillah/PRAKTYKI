﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy2
{
    public class DuckComparerByKind :IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
                return -1;
            if (x.Kind > y.Kind)
                return 1;
            else
                return 0;

        }
    }
}
