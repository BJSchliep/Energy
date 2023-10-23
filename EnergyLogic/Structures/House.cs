using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class House : Structure
    { 
        public override StructureType Type => StructureType.House;

        public override Build Building { get; }

        public House(Build build) 
        {
            Building = build;
        }

        public override Structure Copy()
        {
            House copy = new House(Building);
            return copy;
        }
    }
}
