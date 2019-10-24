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
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Portal;
using Esri.ArcGISRuntime.Security;
using Esri.ArcGISRuntime.Symbology;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext =Mymap;
            FeatureLayer schoolLayer = new FeatureLayer(new Uri("https://services3.arcgis.com/nvI0fYFeERFykmSz/arcgis/rest/services/Active_Schools/FeatureServer/0"));
            Mymap.OperationalLayers.Add(schoolLayer);
            mapView.Map = Mymap;
            
        }
        public Map Mymap { get; } = new Map(Basemap.CreateStreetsVector())
        {
            InitialViewpoint = new Viewpoint(51.05011, -114.08, 4000)
            
            
            
        };
    



            

          //  Map = map;
            
    }
}
