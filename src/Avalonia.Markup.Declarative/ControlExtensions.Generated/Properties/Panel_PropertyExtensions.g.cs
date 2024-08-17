#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Panel = Avalonia.Controls.Panel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PanelExtensions
{
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Panel
   => control._set(Avalonia.Controls.Panel.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Panel
   => control._set(Avalonia.Controls.Panel.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Panel
   => control._set(Avalonia.Controls.Panel.BackgroundProperty, func, onChanged, expression);
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Panel
=> control._setEx(Avalonia.Controls.Panel.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Panel
=> control._setEx(Avalonia.Controls.Panel.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

