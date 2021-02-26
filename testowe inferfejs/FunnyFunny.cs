using System;
using System.Collections.Generic;
using System.Text;

namespace testowe_inferfejs
{
    public class FunnyFunny : IClown
    {
        
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return "Cześć dzieciaki! Mam " + funnyThingIHave; } }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }


    }

}
