using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public abstract class Structure
    {
        public abstract StructureType Type { get; }
        public abstract Build Building { get; }

        public abstract Structure Copy();
    }
}
