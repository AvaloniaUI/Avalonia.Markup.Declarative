#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using HyperlinkButton = Avalonia.Controls.HyperlinkButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HyperlinkButtonExtensions
{
public static T IsVisited<T>(this T control, IBinding binding) where T : Avalonia.Controls.HyperlinkButton
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, binding);
public static T IsVisited<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.HyperlinkButton
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisited<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.HyperlinkButton
   => control._set(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, func, onChanged, expression);
public static T IsVisited<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.HyperlinkButton
=> control._setEx(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, ps, () => control.IsVisited = value, bindingMode, converter, bindingSource);
public static T IsVisited<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.HyperlinkButton
=> control._setEx(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, ps, () => control.IsVisited = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T NavigateUri<T>(this T control, IBinding binding) where T : Avalonia.Controls.HyperlinkButton
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, binding);
public static T NavigateUri<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.HyperlinkButton
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T NavigateUri<T>(this T control, Func<System.Uri> func, Action<System.Uri>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.HyperlinkButton
   => control._set(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, func, onChanged, expression);
public static T NavigateUri<T>(this T control, System.Uri value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.HyperlinkButton
=> control._setEx(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, ps, () => control.NavigateUri = value, bindingMode, converter, bindingSource);
public static T NavigateUri<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Uri> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.HyperlinkButton
=> control._setEx(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, ps, () => control.NavigateUri = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

