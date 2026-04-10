using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;

namespace Avalonia.Markup.Declarative;

public static class StylePropertyExtensions
{
    /// <summary>
    /// Creates selector and applies .OfType<TElement>() to it
    /// </summary>
    /// <typeparam name="TElement">Type of the control that style will be applied</typeparam>
    /// <param name="style">Style</param>
    /// <param name="selector">Selector modifier function</param>
    /// <returns>style with applied selector</returns>
    public static Style<TElement> Selector<TElement>(this Style<TElement> style, Func<Selector, Selector> selector)
        where TElement : StyledElement
    {
        Selector TypeSelector(Selector? s) => s.OfType<TElement>();
        style.Selector = selector(TypeSelector(null));
        return style;
    }

    public static Style Selector(this Style style, Func<Selector?, Selector> selector)
    {
        style.Selector = selector(null);
        return style;
    }

    public static Style<TElement> Setter<TElement>(this Style<TElement> style, AvaloniaProperty avaloniaProperty, object value)
        where TElement : StyledElement
    {
        style._addSetter(avaloniaProperty, value);
        return style;
    }

    public static Style Setter(this Style style, AvaloniaProperty avaloniaProperty, object value)
    {
        style.Setters.Add(new Setter(avaloniaProperty, value));
        return style;
    }

    public static Style<TElement> _addSetter<TElement>(this Style<TElement> style, AvaloniaProperty avaloniaProperty, object value) 
        where TElement : StyledElement
    {
        style.Setters.Add(new Setter(avaloniaProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter using a compiled binding with a specified source.
    /// </summary>
    public static Style<TElement> _addSetterCompiledBinding<TElement, TViewModel, TValue>(
        this Style<TElement> style,
        AvaloniaProperty avaloniaProperty,
        TViewModel source,
        Expression<Func<TViewModel, TValue>> getter,
        BindingMode? bindingMode = null,
        IValueConverter? converter = null)
        where TElement : StyledElement
    {
        var binding = CompiledBinding.Create(getter, source: source, mode: bindingMode ?? BindingMode.Default, converter: converter);
        style.Setters.Add(new Setter(avaloniaProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter using a compiled binding relative to DataContext.
    /// </summary>
    public static Style<TElement> _addSetterCompiledBinding<TElement, TViewModel, TValue>(
            this Style<TElement> style,
            AvaloniaProperty avaloniaProperty,
            Expression<Func<TViewModel, TValue>> getter,
            BindingMode? bindingMode = null,
            IValueConverter? converter = null)
            where TElement : StyledElement
    {
        var binding = CompiledBinding.Create(getter, mode: bindingMode ?? BindingMode.Default, converter: converter);

        style.Setters.Add(new Setter(avaloniaProperty, binding));
        return style;
    }

    public static Style<TElement> Col<TElement>(this Style<TElement> style, int value)
        where TElement : Control
    {
        style.Add(new Setter(Grid.ColumnProperty, value));
        return style;
    }

    public static Style<TElement> Row<TElement>(this Style<TElement> style, int value)
        where TElement : Control
    {
        style.Add(new Setter(Grid.RowProperty, value));
        return style;
    }

    public static Style<TElement> ColSpan<TElement>(this Style<TElement> style, int value)
        where TElement : Control
    {
        style.Add(new Setter(Grid.ColumnSpanProperty, value));
        return style;
    }

    public static Style<TElement> RowSpan<TElement>(this Style<TElement> style, int value)
        where TElement : Control
    {
        style.Add(new Setter(Grid.RowSpanProperty, value));
        return style;
    }

}