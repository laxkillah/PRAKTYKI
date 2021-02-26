using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarzadzanie_ulem
{
    public interface INectarCollector
    {
        int Nectar { get; set; }
        void FindFlowers();

        void GatherNectar();

        void ReturnToHive();
        
    }
}
