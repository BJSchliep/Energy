using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class GridState
    {
        public Land Land {  get; }
        public Build CurrentBuild { get; private set; }

        public GridState(Build build, Land land)
        {
            CurrentBuild = build;
            Land = land;
        }

    }
}
