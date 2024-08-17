#nullable enable
using AccessText = Avalonia.Controls.Primitives.AccessText;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AccessTextExtensions
{
public static T ShowAccessKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.AccessText
   => control._set(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, binding);
public static T ShowAccessKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.AccessText
   => control._set(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowAccessKey<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.AccessText
   => control._set(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, func, onChanged, expression);
public static T ShowAccessKey<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.AccessText
=> control._setEx(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = value, bindingMode, converter, bindingSource);
public static T ShowAccessKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.AccessText
=> control._setEx(Avalonia.Controls.Primitives.AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

