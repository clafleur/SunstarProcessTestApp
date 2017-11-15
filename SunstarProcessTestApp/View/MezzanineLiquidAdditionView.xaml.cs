using SunstarProcessTestApp.Model;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;

namespace SunstarProcessTestApp.View
{
    /// <summary>
    /// Interaction logic for MezzanineLiquidAdditionView.xaml
    /// </summary>
    public partial class MezzanineLiquidAdditionView : UserControl
    {
        public MezzanineLiquidAdditionView()
        {
            InitializeComponent();

            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "PM-DBT", SpecWeight = 40.0, MaxGross = 48.0, MinGross = 42.0, MinNet = 38.0, MaxNet = 42.0, ItemNet=40.0, TotalNetVisibility = false });
            products.Add(new Product() { Name = "S278", SpecWeight = 370.0, MaxGross = 229.0, MinGross = 211.0, MinNet = 181.3, MaxNet = 188.7, ItemNet = 185.0});
            products.Add(new Product() { Name = "S278", MaxGross = 229.0, MinGross = 211.0, MinNet = 181.3, MaxNet = 188.7, ItemNet = 185.0, TotalNetVisibility = true });

            MezzanineLiquidItemsControl.ItemsSource = products;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(MezzanineLiquidItemsControl.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Name");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
}
