using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using EnergyLogic;

namespace EnergyUI
{
    public static class Images
    {
        private static readonly Dictionary<StructureType, ImageSource> building = new()
        {
            {StructureType.Biomass, LoadImage("Biomass.png") },
            {StructureType.Business, LoadImage("Business.png") },
            {StructureType.Geothermal, LoadImage("Geothermal.png") },
            {StructureType.House, LoadImage("House.png") },
            {StructureType.Hydroelectric, LoadImage("Hydroelectric.png") },
            {StructureType.Nuclear, LoadImage("Nuclear.png") },
            {StructureType.Solar, LoadImage("Solar.png") },
            {StructureType.Turbin, LoadImage("Turbin.png") }
        };

        public static ImageSource LoadImage(string path)
        {
            return new BitmapImage(new Uri($"Assets/{path}", UriKind.Relative));
        }

        public static ImageSource GetImage(Build build, StructureType type)
        {
            return build switch
            {
                Build.Building => building[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Structure structure)
        {
            if (structure == null)
            {
                return null;
            }
            return GetImage(structure.Building, structure.Type);
        }
    }
}
