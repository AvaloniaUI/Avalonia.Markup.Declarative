#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class VisualExtensions
{
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.ClipToBoundsProperty, binding);
public static T ClipToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.ClipToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClipToBounds<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.ClipToBoundsProperty, func, onChanged, expression);
public static T ClipToBounds<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = value, bindingMode, converter, bindingSource);
public static T ClipToBounds<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Clip<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.ClipProperty, binding);
public static T Clip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.ClipProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Clip<T>(this T control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.ClipProperty, func, onChanged, expression);
public static T Clip<T>(this T control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipProperty, ps, () => control.Clip = value, bindingMode, converter, bindingSource);
public static T Clip<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipProperty, ps, () => control.Clip = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.IsVisibleProperty, func, onChanged, expression);
public static T IsVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Opacity<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.OpacityProperty, binding);
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Opacity<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.OpacityProperty, func, onChanged, expression);
public static T Opacity<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static T Opacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OpacityMask<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.OpacityMaskProperty, binding);
public static T OpacityMask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OpacityMask<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.OpacityMaskProperty, func, onChanged, expression);
public static T OpacityMask<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);
public static T OpacityMask<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Effect<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.EffectProperty, binding);
public static T Effect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.EffectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Effect<T>(this T control, Func<IEffect> func, Action<IEffect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.EffectProperty, func, onChanged, expression);
public static T Effect<T>(this T control, IEffect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.EffectProperty, ps, () => control.Effect = value, bindingMode, converter, bindingSource);
public static T Effect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEffect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.EffectProperty, ps, () => control.Effect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RenderTransform<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.RenderTransformProperty, binding);
public static T RenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.RenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RenderTransform<T>(this T control, Func<ITransform> func, Action<ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.RenderTransformProperty, func, onChanged, expression);
public static T RenderTransform<T>(this T control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformProperty, ps, () => control.RenderTransform = value, bindingMode, converter, bindingSource);
public static T RenderTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformProperty, ps, () => control.RenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.RenderTransformOriginProperty, binding);
public static T RenderTransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.RenderTransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RenderTransformOrigin<T>(this T control, Func<RelativePoint> func, Action<RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.RenderTransformOriginProperty, func, onChanged, expression);
public static T RenderTransformOrigin<T>(this T control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = value, bindingMode, converter, bindingSource);
public static T RenderTransformOrigin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T RenderTransformOrigin<T>(this T control, Double x = default, Double y = default, RelativeUnit unit = default) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Point point = default, RelativeUnit unit = default) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(point, unit));
public static T FlowDirection<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.FlowDirectionProperty, binding);
public static T FlowDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.FlowDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FlowDirection<T>(this T control, Func<FlowDirection> func, Action<FlowDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.FlowDirectionProperty, func, onChanged, expression);
public static T FlowDirection<T>(this T control, FlowDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.FlowDirectionProperty, ps, () => control.FlowDirection = value, bindingMode, converter, bindingSource);
public static T FlowDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlowDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.FlowDirectionProperty, ps, () => control.FlowDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ZIndex<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.ZIndexProperty, binding);
public static T ZIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Visual
   => control._set(Visual.ZIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ZIndex<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.ZIndexProperty, func, onChanged, expression);
public static T ZIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ZIndexProperty, ps, () => control.ZIndex = value, bindingMode, converter, bindingSource);
public static T ZIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ZIndexProperty, ps, () => control.ZIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

