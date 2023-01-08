using CascadingProducts;
using System.Windows;

namespace Products
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProductsView : Window
    {
        public ProductsView()
        {
            InitializeComponent();
            this.DataContext = new ProductsViewModel();
        }
    }
}
