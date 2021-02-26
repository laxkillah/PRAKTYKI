using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    interface IScaryClown : IClown
    { 
        string ScaryThingIHave { get; }
        void ScareLittleChildren();

    }
}
