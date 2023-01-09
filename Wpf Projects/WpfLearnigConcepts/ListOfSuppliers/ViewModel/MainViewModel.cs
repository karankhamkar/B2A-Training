using GalaSoft.MvvmLight.Command;
using ListOfSuppliers.Model;
using ListOfSuppliers.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfSuppliers.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Property
        public int ProductCounter = 1;
        private ObservableCollection<SupplierItem> _supplierItemList;
        public ObservableCollection<SupplierItem> SupplierItemList
        {
            get { return _supplierItemList; }
            set { _supplierItemList = value; }
        }
        #endregion
        #region Commnads
        private RelayCommand _addSupplierCommand;
        public RelayCommand AddSupplierCommand
        {
            get
            { 
                if(_addSupplierCommand == null)
                {
                    _addSupplierCommand = new RelayCommand(ShowSupplierItemList, true);
                }
                return _addSupplierCommand; 
            }

        }

        #endregion
        #region Constructors
        public MainViewModel()
        {
            SupplierItemList = new ObservableCollection<SupplierItem>();
        }
        #endregion
        #region Methods
        private void ShowSupplierItemList()
        {
            SupplierItemView supplierItemView = new SupplierItemView(this);
            supplierItemView.ShowDialog();
        }
        #endregion
    }
}
