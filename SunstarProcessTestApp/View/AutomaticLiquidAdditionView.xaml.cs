using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;

namespace SunstarProcessTestApp.View
{
    /// <summary>
    /// Interaction logic for AutomaticLiquidAdditionView.xaml
    /// </summary>
    public partial class AutomaticLiquidAdditionView : UserControl
    {
        public AutomaticLiquidAdditionView()
        {
            InitializeComponent();

            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "DNIP", SpecWeight = 40.0, LiquidDensity = 48.0, MinPLC = 42.0, MaxPLC = 38.0, PLCReading = 42.0});

            AutomaticLiquidItemsControl.ItemsSource = products;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(AutomaticLiquidItemsControl.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Name");
            view.GroupDescriptions.Add(groupDescription);
        }

        public class Product
        {
            public string Name { get; set; }
            public double LiquidDensity { get; set; }
            public double MinPLC { get; set; }
            public double MaxPLC { get; set; }
            public double PLCReading { get; set; }
            public double SpecWeight { get; set; }
        }
    }
}
