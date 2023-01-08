using System.Windows;
using ToDoItemCascading.ViewModel;

namespace ToDoItemCascading.View
{
    /// <summary>
    /// Interaction logic for ToDoItemVIew.xaml
    /// </summary>
    public partial class ToDoItemView : Window
    {
        public ToDoItemView( MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.DataContext = new ToDoItemViewModel(this, mainViewModel);
        }
    }
}
