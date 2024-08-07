#nullable enable
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
public static AccessText ShowAccessKey(this AccessText control, IBinding binding)
   => control._set(AccessText.ShowAccessKeyProperty, binding);
public static AccessText ShowAccessKey(this AccessText control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(AccessText.ShowAccessKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static AccessText ShowAccessKey(this AccessText control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AccessText.ShowAccessKeyProperty, func, onChanged, expression);
public static AccessText ShowAccessKey(this AccessText control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = value, bindingMode, converter, bindingSource);
public static AccessText ShowAccessKey<TValue>(this AccessText control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

