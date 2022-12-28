using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // ObservableCollection<Student> stuedents;
        
        public MainWindow()
        {
            //students = new ObservableCollection<Student>();

            InitializeComponent();
           // GenerateDummyStudent();
            //dgStudent.ItemsSource = students;
        }
        private void Add_Click(Object sender, RoutedEventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
