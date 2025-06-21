using ReactiveUI;
using System.Linq.Expressions;
using System.Reactive;

namespace ReactiveSample;

public static class ReactiveExtensions
{
    /// <summary>
    /// Binds a control property to a view model property using ReactiveUI's reactive bindings.
    /// </summary>
    /// <typeparam name="TControl">The type of the control (must inherit from AvaloniaObject).</typeparam>
    /// <typeparam name="TViewModel">The type of the view model (must inherit from ReactiveObject).</typeparam>
    /// <typeparam name="TValue">The type of the control property.</typeparam>
    /// <typeparam name="TValue2">The type of the view model property.</typeparam>
    /// <param name="control">The control whose property will be bound.</param>
    /// <param name="prop">The Avalonia property on the control to bind.</param>
    /// <param name="model">The view model instance to bind to.</param>
    /// <param name="propertySelector">An expression selecting the property on the view model to bind.</param>
    /// <param name="onChange">Optional: An action to invoke when the control property changes (for two-way binding).</param>
    /// <param name="valueSelector">Optional: A function to convert the view model property value to the control property value.</param>
    /// <returns>The control instance, for chaining.</returns>
    public static TControl ReactiveBinding<TControl, TViewModel, TValue, TValue2>(this TControl control,
        AvaloniaProperty<TValue?> prop,
        TViewModel model,
        Expression<Func<TViewModel, TValue2?>> propertySelector,
        Action<TValue?>? onChange,
        Func<TValue2?, TValue?>? valueSelector = null) where TControl : AvaloniaObject where TViewModel : ReactiveObject
    {
        //One Way
        model.ObservableForProperty(propertySelector, skipInitial: false).Value()
             .SubscribeSafe(new AnonymousObserver<TValue2?>(v =>
            {
                control.SetValue(prop, valueSelector == null ? v : valueSelector(v));
            }));

        //Two Way
        if (onChange != null)
        {
            control.GetObservable(prop).SubscribeSafe(new AnonymousObserver<TValue?>(onChange.Invoke));
        }

        return control;
    }

    /// <summary>
    /// Binds a control property to a view model property using ReactiveUI's reactive bindings.
    /// </summary>
    /// <typeparam name="TControl">The type of the control (must inherit from Control).</typeparam>
    /// <typeparam name="TViewModel">The type of the view model (must inherit from ReactiveObject).</typeparam>
    /// <typeparam name="TValue">The type of the property on both the control and the view model.</typeparam>
    /// <param name="control">The control whose property will be bound.</param>
    /// <param name="prop">The Avalonia property on the control to bind.</param>
    /// <param name="model">The view model instance to bind to.</param>
    /// <param name="propertySelector">An expression selecting the property on the view model to bind.</param>
    /// <param name="onChange">Optional: An action to invoke when the control property changes (for two-way binding).</param>
    /// <returns>The control instance, for chaining.</returns>
    public static TControl ReactiveBinding<TControl, TViewModel, TValue>(this TControl control,
        AvaloniaProperty<TValue?> prop,
        TViewModel model,
        Expression<Func<TViewModel, TValue?>> propertySelector,
        Action<TValue?>? onChange = null) where TControl : Control where TViewModel : ReactiveObject
    {
        ReactiveBinding(control, prop, model, propertySelector, onChange, null);

        return control;
    }
}
