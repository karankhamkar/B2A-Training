using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDoItemCascading.Model;
using ToDoItemCascading.Services;

namespace ToDoItemCascading.ViewModel
{
    public class ToDoItemViewModel : BaseViewModel
    {
        #region Property
        private MainViewModel mainViewModel;
        private Window currentWindow;

        private List<string> _categoryList;
        public List<string> CategoryList
        {
            get 
            { 
                return _categoryList; 
            }
            set
            {
                _categoryList = value;
            }
        }
        private ObservableCollection<string> _subCategoryList;
        public ObservableCollection<string> SubCategoryList
        {
            get
            {
                return _subCategoryList; 
            }
            set
            {
                _subCategoryList = value; 
            }
        }
        private string _selectedSubcategory;
        public string SelectedSubcategory
        {
            get
            {
                return _selectedSubcategory; 
            }
            set
            {
                _selectedSubcategory = value;
                NotifyPropertyChanged();
            }
        }
        private string _selectedCategory;
        public string SelectedCategory
        {
            get
            {
                return _selectedCategory;
            }
            set
            {
                _selectedCategory = value;
                NotifyPropertyChanged();
                LoadSubCategories();
            }
        }

       

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged(); }
        }

        private bool _isDone;
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; NotifyPropertyChanged(); }
        }

        #endregion
        #region Commands
        private RelayCommand _clearCommand;
        public RelayCommand ClearCommand
        {
            get 
            {
                if(_clearCommand == null)
                {
                    _clearCommand = new RelayCommand(Clear, true);
                }
                return _clearCommand; 
            }

        }
        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(Save, true);
                }
                return _saveCommand;
            }

        }
        private RelayCommand _cancelCommand;
        public RelayCommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(Cancel, true);
                }
                return _cancelCommand;
            }
        }

        
        #endregion
        #region Constructors
        public ToDoItemViewModel(Window window, MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            currentWindow = window;
            CategoryList = DataService.GetAllCategories();
            SubCategoryList = new ObservableCollection<string>();


            //1.
            //List<string> categories = DataService.GetAllCategories();
            //CategoryList = new ObservableCollection<string>();

            //foreach (var item in categories)
            //{
            //    CategoryList.Add(item);
            //}

            //2.
            //List<string> categories = DataService.GetAllCategories();
            //CategoryList = new ObservableCollection<string>(categories);

            //3.
            //CategoryList = new ObservableCollection<string>(DataService.GetAllCategories());
        }
        #endregion
        #region Methods
        private void LoadSubCategories()
        {
            SubCategoryList.Clear();
            List<string> subCategories = DataService.GetAllSubCategories(SelectedCategory);

            foreach(var item in subCategories)
            {
                SubCategoryList.Add(item);
            }
        }
        private void Cancel()
        {
            currentWindow.Close();
        }

        private void Save()
        {
            ToDoItem toDoItem = new ToDoItem();
            toDoItem.Name = this.Name;
            toDoItem.Category = SelectedCategory;
            toDoItem.SubCategory = SelectedSubcategory;
            toDoItem.IsDone = IsDone;

            mainViewModel.ToDoItemList.Add(toDoItem);
            currentWindow.Close();
        }

        private void Clear()
        {
            this.Name = String.Empty;
            this.SelectedCategory = null;
            this.SelectedSubcategory = String.Empty;
            this.IsDone = false;
        }
        #endregion
    }
}
