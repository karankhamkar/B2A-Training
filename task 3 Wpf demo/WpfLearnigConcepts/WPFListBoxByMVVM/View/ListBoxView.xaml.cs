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
    //    private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    //    {
    //        if (lbTodoList.SelectedItem != null)
    //            this.Title = (lbTodoList.SelectedItem as TodoList).Title;
    //    }
    //    private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
    //    {
    //        foreach (object o in lbTodoList.SelectedItems)
    //            MessageBox.Show((o as TodoList).Title);
    //    }
    //    private void btnSelectLast_Click(object sender, RoutedEventArgs e)
    //    {
    //        lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
    //    }
    //    private void btnSelectNext_Click(object sender, RoutedEventArgs e)
    //    {
    //        int nextIndex = 0;
    //        if ((lbTodoList.SelectedIndex >= 0) && (lbTodoList.SelectedIndex < (lbTodoList.Items.Count - 1)))
    //            nextIndex = lbTodoList.SelectedIndex + 1;
    //        lbTodoList.SelectedIndex = nextIndex;
    //    }
    //    private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
    //    {
    //        foreach (object o in lbTodoList.Items)
    //        {
    //            if ((o is TodoItem) && ((o as TodoList).Title.Contains("C#")))
    //            {
    //                lbTodoList.SelectedItem = o;
    //                break;
    //            }
    //        }
    //    }
    //    private void btnSelectAll_Click(object sender, RoutedEventArgs e)
    //    {
    //        foreach (object o in lbTodoList.Items)
    //            lbTodoList.SelectedItems.Add(o);
    //    }
    }
    //public class TodoList
    //{
    //    public string Title { get; set; }
    //    public int Completion { get; set; }
    //}

}
