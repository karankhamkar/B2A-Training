using GalaSoft.MvvmLight.Command;
using SupplierCascading.Model;
using SupplierCascading.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace SupplierCascading.ViewModel
{
    public class SupplierViewModel : BaseViewModel
    {
        #region Property
        private Window currentWindow;
        private MainViewModel mainViewModel;

       
        private List<string> _catagoryList;
        public List<string> CatagoryList
        {
            get { return _catagoryList; }
            set { _catagoryList = value; }
        }
        private ObservableCollection<string> _subCategoryList;
        public ObservableCollection<string> SubCategoryList
        {
            get { return _subCategoryList; }
            set { _subCategoryList = value; }
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
                LoadSubCategories();
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
        private int _stock;
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
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

        #region Commands
        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                if(_saveCommand == null)
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
                if(_clearCommand == null)
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
                return (_cancelCommand);
            }
        }

        
        #endregion
        #region Constructor
        public SupplierViewModel(Window window, MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            currentWindow = window;

            CatagoryList = DataService.GetAllCategories();
            SubCategoryList = new ObservableCollection<string>();
            
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

        private void Clear()
        {
            this.SupplierName = string.Empty;
            this.SelectedCategory = null;
            this.SelectedSubCategory = string.Empty;
            //this.Stock = null;
        }

        private void Save()
        {
            Supplier supplier = new Supplier();

            supplier.SupplierId = mainViewModel.ProductCounter++;
            supplier.SupplierName = this.SupplierName;
            supplier.Stock = this.Stock;
            supplier.SubCatgory = SelectedSubCategory;
            supplier.Catgory = SelectedSubCategory;

            mainViewModel.SupplierList.Add(supplier);
            currentWindow.Close();
        }
        #endregion
    }
}
