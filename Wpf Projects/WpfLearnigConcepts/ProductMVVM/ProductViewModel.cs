using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProductMVVM
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = " ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region property
        private ObservableCollection<Product> _productList;
        public ObservableCollection<Product> ProductList
        {
            get 
            {
                return _productList;
            }
            set
            {
                _productList = value;
                NotifyPropertyChanged();
            }
        }
        private int _productCounter = 1;
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
                NotifyPropertyChanged();
            }
        }
        #endregion
        #region Commands
        private RelayCommand _addProductCommand;
        public RelayCommand AddProductCommand
        {
            get
            {
                if( _addProductCommand == null )
                {
                    _addProductCommand = new RelayCommand(AddNewProduct, true);
                }
                return _addProductCommand;
            }
        }

        private void AddNewProduct()
        {
            AddProduct(ProductName, Description, City, Stock);
        }

        private void AddProduct(string productName, string description, string city, int stock)
        {
            Product product = new Product();
            
            product.ProductName = productName;
            product.Description = description;  
            product.City = city;
            product.Stock = stock;
            product.Id = _productCounter++;

            ProductList.Add(product);
        }
        #endregion
        #region Constructor
        public ProductViewModel()
        {
            ProductList = new ObservableCollection<Product>();
        }
        #endregion
        #region Methods

        #endregion
        #region Clean up
        #endregion
    }
}
