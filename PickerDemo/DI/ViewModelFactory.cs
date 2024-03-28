namespace PickerDemo.DI;

public class ViewModelFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ViewModelFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public T Create<T>() where T : class
    {
        return _serviceProvider.GetRequiredService<T>();
    }
}