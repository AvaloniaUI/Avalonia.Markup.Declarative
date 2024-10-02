using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaMarkupSample.MvvmSample;

public record struct MyObject(
    string MyProperty);

public class MvvmSampleViewModel : INotifyPropertyChanged
{
    private MyObject _myObject = new("Click the button below.");

    public MyObject MyObject
    {
        get => _myObject;
        set
        {
            if (_myObject != value)
            {
                _myObject = value;
                OnPropertyChanged();
            }
        }
    }

    public void MyCommand(object? commandParameter)
    {
        MyObject = new($"You called command with parameter: {commandParameter}");
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}