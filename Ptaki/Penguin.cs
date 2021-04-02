using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptaki
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Pingwiny nie latają!");
        }
        public override string ToString()
        {
            return "Pingwin " + base.Name;
        }
    }
}
