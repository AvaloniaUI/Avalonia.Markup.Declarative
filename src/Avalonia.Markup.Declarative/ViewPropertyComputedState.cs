using System;
using System.ComponentModel;

namespace Avalonia.Markup.Declarative;

internal class ViewPropertyComputedState<T> : ViewPropertyComputedState
{
    public Action<T>? SetChangedHandler { get; }

    public T Value
    {
        get => SetterFunc();
        set
        {
            if (SetChangedHandler == null)
                throw new ArgumentNullException($"{ExpressionString}: two way binding value change handler is not set");

            SetChangedHandler(value);
            OnPropertyChanged();
        }
    }

    public Func<T> SetterFunc { get; }
    internal ViewPropertyComputedState(Func<T> setterFunc, string? expressionString, Action<T>? setChangedHandler)
    {
        SetChangedHandler = setChangedHandler;
        ExpressionString = expressionString;
        SetterFunc = setterFunc;
    }

}
internal abstract class ViewPropertyComputedState : INotifyPropertyChanged
{
    internal string? ExpressionString { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ViewPropertyComputedState state &&
               ExpressionString == state.ExpressionString;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ExpressionString);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    internal void OnPropertyChanged() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
}