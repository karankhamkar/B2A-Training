using GalaSoft.MvvmLight.Command;
using ListOfSuppliers.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace ListOfSuppliers.ViewModel
{
    public class SuppilerItemViewModel : BaseViewModel
    {
        #region Property
        private Window currentWindow;
        private MainViewModel mainViewModel;
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
        public ObservableCollection<string> _subCategoryList;
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
        private string _selectedSubCategory;
        public string SelectedSubCategory
        {
            get
            {
                return _selectedSubCategory; 
            }
            set
            {
                _selectedSubCategory = value;
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
                LoadSubCatagories();
            }
        }
        private string _supplierName;
        public string SupplierName
        {
            get
            {
                return _supplierName; 
            }
            set
            {
                _supplierName = value; 
                NotifyPropertyChanged(); 
            }
        }
        private int _supplierId;
        public int SupplierId
        {
            get
            {
                return _supplierId;
            }
            set 
            { 
                _supplierId = value; 
                NotifyPropertyChanged(); 
            }
        }
        
        #endregion
        #region Commnads

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                if( _saveCommand == null )
                {
                    _saveCommand = new RelayCommand(Save, true);
                }
                return _saveCommand;
            }
        }
        private RelayCommand _clearCommand;
        public RelayCommand ClearCommand
        {
            get
            {
                if (_clearCommand == null)
                {
                    _clearCommand = new RelayCommand(Clear, true);
                }
                return _clearCommand;
            }

        }
        private RelayCommand _cancelCommand;
        public RelayCommand CancelCommand
        {
            get
            {
                if(_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(Cancel, true);
                }
                return _cancelCommand;
            }
        }

        
        #endregion
        #region Constructors
        public SuppilerItemViewModel(Window window, MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            currentWindow = window;
            CategoryList = DataService.GetAllCategories();
            SubCategoryList = new ObservableCollection<string>();
        }
        #endregion
        #region Methods
        private void LoadSubCatagories()
        {
            
        }
        private void Cancel()
        {

        }

        private void Clear()
        {

        }

        private void Save()
        {

        }
        #endregion
    }
}
