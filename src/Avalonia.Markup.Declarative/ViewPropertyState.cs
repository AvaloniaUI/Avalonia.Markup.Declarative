using System;
using System.Reflection;

namespace Avalonia.Markup.Declarative;

internal class ViewPropertyState<TValue> : ViewPropertyState
{
    private readonly Action<TValue?> _setAction;

    private TValue? TypedValue => (TValue?) Value;

    public ViewPropertyState(PropertyInfo propertyInfo, ViewBase view, Action<TValue?> setAction) : base(propertyInfo, view)
    {
        _setAction = setAction;
    }

    public override bool CheckStateChangedAndUpdate()
    {
        var result = base.CheckStateChangedAndUpdate();

        if (result)
            _setAction(TypedValue);

        return result;
    }
}

internal class ViewPropertyState
{
    public object? Value { get; private set; }

    public string Name { get; }
    private PropertyInfo PropertyInfo { get; }
    private ViewBase View { get; }

    public ViewPropertyState(PropertyInfo propertyInfo, ViewBase view)
    {
        this.PropertyInfo = propertyInfo;
        this.View = view;

        this.Name = propertyInfo.Name;

        Value = PropertyInfo.GetValue(View);
    }

    public virtual bool CheckStateChangedAndUpdate()
    {
        var oldValue = Value;
        Value = PropertyInfo.GetValue(View);

        if (Value == null && oldValue != null)
            return false;

        if (Value != null && oldValue == null)
            return false;

        return
            (Value == null && oldValue == null)
            || (Value != null && !Value.Equals(oldValue));
    }
}