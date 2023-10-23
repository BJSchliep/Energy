using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Biomass : Structure
    {
        public override StructureType Type => StructureType.Biomass;

        public override Build Building { get; }

        public Biomass(Build build)
        {
            Building = build;
        }

        public override Structure Copy()
        {
            Biomass copy = new Biomass(Building);
            return copy;
        }
    }
}
