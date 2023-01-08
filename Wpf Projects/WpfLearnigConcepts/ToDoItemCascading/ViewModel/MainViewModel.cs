using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoItemCascading.Model;
using ToDoItemCascading.View;

namespace ToDoItemCascading.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Property
        private ObservableCollection<ToDoItem> _toDoItemList;
        public ObservableCollection<ToDoItem> ToDoItemList
        {
            get 
            {
                return _toDoItemList; 
            }
            set
            {
                _toDoItemList = value;
                NotifyPropertyChanged();
            }
        }

        #endregion
        #region Commands
        private RelayCommand _addToDoItemCommand;
        public RelayCommand AddToDoItemCommand
        {
            get
            {
                if( _addToDoItemCommand == null )
                {
                    _addToDoItemCommand = new RelayCommand(ShowToDoItemDialog, true);
                }
                return _addToDoItemCommand;
            }
        }


        #endregion
        #region Constructors
        public MainViewModel()
        {
            ToDoItemList = new ObservableCollection<ToDoItem>();
        }
        #endregion
        #region Methods
        private void ShowToDoItemDialog()
        {
            ToDoItemView toDoItemView = new ToDoItemView(this);
            toDoItemView.ShowDialog();
        }
        #endregion
    }
}




