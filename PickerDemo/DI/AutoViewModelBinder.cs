namespace PickerDemo.DI;

public class AutoViewModelBinder
{
    public static void BindViewModelToPage(ContentPage page)
    {
        var pageType = page.GetType();
        var viewModelTypeName = pageType.FullName?.Replace("Page", "ViewModel");
        var viewModelType = Type.GetType(viewModelTypeName);

        if (viewModelType == null)
        {
            throw new InvalidOperationException($"Could not find ViewModel of type '{viewModelTypeName}' for a page '{pageType.FullName}'.");
        }
        var viewModel = App.ServiceProvider.GetRequiredService(viewModelType);
        page.BindingContext = viewModel;
    }
}