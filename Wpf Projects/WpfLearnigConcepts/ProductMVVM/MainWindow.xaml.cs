using System.Windows;

namespace ProductMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ProductViewModel productViewModel = new ProductViewModel();
            this.DataContext = productViewModel;
        }
    }
}
