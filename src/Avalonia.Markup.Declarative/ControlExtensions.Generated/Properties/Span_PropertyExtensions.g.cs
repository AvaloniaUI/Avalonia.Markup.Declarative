#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpanExtensions
{
public static Span Inlines(this Span control, IBinding binding)
   => control._set(Span.InlinesProperty, binding);
public static Span Inlines(this Span control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Span.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Span Inlines(this Span control, Func<InlineCollection> func, Action<InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Span.InlinesProperty, func, onChanged, expression);
public static Span Inlines(this Span control, InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Span.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);
public static Span Inlines<TValue>(this Span control, TValue value, FuncValueConverter<TValue, InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Span.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

