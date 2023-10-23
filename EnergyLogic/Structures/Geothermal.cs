using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Geothermal : Structure
    {
        public override StructureType Type => StructureType.Geothermal;

        public override Build Building { get; }

        public Geothermal(Build build)
        {
            Building = build;
        }

        public override Structure Copy()
        {
            Geothermal copy = new Geothermal(Building);
            return copy;
        }
    }
}
