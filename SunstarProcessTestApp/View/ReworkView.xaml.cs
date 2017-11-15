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

namespace SunstarProcessTestApp.View
{
    /// <summary>
    /// Interaction logic for ReworkView.xaml
    /// </summary>
    public partial class ReworkView : UserControl
    {
        public ReworkView()
        {
            InitializeComponent();

            List<ReworkProduct> products = new List<ReworkProduct>();
            products.Add(new ReworkProduct() { MinNet = 38.0, MaxNet = 42.0, ItemNet = 40.0});

            ReworkItemsControl.ItemsSource = products;
        }
    }

    public class ReworkProduct
    {
        public double MaxNet { get; set; }
        public double MinNet { get; set; }
        public double ItemNet { get; set; }
    }
}
