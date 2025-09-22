//prevent from warning "Method 'OnPropertyChanged' do not invoke base.OnPropertyChanged" - OnPropertyChanged is abstract
#pragma warning disable AVA2001

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Avalonia.Markup.Declarative;

internal class ViewPropertyComputedState<TValue> : ExpressionBindingBase, IObservable<TValue>, INotifyPropertyChanged
{
    private Func<TValue> GetterFunc { get; }
    private TValue Value => GetterFunc();

    public ViewPropertyComputedState(string? expressionString, Func<TValue> getterFunc)
    {
        GetterFunc = getterFunc;
        ExpressionString = expressionString;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public override void OnPropertyChanged()
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
        NotifyObservers(Value);
    }

    private readonly List<IObserver<TValue>> _observers = [];

    public IDisposable Subscribe(IObserver<TValue> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber(_observers, observer);
    }

    private void NotifyObservers(TValue value)
    {
        foreach (var observer in _observers)
            observer.OnNext(value);
    }

    private class Unsubscriber(ICollection<IObserver<TValue>> observers, IObserver<TValue> observer) : IDisposable
    {
        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }
}

internal class ViewPropertyComputedState<TControl, TValue> : ExpressionBindingBase, IObservable<TValue>, IObserver<TValue>
    where TControl : AvaloniaObject

{
    private readonly IObservable<TValue>? _obs;
    private readonly TControl? _control;
    private readonly AvaloniaProperty<TValue>? _avaloniaProperty;
    private readonly ViewBase? _parentView; // Store reference to the parent view for property bubbling
    private Action<TValue>? Setter { get; }
    private Action<TValue>? SetChangedHandler { get; }
    private TValue Value => GetterFunc();
    public Func<TValue> GetterFunc { get; }

    internal ViewPropertyComputedState(string? expressionString,
        Func<TValue> getterFunc,
        Action<TValue>? setChangedHandler,
        TControl? control,
        AvaloniaProperty<TValue>? avaloniaProperty)
    {
        _control = control;
        _avaloniaProperty = avaloniaProperty;
        SetChangedHandler = setChangedHandler;
        ExpressionString = expressionString;
        GetterFunc = getterFunc;
        _parentView = ViewBuildContext.CurrentView; // Capture the current view context for property bubbling

        if (control == null)
            return;

        UpdateControlValue();

        if (_avaloniaProperty != null)
        {
            control.Bind(_avaloniaProperty, this);

            if (setChangedHandler != null)
            {
                _obs = control.GetObservable(_avaloniaProperty);
                _obs.Subscribe(this);
            }
        }
    }

    internal ViewPropertyComputedState(string? expressionString,
        Action<TValue> setter,
        Func<TValue> getterFunc,
        Action<TValue>? setChangedHandler,
        TControl? control)
    {
        _control = control;
        Setter = setter;
        SetChangedHandler = setChangedHandler;
        ExpressionString = expressionString;
        GetterFunc = getterFunc;
        _parentView = ViewBuildContext.CurrentView; // Capture the current view context for property bubbling

        if (control == null)
            return;

        UpdateControlValue();
    }

    public override void OnPropertyChanged()
    {
        UpdateControlValue();
        NotifyObservers(Value);
    }

    private void UpdateControlValue()
    {
        if (_control == null)
            return;

        TValue newValue = GetterFunc();

        //GetterFunc();
        if (_avaloniaProperty != null)
        {
            if (!Equals(_control.GetValue(_avaloniaProperty), newValue))
            {
                _control.SetValue(_avaloniaProperty, newValue);
            }
        }
        else
        {
            if (Setter != null)
            {
                Setter.Invoke(newValue);
            }
        }
    }

    public void OnNext(TValue value)
    {
        if (Value == null && value == null)
            return;

        if (value != null && value.Equals(Value))
            return;

        // Call the handler for this component
        SetChangedHandler?.Invoke(value);

        // Handle property propagation to parent components
        // Check if we have an expression string for property tracking and a parent view
        if (!string.IsNullOrEmpty(ExpressionString) && _parentView is ComponentBase parentComponent)
        {
            // First, try direct child component propagation (existing behavior)
            if (_control is ComponentBase childComponent)
            {
                // Notify parent without using reflection
                parentComponent.NotifyExternalPropertyChanged(ExpressionString, value);
            }
            else
            {
                // For regular Avalonia controls, we need to bubble up to the parent component
                // The parent component is stored when this state was created during view building
                parentComponent.NotifyExternalPropertyChanged(ExpressionString, value);
            }
        }
    }

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    #region IObservable implementation

    private readonly List<IObserver<TValue>> _observers = [];

    public IDisposable Subscribe(IObserver<TValue> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
        return new Unsubscriber(_observers, observer);
    }

    public void NotifyObservers(TValue value)
    {
        foreach (var observer in _observers)
            observer.OnNext(value);
    }

    private class Unsubscriber(ICollection<IObserver<TValue>> observers, IObserver<TValue> observer) : IDisposable
    {
        public void Dispose()
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
    }

    #endregion

}

internal abstract class ExpressionBindingBase
{
    internal string? ExpressionString { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is ExpressionBindingBase state &&
               ExpressionString == state.ExpressionString;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ExpressionString);
    }

    public abstract void OnPropertyChanged();
}