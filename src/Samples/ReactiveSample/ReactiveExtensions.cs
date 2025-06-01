using ReactiveUI;
using System.Linq.Expressions;
using System.Reactive.Linq;

namespace ReactiveSample;

public static class ReactiveExtensions
{
    public static IBinding ReactiveBinding<TViewModel, TProperty>(
        this TViewModel viewModel,
        Expression<Func<TViewModel, TProperty>> propertySelector,
        bool beforeChange = false,
        bool skipInitial = false)
        where TViewModel : ReactiveObject
    {
        return viewModel.ObservableForProperty(propertySelector, beforeChange, skipInitial)
                        .Value()
                        .ToBinding();
    }

    public static IBinding ReactiveBinding<TViewModel, TProperty, TResult>(
        this TViewModel viewModel,
        Expression<Func<TViewModel, TProperty>> propertySelector,
        Func<IObservedChange<TViewModel, TProperty>, TResult> valueSelector,
        bool beforeChange = false,
        bool skipInitial = false)
        where TViewModel : ReactiveObject
    {
        return viewModel.ObservableForProperty(propertySelector, beforeChange, skipInitial)
                        .Select(valueSelector)
                        .ToBinding();
    }
}

public static class AvaloniaObjectExtensions
{
    public static T Bind2<T>(this T obj, AvaloniaProperty prop, IObservable<object?> observable) where T : Control
    {
        obj.Bind(prop, observable);
        return obj;
    }
}