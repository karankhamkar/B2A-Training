using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadingProducts
{
    public class ProductsViewModel : BaseViewModel 
    {
        #region Property
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get 
            {
                return _products; 
            }
            set
            {
                _products = value;
                NotifyPropertyChanged();
            }
        }
        #endregion
        #region Commands
        private RelayCommand _showAddProductCommand;
        public RelayCommand ShowAddProductCommand
        {
            get
            {
                if(_showAddProductCommand == null)
                {
                    _showAddProductCommand = new RelayCommand(AddNewProduct, true);
                }
                return _showAddProductCommand; 
            }

        }


        #endregion
        #region Constructor
        public ProductsViewModel()
        {
            _products=new ObservableCollection<Product>();
        }
        #endregion
        #region Methods
        private void AddNewProduct()
        {
            ProductView product = new ProductView(this);
            product.ShowDialog();
        }
        #endregion
    }
}
