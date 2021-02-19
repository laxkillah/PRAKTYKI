using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace słoń
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI() { MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów szerokości.", Name + " mówi..."); }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " mówi: " + message);
           
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message, this);
            
            
            
        }
    }
}
