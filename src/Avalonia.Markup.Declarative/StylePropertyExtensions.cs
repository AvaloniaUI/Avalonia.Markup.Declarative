using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
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
    /// Adds a style setter using a strongly-typed expression.
    /// The expression is converted to a property path for DataContext-relative binding
    /// (the source parameter is used only for generic type inference).
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
        var propertyPath = ExpressionToPropertyPath(getter);
        var binding = new Binding(propertyPath)
        {
            Mode = bindingMode ?? BindingMode.Default,
            Converter = converter
        };

        style.Setters.Add(new Setter(avaloniaProperty, binding));
        return style;
    }

    private static string ExpressionToPropertyPath<TIn, TOut>(Expression<Func<TIn, TOut>> expression)
    {
        var members = new List<string>();
        var expr = expression.Body;

        // Unwrap Convert/ConvertChecked (e.g. boxing casts)
        if (expr is UnaryExpression { NodeType: ExpressionType.Convert or ExpressionType.ConvertChecked } unary)
            expr = unary.Operand;

        while (expr is MemberExpression memberExpr)
        {
            members.Insert(0, memberExpr.Member.Name);
            expr = memberExpr.Expression;
        }

        return string.Join(".", members);
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