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
        where TElement : IStyleable
    {
        Selector TypeSelector(Selector s) => s.OfType<TElement>();
        style.Selector = selector(TypeSelector(null));
        return style;
    }

    public static Style Selector(this Style style, Func<Selector, Selector> selector)
    {
        style.Selector = selector(null);
        return style;
    }

    public static Style<TElement> Setter<TElement>(this Style<TElement> style, AvaloniaProperty avaloniaProperty, object value)
        where TElement : IStyleable
    {
        style._addSetter(avaloniaProperty, value);
        return style;
    }

    public static Style Setter(this Style style, AvaloniaProperty avaloniaProperty, object value)
    {
        style.Setters.Add(new Setter(avaloniaProperty, value));
        return style;
    }

    //public static Style<TElement> Background<TElement>(this Style<TElement> style, Brush brush) where TElement : TemplatedControl =>
    //    style._addSetter(TemplatedControl.BackgroundProperty, brush);

    public static Style<TElement> _addSetter<TElement>(this Style<TElement> style, AvaloniaProperty avaloniaProperty, object value) where TElement : IStyleable
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
    where TControl : IStyleable
{
    public Style()
    {
        Selector TypeSelector(Selector s) => s.OfType<TControl>();
        Selector = TypeSelector(null);
    }

    public Style(Func<Selector, Selector> selector)
    {
        Selector TypeSelector(Selector s) => s.OfType<TControl>();
        Selector = selector(TypeSelector(null));
    }
}