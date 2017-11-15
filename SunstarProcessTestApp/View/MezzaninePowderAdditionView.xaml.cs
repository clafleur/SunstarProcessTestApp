using System.Windows.Controls;
using SunstarProcessTestApp.Model;
using System.Collections.Generic;
using System.Windows.Data;

namespace SunstarProcessTestApp.View
{
    /// <summary>
    /// Interaction logic for MezzaninePowderAdditionView.xaml
    /// </summary>
    public partial class MezzaninePowderAdditionView : UserControl
    {
        public MezzaninePowderAdditionView()
        {
            InitializeComponent();

            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "CG-1200", SpecWeight = 126.0, MaxGross = 43.4, MinGross = 41.7, MinNet = 41.4, MaxNet = 43.1, ItemNet = 42.0, IsPartial=true});
            products.Add(new Product() { Name = "CG-1200", MaxGross = 43.4, MinGross = 41.7, MinNet = 41.4, MaxNet = 43.1, ItemNet = 42.0, IsPartial = true });
            products.Add(new Product() { Name = "CG-1200", MaxGross = 43.4, MinGross = 41.7, MinNet = 41.4, MaxNet = 43.1, ItemNet = 42.0, TotalMinNet = 124.2, TotalMaxNet = 129.3, TotalItemNet = 126, TotalNetVisibility = true, IsPartial = true });
            products.Add(new Product() { Name = "Aerosil 300", SpecWeight = 130.0, TotalNetVisibility = false, });
            products.Add(new Product() { Name = "Zoco", SpecWeight = 100.0, TotalNetVisibility = false, });
            products.Add(new Product() { Name = "Kronos 2300", SpecWeight = 44.9, MaxGross = 46.1, MinGross = 44.3, MinNet = 44.0, MaxNet = 44.9, ItemNet = 45.8, IsPartial= true});
            products.Add(new Product() { Name = "Kronos 2300", MaxGross = 46.1, MinGross = 44.3, MinNet = 44.0, MaxNet = 44.9, ItemNet = 45.8, TotalMinNet = 88.0, TotalMaxNet = 89.8, TotalItemNet = 91.6, TotalNetVisibility = true, IsPartial = true });

            MezzaninePowderItemsControl.ItemsSource = products;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(MezzaninePowderItemsControl.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Name");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
}
