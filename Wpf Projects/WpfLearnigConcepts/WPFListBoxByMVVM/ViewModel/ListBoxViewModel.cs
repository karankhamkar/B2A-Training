using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WPFListBoxByMVVM.Model;

namespace WPFListBoxByMVVM.ViewModel
{
    public class ListBoxViewModel : BaseViewModel
    {
        private Random _rand;
        private Random _randName;

        private RelayCommand _showSelected;
        public RelayCommand ShowSelectedCommand
        {
            get 
            {
                if(_showSelected == null)
                {
                    _showSelected = new RelayCommand(() => ShowSelected(),true);
                }
                return _showSelected;
            }
        }

        private void ShowSelected()
        {
            if (_selectedTodoList != null)
            {
                MessageBox.Show(_selectedTodoList.Title);
            }
        }

        private TodoList _selectedTodoList;
        public TodoList SelectedTodoList
        {
            get
            {
                return _selectedTodoList;
            }
            set
            {
                _selectedTodoList = value;
                OnPropertyChanged(nameof(SelectedTodoList));
            }
        }

        private RelayCommand _selectLastCommand;
        public RelayCommand SelectLastCommand
        {
            get
            {
                if (_selectLastCommand == null)
                {
                    _selectLastCommand = new RelayCommand(() => SelectLast(), true);
                }
                return _selectLastCommand;
            }
        }
        
        private RelayCommand _selectNextCommand;
        public RelayCommand SelectNextCommand
        {
            get
            {
                if (_selectNextCommand == null)
                {
                    _selectNextCommand = new RelayCommand(() => SelectNext(), true);
                }
                return _selectNextCommand;
            }
        }
       
        private RelayCommand _selectSpecificCommand;
        public RelayCommand SelectSpecificCommand
        {
            get
            {
                if (_selectSpecificCommand == null)
                {
                    _selectSpecificCommand = new RelayCommand(() => SelectSpecific(), true);
                }
                return _selectSpecificCommand;
            }
        }
        private RelayCommand _addItemCommand;
        public RelayCommand AddItemCommand
        {
            get
            {
                if (_addItemCommand == null)
                {
                    _addItemCommand = new RelayCommand(() => AddItem(), true);
                }
                return _addItemCommand;
            }
        }
        public string[] lang = { "C#", "Java", "WPF", "C", "C++", "Python" };

        private void SelectLast()
        {
            SelectedTodoList = allItems[allItems.Count - 1];
        }
        private void SelectSpecific()
        {
            //int foundIndex = allItems.FindIndex(x => x.Title == "Learn C#");
            // SelectedTodoList = allItems[foundIndex];
            SelectedTodoList = allItems.Where(x => x.Title == "Learn C#").FirstOrDefault();
        }
        private void SelectNext()
        {
            
            int currentIndex = allItems.IndexOf( SelectedTodoList);
            if (currentIndex > -1)
            {
                SelectedTodoList = allItems[(currentIndex + 1) % allItems.Count];
            }
            else
            {
                SelectedTodoList = allItems[0];
            }

        }

        private void AddItem()
        {
            //TodoList myTodoList = new TodoList();
            //myTodoList.Title = Name;
            //myTodoList.Completion = _rand.Next(1, 100);
            //allItems.Add(myTodoList);

            allItems.Add(new TodoList() { Title = lang[_randName.Next(0,5)], Completion = _rand.Next(0, 100) });
        
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set 
            {
                _name = value; 
                OnPropertyChanged(nameof(Name)); 
            }
        }

        public ObservableCollection<TodoList> allItems { get; set; }
        public ListBoxViewModel()
        {
            allItems = new ObservableCollection<TodoList>();
            allItems.Add(new TodoList() { Title = "Complete this WPF tutorial", Completion = 45 });
            allItems.Add(new TodoList() { Title = "Learn C#", Completion = 80 });
            allItems.Add(new TodoList() { Title = "Wash the car", Completion = 0 });
            allItems.Add(new TodoList() { Title = "Review WPF", Completion = 20 });
            _rand = new Random();
            _randName = new Random();
        }
       
    }
}
