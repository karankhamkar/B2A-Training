﻿using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadingProducts
{
    public class ProductViewModel : BaseViewModel
    {
        #region Property
        public ProductView ProductWindow;
        private List<State> _allStates;
        private List<City> _allCities;
        private ProductsViewModel _parent { get; }
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

        private string _selectedCountry;
        public string SelectedCountry
        {
            get
            {
                return _selectedCountry;
            }
            set
            {
                _selectedCountry = value;
                LoadStates();
                NotifyPropertyChanged();
            }
        }
        private string _selectedState;
        public string SelectedState
        {
            get
            {
                return _selectedState;
            }
            set
            {
                _selectedState = value;
                LoadCites();
                NotifyPropertyChanged();
            }
        }
        private string _selectedCity;
        public string SelectedCity
        {
            get
            {
                return _selectedCity;
            }
            set
            {
                _selectedCity = value;
                LoadCites();
                NotifyPropertyChanged();
            }
        }
        private List<string> _countries;
        public List<string> Countries
        {
            get
            {
                return _countries;
            }
        }
        private ObservableCollection<string> _states;
        public ObservableCollection<string> States
        {
            get
            {
                return _states;
            }
            set
            {
                _states = value;
            }
        }
        private ObservableCollection<string> _cities;
        public ObservableCollection<string> Cities
        {
            get
            {
                return _cities;
            }
            set
            {
                _cities = value;
            }
        }
        #endregion

        #region Commands
        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                if( _saveCommand == null )
                {
                    _saveCommand = new RelayCommand(AddProduct, true);
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
                    _cancelCommand = new RelayCommand(CloseMe, true);
                }
                return _cancelCommand;
            }
        }

        #endregion
        #region Constructor
        public ProductViewModel(ProductsViewModel productsViewModel, ProductView productView)
        {
            this._parent = productsViewModel;
            this.ProductWindow = productView;

            States = new ObservableCollection<string>();
            Cities = new ObservableCollection<string>();
            _countries = GetCountries();
            _allStates = GetAllStates();
            _allCities = GetAllCities();
        }
        #endregion
        #region Methods
        private List<string> GetCountries()
        {
            return new List<string>() { "India","United States","Germany","France","Afghanistan",
                        
                        "Bosnia Herzegovina",
                        "Botswana",
                        "Brazil",
                        "Brunei",
                        "Bulgaria",
                        "Burkina",
                        "Burundi",
                        "Cambodia",
                        "Cameroon",
                        "Canada",
                        "Cape Verde",
                        "Central African Rep",
                        "Chad",
                        "Chile",
                        "China",
                        "Colombia",
                        "Comoros",
                        "Congo",
                        "Congo {Democratic Rep}",
                        "Costa Rica",
                        "Croatia",
                        "Cuba",
                        "Guatemala",
                        "Guinea",
                        "Guinea-Bissau",
                        "Guyana"};
        }
        private List<City> GetAllCities()
        {
            return new List<City>()
            {
                new City(){State="Karnataka",Name="Bengalore"},
                new City(){State="Karnataka",Name="Hubali"},
                new City(){State="Karnataka",Name="Dharawd"},
                new City(){State="Karnataka",Name="Maysore"},
                new City(){State="Maharashtra",Name="Mumbai"},
                new City(){State="Maharashtra",Name="Jaysingpur"},
                new City(){State="Maharashtra",Name="Kolhapur"},
                new City(){State="Maharashtra",Name="Sangali"},
                new City(){State="Maharashtra",Name="Pune"},
                new City(){State="California",Name="LA"},
                new City(){State="California",Name="San Francisco"},
                new City(){State="California",Name="San Diago"},
                new City(){State="Texas",Name="Austin"},
                new City(){State="Texas",Name="Dallas"}
            };
        }
        private List<State> GetAllStates()
        {
            return new List<State>()
            {
                new State(){Country="India",Name="Andhra Pradesh"},
                new State(){Country="India",Name="Arunachal Pradesh"},
                new State(){Country="India",Name="Assam"},
                new State(){Country="India",Name="Bihar"},
                new State(){Country="India",Name="Chhattisgarh"},
                new State(){Country="India",Name="Goa"},
                new State(){Country="India",Name="Gujarat"},
                new State(){Country="India",Name="Haryana"},
                new State(){Country="India",Name="Himachal Pradesh"},
                new State(){Country="India",Name="Jammu and Kashmir"},
                new State(){Country="India",Name="Jharkhand"},
                new State(){Country="India",Name="Karnataka"},
                new State(){Country="India",Name="Karnataka"},
                new State(){Country="India",Name="Karnataka"},
                new State(){Country="India",Name="Karnataka"},
                new State(){Country="India",Name="Kerala"},
                new State(){Country="India",Name="Madhya Pradesh"},
                new State(){Country="India",Name="Maharashtra"},
                new State(){Country="India",Name="Maharashtra"},
                new State(){Country="India",Name="Maharashtra"},
                new State(){Country="India",Name="Maharashtra"},
                new State(){Country="India",Name="Maharashtra"},
                new State(){Country="India",Name="Manipur"},
                new State(){Country="India",Name="Meghalaya"},
                new State(){Country="India",Name="Mizoram"},
                new State(){Country="India",Name="Nagaland"},
                new State(){Country="India",Name="Odisha"},
                new State(){Country="India",Name="Punjab"},
                new State(){Country="India",Name="Rajasthan"},
                new State(){Country="India",Name="Sikkim"},
                new State(){Country="India",Name="Tamil Nadu"},
                new State(){Country="India",Name="Telangana"},
                new State(){Country="India",Name="Tripura"},
                new State(){Country="India",Name="Uttar Pradesh"},
                new State(){Country="India",Name="Uttarakhand"},
                new State(){Country="India",Name="West Bengal"},
                new State(){Country="United States",Name="California"},
                new State(){Country="United States",Name="California"},
                new State(){Country="United States",Name="California"},
                new State(){Country="United States",Name="Texas"},
                new State(){Country="United States",Name="Texas"}

            };
        }

        private void LoadCites()
        {
            Cities.Clear();
            for(int i = 0; i < _allCities.Count; i++)
            {
                City currentItem = _allCities[i];
                
                if(currentItem.State == SelectedState)
                {
                    if(Cities.Contains(currentItem.Name) == false)
                    {
                        Cities.Add(currentItem.Name);
                    }
                }
            }
        }

        private void LoadStates()
        {
            States.Clear();
            var filteredState = (from s in _allStates
                                 where s.Country == SelectedCountry
                                 select s.Name).ToList();

            for(int i = 0; i < _allStates.Count;i++)
            {
                State currentState = _allStates[i];
                if(currentState.Country == SelectedCountry)
                {
                    if(States.Contains(currentState.Name) == false)
                    {
                        States.Add(currentState.Name);
                    }
                }
            }
        }
        private void AddProduct()
        {
            Product product = new Product();
            product.Name = this.Name;
            product.City = this.SelectedCity;
            product.Stock = this.Stock;
            _parent.Products.Add(product);
        }
        private void CloseMe()
        {
            ProductWindow.Close();
        }

        #endregion
        #region CLean up 
        #endregion
    }
}
