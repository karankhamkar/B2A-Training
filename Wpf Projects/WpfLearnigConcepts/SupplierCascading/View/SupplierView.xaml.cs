using SupplierCascading.ViewModel;
using System.Windows;

namespace SupplierCascading.View
{
    /// <summary>
    /// Interaction logic for SupplierView.xaml
    /// </summary>
    public partial class SupplierView : Window
    {
        public SupplierView(MainViewModel mainViewModel)
        {
            InitializeComponent();
           this.DataContext = new SupplierViewModel(this, mainViewModel);
        }
    }
}
