#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RangeBase = Avalonia.Controls.Primitives.RangeBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RangeBaseExtensions
{
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, func, onChanged, expression);
public static T Minimum<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static T Minimum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, func, onChanged, expression);
public static T Maximum<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static T Maximum<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, func, onChanged, expression);
public static T Value<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static T Value<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SmallChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);
public static T SmallChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SmallChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, func, onChanged, expression);
public static T SmallChange<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, ps, () => control.SmallChange = value, bindingMode, converter, bindingSource);
public static T SmallChange<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, ps, () => control.SmallChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T LargeChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);
public static T LargeChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LargeChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, func, onChanged, expression);
public static T LargeChange<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, ps, () => control.LargeChange = value, bindingMode, converter, bindingSource);
public static T LargeChange<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, ps, () => control.LargeChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

