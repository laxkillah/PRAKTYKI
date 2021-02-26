using System;

namespace Interfejsy
{
    public class TallGuy : IClown 
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave { get { return "duże buty"; } }
        public void Honk()
        {
            Console.WriteLine("Tut tuut!");
        }
        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu.");
        }
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Adam" };
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
            ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();
        }
    }
}
