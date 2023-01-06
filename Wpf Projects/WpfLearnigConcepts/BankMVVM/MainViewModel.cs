using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BankMVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Property

        private int _productCounter = 1;
        private ObservableCollection<AccountDetail> _accountDetails;
        public ObservableCollection<AccountDetail> AccountDetails
        {
            get
            {
                return _accountDetails;
            }
            set
            {
                _accountDetails = value;
                NotifyPropertyChanged(nameof(AccountDetails));
            }
        }
        private string _employeeName;
        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }
            set 
            {
                _employeeName = value;
                NotifyPropertyChanged(nameof(EmployeeName)); 
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
                NotifyPropertyChanged(nameof(City));
            }
        }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                NotifyPropertyChanged(nameof(Description));
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
                NotifyPropertyChanged(nameof(Amount));
            }
        }
        #endregion
        #region Commands
        private RelayCommand _addEmployeeCommand;
        public RelayCommand AddEmployeeCommand
        {
            get
            {
               if(_addEmployeeCommand == null)
                {
                    _addEmployeeCommand = new RelayCommand(AddNewEmployee, true);
                }
               return _addEmployeeCommand;
            }
            
        }
        private void AddNewEmployee()
        {
            AddEmp(EmployeeName, Description, Amount, City);
        }

        #endregion
        #region Constructor
        public MainViewModel()
        {
            AccountDetails = new ObservableCollection<AccountDetail>();
            AccountDetail accountDetail = new AccountDetail();
           
        }

        #endregion
        #region Methods
       
        private void AddEmp(string employeeName, string description, double amount, string city)
        {
            AccountDetail accountDetail = new AccountDetail();
            accountDetail.AccountId = _productCounter;
            accountDetail.EmployeeName = employeeName;
            accountDetail.City = city;
            accountDetail.Description = description;
            accountDetail.Amount = amount;

            AccountDetails.Add(accountDetail);
            _productCounter++;
        }
        #endregion
        #region Clean Up
        #endregion

    }
}
