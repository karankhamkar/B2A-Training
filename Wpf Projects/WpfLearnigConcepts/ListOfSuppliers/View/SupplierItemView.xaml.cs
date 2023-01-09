using ListOfSuppliers.ViewModel;
using System.Windows;

namespace ListOfSuppliers.View
{
    /// <summary>
    /// Interaction logic for SupplierItemView.xaml
    /// </summary>
    public partial class SupplierItemView : Window
    {
        public SupplierItemView(MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.DataContext = new SuppilerItemViewModel(this, mainViewModel);
        }
    }
}
