using SunstarProcessTestApp.Model;
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
    /// Interaction logic for BagDumpPowderAdditionView.xaml
    /// </summary>
    public partial class BagDumpPowderAdditionView : UserControl
    {
        public BagDumpPowderAdditionView()
        {
            InitializeComponent();

            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "Vizron 31-6", SpecWeight = 4550.0 });
            products.Add(new Product() { Name = "Polycal OF-325", SpecWeight = 250.0 });

            BagDumpItemsControl.ItemsSource = products;
        }
    }
}
