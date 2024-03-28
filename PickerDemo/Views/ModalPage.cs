using PickerDemo.DI;
using PickerDemo.ViewModels;

namespace PickerDemo.Views;

public class ModalPage : ContentPage
{
    private ModalViewModel ViewModelContext { get; set; }
    public ModalPage()
    {
        var viewModelFactory = App.ServiceProvider.GetRequiredService<ViewModelFactory>();
        BindingContext = viewModelFactory.Create<ModalViewModel>();
        if (BindingContext is ModalViewModel viewModelContext)
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
            Text = "This shows the Picker does not work on a modal page in the Mac Catalyst.\nTry to pick an element:",
            FontSize = 20,
            FontFamily = "OpenSansSemibold",
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.Firebrick,
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

        var closeButton = new Button()
        {
            Text = "Close this modal",
            BackgroundColor = Colors.Salmon,
            TextColor = Colors.DarkRed,
            HorizontalOptions = LayoutOptions.Center,
        };
        closeButton.SetBinding(Button.CommandProperty, new Binding("CloseModalCommand"));
        mainContainer.Children.Add(closeButton);
        
        Content = mainContainer;
    }
}