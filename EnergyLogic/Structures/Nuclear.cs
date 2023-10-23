using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Nuclear : Structure
    {
        public override StructureType Type => StructureType.Nuclear;
        public override Build Building { get; }

        public Nuclear(Build build)
        {
            Building = build;
        }

        public override Structure Copy()
        {
            Nuclear copy = new Nuclear(Building);
            return copy;
        }
    }
}
