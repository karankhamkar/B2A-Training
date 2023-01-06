using System.Windows;
using System.Windows.Controls;
using WPFListBoxByMVVM.Model;
using WPFListBoxByMVVM.ViewModel;

namespace WPFListBoxByMVVM.View
{
    /// <summary>
    /// Interaction logic for ListBoxView.xaml
    /// </summary>
    public partial class ListBoxView : UserControl
    {
        public ListBoxView()
        {
            InitializeComponent();
            this.DataContext = new ListBoxViewModel();
        }
    }
}
