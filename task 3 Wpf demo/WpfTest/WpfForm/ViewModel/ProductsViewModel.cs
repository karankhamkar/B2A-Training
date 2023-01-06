using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfForm.Model;

namespace WpfForm.ViewModel
{
    public class ProductsViewModel : INavigatorPropetyChanged

    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Products> _products;
        public ObservableCollection<Products> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        
        public ObservableCollection<Products> allItems { get; set; }
        public ProductsViewModel()
        {
            allItems = new ObservableCollection<Products>();
            allItems.Add(new Products());

        }
    }
}
