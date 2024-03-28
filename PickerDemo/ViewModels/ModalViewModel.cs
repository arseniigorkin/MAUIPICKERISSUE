using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PickerDemo.ViewModels;

public class ModalViewModel : INotifyPropertyChanged
{
    public ICommand CloseModalCommand { get; set; }

    public ModalViewModel()
    {
        CloseModalCommand = new Command(async () => await CloseModal());
    }
    
    private async Task CloseModal()
    {
        Shell.Current.Navigation.PopModalAsync(true);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}