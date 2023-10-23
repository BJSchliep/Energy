using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLogic
{
    public class Land
    {
        private readonly Structure[,] structures = new Structure[10, 10];

        public Structure this[int row, int col]
        {
            get { return structures[row, col]; }
            set { structures[row, col] = value; }
        }

        public Structure this[Position pos]
        {
            get { return this[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value;}
        }

        public static Land Initial()
        {
            Land land = new Land();
            land.AddStructures();
            return land;
        }

        private void AddStructures()
        {
            this[0, 0] = new Biomass(Build.Building);
            this[0, 1] = new Nuclear(Build.Building);
            this[0, 2] = new Geothermal(Build.Building);
            this[0, 3] = new Hydroelectric(Build.Building);
            this[0, 4] = new Solar(Build.Building);
            this[0, 5] = new Turbin(Build.Building);
            this[0, 7] = new Business(Build.Building);
            this[0, 8] = new House(Build.Building);

        }

        public bool IsEmpty(Position pos)
        {
            return this[pos] == null;
        }
    }
}
