using GalaSoft.MvvmLight.Command;
using SupplierCascading.Model;
using SupplierCascading.View;
using System;
using System.Collections.ObjectModel;

namespace SupplierCascading.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Property
        public int ProductCounter = 1;
        private ObservableCollection<Supplier> _supplierList;
        public ObservableCollection<Supplier> SupplierList
        {
            get
            {
                return _supplierList; 
            }
            set
            {
                _supplierList = value;
            }
        }

        #endregion
        #region Commands
        RelayCommand _addSupplierCommand;
        public RelayCommand AddSupplierCommand
        {
            get
            {
                if( _addSupplierCommand == null )
                {
                    _addSupplierCommand = new RelayCommand(ShowSupplierDialog, true);
                }
                return _addSupplierCommand;
            } 
             
            
        }

        #endregion
        #region Constructor
        public MainViewModel()
        {
            SupplierList = new ObservableCollection<Supplier>();
        }
        #endregion
        #region Methods
        private void ShowSupplierDialog()
        {
            SupplierView supplierView = new SupplierView(this);
            supplierView.ShowDialog();
        }
        #endregion
    }

}

