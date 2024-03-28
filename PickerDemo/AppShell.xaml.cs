using PickerDemo.Views;

namespace PickerDemo;

public partial class AppShell : Shell
{
    public AppShell(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("ModalPage", typeof(ModalPage));
    }
}