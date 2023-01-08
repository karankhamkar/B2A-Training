using System.Windows;

namespace CascadingProducts
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        public ProductView(ProductsViewModel productsViewModel)
        {
            InitializeComponent();
            ProductViewModel productViewModel = new ProductViewModel(productsViewModel, this);
            this.DataContext = productViewModel;
        }
    }
}
