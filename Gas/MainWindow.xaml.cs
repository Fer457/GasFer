using Microsoft.Maps.MapControl.WPF;
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

namespace Gas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            double lat = 38.26253406021107;
            double lon = -0.686591909247856;

            InitializeComponent();

            mapa.ZoomLevel = 16;
            mapa.Mode = new AerialMode(true);

            Location pos = new(lat, lon);
            mapa.Center = pos;
        }
    }
}
