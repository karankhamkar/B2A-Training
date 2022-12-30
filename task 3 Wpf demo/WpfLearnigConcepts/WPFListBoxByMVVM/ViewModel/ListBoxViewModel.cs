using System.Collections.Generic;
using WPFListBoxByMVVM.Model;

namespace WPFListBoxByMVVM.ViewModel
{
    public class ListBoxViewModel : BaseViewModel
    {
        public List<TodoList> allItems { get; set; }
        public ListBoxViewModel()
        {
            
            List<TodoList> items = new List<TodoList>();
            items.Add(new TodoList() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoList() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoList() { Title = "Wash the car", Completion = 0 });
            allItems = items;
        }
       
    }
}
