using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SupplierMVVM
{
    public class SupplierViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        private int _productCounter = 1;
        private ObservableCollection<SupplierList> _supplierList;
        public ObservableCollection<SupplierList> SupplierList
        {
            get
            {
                return _supplierList;
            }
            set
            {
                _supplierList = value;
                NotifyPropertyChanged();
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
        private int _transactionId;
        public int TransactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                _transactionId = value;
                NotifyPropertyChanged();
            }
        }
        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                NotifyPropertyChanged();
            }
        }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                NotifyPropertyChanged();
            }
        }
        private double _amount;
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                NotifyPropertyChanged();
            }
        }
        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                NotifyPropertyChanged();
            }
        }
        #region Commands
        
        private RelayCommand _addSupplierCommand;
        public RelayCommand AddSupplierCommand
        {
            get
            {
                if(_addSupplierCommand == null)
                {
                    _addSupplierCommand = new RelayCommand(AddNewSupplier, true);
                }
                return _addSupplierCommand;
            }
        }
        #endregion
        private void AddNewSupplier()
        {
            AddSupplier(SupplierName, TransactionId, Address, ProductName, Amount, City);
        }
        
        public SupplierViewModel()
        {
            SupplierList = new ObservableCollection<SupplierList>();
            SupplierList supplierLists = new SupplierList();
        }

        private void AddSupplier(string supplierName, int transactionId, string address, string productName, double amount,string city)
        {
            SupplierList supplierList = new SupplierList();

            supplierList.SupplierName = supplierName;
            supplierList.TransactionId = transactionId; 
            supplierList.Address = address;
            supplierList.ProductName = productName;
            supplierList.Amount = amount;
            supplierList.City = city;
            supplierList.SupplierId = _productCounter++;

            SupplierList.Add(supplierList);
        }
    }
}
