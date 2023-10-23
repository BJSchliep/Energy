using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Business : Structure
    {
        public override StructureType Type => StructureType.Business;

        public override Build Building { get; }
        
        public Business(Build build)
        {
            Building = build;
        }
        public override Structure Copy()
        {
            Business copy = new Business(Building);
            return copy;
        }
        
    }
}
