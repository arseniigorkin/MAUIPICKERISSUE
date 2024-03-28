using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PickerDemo.Views;

namespace PickerDemo.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public ICommand OpenModalCommand { get; set; }

    public MainViewModel()
    {
        OpenModalCommand = new Command(async () => await OpenModal());
    }
    
    private async Task OpenModal()
    {
        await Shell.Current.Navigation.PushModalAsync(new ModalPage());
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}