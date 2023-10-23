using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Hydroelectric : Structure
    {
        public override StructureType Type => StructureType.Hydroelectric;

        public override Build Building { get; }

        public Hydroelectric(Build build)
        {
            Building = build;
        }

        public override Structure Copy()
        {
            Hydroelectric copy = new Hydroelectric(Building);
            return copy;
        }
    }
}
