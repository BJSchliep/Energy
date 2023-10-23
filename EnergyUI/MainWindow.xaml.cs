using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EnergyLogic;

namespace EnergyUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Image[,] structureImages = new Image[10, 10];

        private readonly GridState gridState;

        public MainWindow()
        {
            InitializeComponent();
            InitalizeLand();

            gridState = new GridState(Build.Building, Land.Initial());

            DevelopLand(gridState.Land);

        }

        private void InitalizeLand()
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Image image = new Image();
                    structureImages[r, c] = image;
                    LandGrid.Children.Add(image);
                }
            }
        }

        private void DevelopLand(Land land)
        {
            for (int r = 0;r < 10; r++)
            {
                for (int c = 0;c < 10; c++)
                {
                    Structure structure = land[r, c];
                    structureImages[r, c].Source = Images.GetImage(structure);
                }
            }
        }
    }
}
