using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Turbin : Structure
    {
        public override StructureType Type => StructureType.Turbin;

        public override Build Building { get; }

        public Turbin(Build building)
        {
            Building = building;
        }

        public override Structure Copy()
        {
            Turbin copy = new Turbin(Building);
            return copy;
        }
    }
}
