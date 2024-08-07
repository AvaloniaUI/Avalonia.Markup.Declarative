#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HyperlinkButtonExtensions
{
public static HyperlinkButton IsVisited(this HyperlinkButton control, IBinding binding)
   => control._set(HyperlinkButton.IsVisitedProperty, binding);
public static HyperlinkButton IsVisited(this HyperlinkButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(HyperlinkButton.IsVisitedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static HyperlinkButton IsVisited(this HyperlinkButton control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HyperlinkButton.IsVisitedProperty, func, onChanged, expression);
public static HyperlinkButton IsVisited(this HyperlinkButton control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HyperlinkButton.IsVisitedProperty, ps, () => control.IsVisited = value, bindingMode, converter, bindingSource);
public static HyperlinkButton IsVisited<TValue>(this HyperlinkButton control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HyperlinkButton.IsVisitedProperty, ps, () => control.IsVisited = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static HyperlinkButton NavigateUri(this HyperlinkButton control, IBinding binding)
   => control._set(HyperlinkButton.NavigateUriProperty, binding);
public static HyperlinkButton NavigateUri(this HyperlinkButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(HyperlinkButton.NavigateUriProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static HyperlinkButton NavigateUri(this HyperlinkButton control, Func<Uri> func, Action<Uri>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HyperlinkButton.NavigateUriProperty, func, onChanged, expression);
public static HyperlinkButton NavigateUri(this HyperlinkButton control, Uri value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HyperlinkButton.NavigateUriProperty, ps, () => control.NavigateUri = value, bindingMode, converter, bindingSource);
public static HyperlinkButton NavigateUri<TValue>(this HyperlinkButton control, TValue value, FuncValueConverter<TValue, Uri> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HyperlinkButton.NavigateUriProperty, ps, () => control.NavigateUri = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

