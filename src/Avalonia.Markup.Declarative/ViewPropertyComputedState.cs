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
        {
            _observers.Add(observer);
            // Immediately notify the new observer with the current value
            observer.OnNext(Value);
        }
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
    private TValue? _lastSetValue; // Track the last value we set to detect external changes
    private bool _isUpdatingFromGetter; // Flag to prevent recursive updates
    private bool _isInitializing = true; // Track if we're in initialization phase
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

        // During initialization, always set the value
        _isInitializing = true;
        UpdateControlValue();
        _isInitializing = false;

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

        // During initialization, always set the value
        _isInitializing = true;
        UpdateControlValue();
        _isInitializing = false;
    }

    public override void OnPropertyChanged()
    {
        if (_isUpdatingFromGetter)
            return;
            
        UpdateControlValue();
        NotifyObservers(Value);
    }

    private void UpdateControlValue()
    {
        if (_control == null)
            return;

        _isUpdatingFromGetter = true;
        try
        {
            TValue newValue = GetterFunc();

            // During initialization, always set the value
            // After initialization, only update if value actually changed
            if (_avaloniaProperty != null)
            {
                if (_isInitializing)
                {
                    _control.SetValue(_avaloniaProperty, newValue);
                    _lastSetValue = newValue;
                }
                else
                {
                    var currentValue = _control.GetValue(_avaloniaProperty);
                    if (!Equals(currentValue, newValue))
                    {
                        _control.SetValue(_avaloniaProperty, newValue);
                        _lastSetValue = newValue;
                    }
                }
            }
            else
            {
                if (_isInitializing || !Equals(_lastSetValue, newValue))
                {
                    Setter?.Invoke(newValue);
                    _lastSetValue = newValue;
                }
            }
        }
        finally
        {
            _isUpdatingFromGetter = false;
        }
    }

    public void OnNext(TValue value)
    {
        if (_isUpdatingFromGetter)
            return;

        // Check if value is actually different from what getter returns
        var currentGetterValue = GetterFunc();
        
        if (EqualityComparer<TValue>.Default.Equals(value, currentGetterValue))
            return;

        // Update the last set value to track this change
        _lastSetValue = value;

        // Call the handler for this component
        SetChangedHandler?.Invoke(value);

        // Handle property propagation to parent components
        // Check if we have an expression string for property tracking and a parent view
        if (!string.IsNullOrEmpty(ExpressionString) && _parentView is ComponentBase parentComponent)
        {
            // Notify parent without using reflection
            parentComponent.NotifyExternalPropertyChanged(ExpressionString, value);
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
        {
            _observers.Add(observer);
            // Immediately notify the new observer with the current value
            observer.OnNext(Value);
        }
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