using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzadzanie_ulem
{
    public interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        int SharpenStinger(int Length);
        bool LookForEnemies();
        
        
    }
    
}
