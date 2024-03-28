namespace PickerDemo;

public partial class App : Application
{
    public static IServiceProvider ServiceProvider;
    public App(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
        
        InitializeComponent();
        
        MainPage = new AppShell(serviceProvider);
    }
}