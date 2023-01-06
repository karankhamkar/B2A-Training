using System.ComponentModel;

namespace WPFListBoxByMVVM.ViewModel
{
    public interface INoitfyPropertyChanged
    {
        event PropertyChangedEventHandler? PropertyChanged;
    }
}