using Avalonia.Styling;
using System;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
/// <summary>
/// Typed style to support method chains with generic arguments
/// </summary>
/// <typeparam name="TControl">Type of the control that style will be applied to</typeparam>
public class Style<TControl> : Style, IRelativeStyle
    where TControl : StyledElement
{
    private Func<Selector, Selector> SelectorFunc { get; }

    /// <summary>
    /// Creates Style with added .OfType<typeparam name="TControl"></typeparam> selector
    /// </summary>
    public Style()
    {
        SelectorFunc = s => s.OfType<TControl>();
    }

    /// <summary>
    /// Creates Style with applied selector. 
    /// If user starts selector with a type (for example, OfType<StackPanel>), then it will be used as is.
    /// </summary>
    public Style(
            Func<Selector, Selector> selectorFunc,
            [CallerArgumentExpression(nameof(selectorFunc))] string? expression = null,
            [CallerFilePath] string? callerFile = null)
    {
        // determine if user provided explicit root type in selector
        var selectorString = selectorFunc(null!).ToString();
        
        // if selector starts with a letter, it means that user provided explicit root type (for example, OfType<StackPanel>).
        bool hasExplicitRootType = !string.IsNullOrEmpty(selectorString) && char.IsLetter(selectorString[0]);

        if (hasExplicitRootType)
        {
            SelectorFunc = selectorFunc;
        }
        else
        {
            // If user didn't provide explicit root type, we automatically add OfType<TControl>() to the beginning of the selector.
            SelectorFunc = s => selectorFunc(s.OfType<TControl>());
        }
    }

    public void UpdateSelector(Func<Selector, Selector>? baseSelectorFunc)
    {
        if (baseSelectorFunc != null)
            Selector = SelectorFunc(baseSelectorFunc(null!));
        else
            Selector = SelectorFunc(null!);
    }
}

internal interface IRelativeStyle : IStyle
{
    void UpdateSelector(Func<Selector, Selector>? baseSelectorFunc);
}