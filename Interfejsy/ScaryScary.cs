using System;
using System.Collections.Generic;
using System.Text;

namespace Interfejsy
{
    public class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
        : base(funnyThingIHave) { this.numberOfScaryThings = numberOfScaryThings; }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return "Mam " + numberOfScaryThings + " pająków"; }
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam cię!" + base.funnyThingIHave);
        }
    }
}
