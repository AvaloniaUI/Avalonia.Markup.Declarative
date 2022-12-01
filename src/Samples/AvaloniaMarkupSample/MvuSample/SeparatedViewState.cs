using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaMarkupSample.MvuSample;

public class SeparatedViewState : INotifyPropertyChanged
{
    private string _stateProperty = "Separate state property";

    public string StateProperty
    {
        get => _stateProperty;
        set => SetField(ref _stateProperty, value);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}