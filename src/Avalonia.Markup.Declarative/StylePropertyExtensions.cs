using Avalonia.Styling;
using System;

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
}

/// <summary>
/// Typed style to support method chains with generic arguments
/// </summary>
/// <typeparam name="TControl">Type of the control that style will be applied to</typeparam>
public class Style<TControl> : Style
    where TControl : StyledElement
{
    /// <summary>
    /// Creates Style with added .OfType<typeparam name="TControl"></typeparam> selector
    /// </summary>
    public Style()
    {
        Selector = ((Selector?)null).OfType<TControl>();
    }

    /// <summary>
    /// Don't forger to specify target control type directly, since it's impossible to inject it from generic type argument correctly yet
    /// otherwise Avalonia will try to apply this style to any control, that match this selector. 
    /// </summary>
    /// <param name="selector"></param>
    public Style(Func<Selector?, Selector> selector)
    {
        Selector = selector(null);
    }
}