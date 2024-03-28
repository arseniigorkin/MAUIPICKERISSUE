using PickerDemo.DI;
using PickerDemo.ViewModels;

namespace PickerDemo.Views;

public class MainPage : ContentPage
{
    private MainViewModel ViewModelContext { get; set; }
    public MainPage()
    {
        var viewModelFactory = App.ServiceProvider.GetRequiredService<ViewModelFactory>();
        BindingContext = viewModelFactory.Create<MainViewModel>();
        if (BindingContext is MainViewModel viewModelContext)
        {
            ViewModelContext = viewModelContext;
        }
        BuildUi();
    }

    public void BuildUi()
    {
        var mainContainer = new VerticalStackLayout();
        var testLoabel = new Label()
        {
            Text = "This shows the Picker works well on the page.\nTry to pick an element:",
            FontSize = 20,
            FontFamily = "OpenSansSemibold",
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.Green,
            FontAttributes = FontAttributes.Bold,
        };
        mainContainer.Children.Add(testLoabel);
        
        var testPicker = new Picker()
        {
            Items =
            {
                "Element 1",
                "Element 2",
                "Element 3",
                "Element 4",
                "Element 5",
            },
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center
        };
        mainContainer.Children.Add(testPicker);

        var openButton = new Button()
        {
            Text = "Open the modal",
            BackgroundColor = Colors.Gold,
            TextColor = Colors.Brown,
            HorizontalOptions = LayoutOptions.Center,
        };
        openButton.SetBinding(Button.CommandProperty, new Binding("OpenModalCommand"));
        mainContainer.Children.Add(openButton);
        
        Content = mainContainer;
    }
}