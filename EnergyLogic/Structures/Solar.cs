using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Solar : Structure
    {
        public override StructureType Type => StructureType.Solar;

        public override Build Building { get; }

        public Solar(Build build) 
        {
            Building = build;
        }

        public override Structure Copy()
        {
            Solar copy = new Solar(Building);
            return copy;
        }
    }
}
