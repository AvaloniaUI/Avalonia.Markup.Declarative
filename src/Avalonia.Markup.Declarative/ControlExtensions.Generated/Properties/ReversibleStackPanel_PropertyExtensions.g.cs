#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ReversibleStackPanel = Avalonia.Controls.ReversibleStackPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ReversibleStackPanelExtensions
{
public static T ReverseOrder<T>(this T control, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);
public static T ReverseOrder<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ReversibleStackPanel
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ReverseOrder<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ReversibleStackPanel
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, func, onChanged, expression);
public static T ReverseOrder<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ReversibleStackPanel
=> control._setEx(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = value, bindingMode, converter, bindingSource);
public static T ReverseOrder<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ReversibleStackPanel
=> control._setEx(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

