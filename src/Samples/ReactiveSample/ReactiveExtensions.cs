using ReactiveUI;
using System.Reactive.Linq;
using System.Linq.Expressions;

namespace ReactiveSample;

public static class ReactiveExtensions
{
    public static IBinding PropertyBinding<TViewModel, TProperty>(
        this TViewModel viewModel,
        Expression<Func<TViewModel, TProperty>> propertySelector,
        bool beforeChange = false,
        bool skipInitial = false)
        where TViewModel : ReactiveObject
    {
        return viewModel.ObservableForProperty(propertySelector, beforeChange, skipInitial)
                            .Select(x => x.GetValue())
                            .ToBinding();
    }

    public static IBinding PropertyBinding<TViewModel, TProperty, TResult>(
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
