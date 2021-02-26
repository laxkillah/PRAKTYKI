using System;

namespace testowe_inferfejs
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            someOtherScaryClown.ScareLittleChildren();
            someOtherScaryClown.HonkHonk();

            Console.ReadKey();
        }
    }
}
