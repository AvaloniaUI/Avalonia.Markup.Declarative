using System;
using System.ComponentModel;

namespace Avalonia.Markup.Declarative;

internal class ViewPropertyComputedState<T> : ViewPropertyComputedState
{
    public T Value => SetterFunc();
    public Func<T> SetterFunc { get; }
    internal ViewPropertyComputedState(Func<T> setterFunc, string expressionString)
    {
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