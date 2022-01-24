using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using JetBrains.Annotations;

namespace AvaloniaMarkupSample.MvvmSample;

public class MvvmSampleViewModel : INotifyPropertyChanged
{
    private string _myProperty;

    public string MyProperty
    {
        get => _myProperty;
        set
        {
            if (_myProperty != value)
            {
                _myProperty = value;
                OnPropertyChanged();
            }
        }
    }

    public void MyCommand(object? commandParameter)
    {
        MyProperty = $"You called command with parameter: {commandParameter}";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}