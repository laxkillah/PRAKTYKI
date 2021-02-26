using System;
using System.Collections.Generic;
using System.Text;

namespace testowe_inferfejs
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
        void HonkHonk();

    }
}
