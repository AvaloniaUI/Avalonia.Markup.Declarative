#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RangeBaseExtensions
{
public static RangeBase Minimum(this RangeBase control, IBinding binding)
   => control._set(RangeBase.MinimumProperty, binding);
public static RangeBase Minimum(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RangeBase.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RangeBase Minimum(this RangeBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.MinimumProperty, func, onChanged, expression);
public static RangeBase Minimum(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static RangeBase Minimum<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase Maximum(this RangeBase control, IBinding binding)
   => control._set(RangeBase.MaximumProperty, binding);
public static RangeBase Maximum(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RangeBase.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RangeBase Maximum(this RangeBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.MaximumProperty, func, onChanged, expression);
public static RangeBase Maximum(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static RangeBase Maximum<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase Value(this RangeBase control, IBinding binding)
   => control._set(RangeBase.ValueProperty, binding);
public static RangeBase Value(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RangeBase.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RangeBase Value(this RangeBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.ValueProperty, func, onChanged, expression);
public static RangeBase Value(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static RangeBase Value<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase SmallChange(this RangeBase control, IBinding binding)
   => control._set(RangeBase.SmallChangeProperty, binding);
public static RangeBase SmallChange(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RangeBase.SmallChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RangeBase SmallChange(this RangeBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.SmallChangeProperty, func, onChanged, expression);
public static RangeBase SmallChange(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.SmallChangeProperty, ps, () => control.SmallChange = value, bindingMode, converter, bindingSource);
public static RangeBase SmallChange<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.SmallChangeProperty, ps, () => control.SmallChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase LargeChange(this RangeBase control, IBinding binding)
   => control._set(RangeBase.LargeChangeProperty, binding);
public static RangeBase LargeChange(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RangeBase.LargeChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RangeBase LargeChange(this RangeBase control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.LargeChangeProperty, func, onChanged, expression);
public static RangeBase LargeChange(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.LargeChangeProperty, ps, () => control.LargeChange = value, bindingMode, converter, bindingSource);
public static RangeBase LargeChange<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.LargeChangeProperty, ps, () => control.LargeChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

