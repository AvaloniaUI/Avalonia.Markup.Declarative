#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Visual = Avalonia.Visual;

namespace Avalonia.Markup.Declarative;
public static partial class VisualExtensions
{
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ClipToBoundsProperty, binding);
public static T ClipToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ClipToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClipToBounds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ClipToBoundsProperty, func, onChanged, expression);
public static T ClipToBounds<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = value, bindingMode, converter, bindingSource);
public static T ClipToBounds<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Clip<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ClipProperty, binding);
public static T Clip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ClipProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Clip<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ClipProperty, func, onChanged, expression);
public static T Clip<T>(this T control, Avalonia.Media.Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.ClipProperty, ps, () => control.Clip = value, bindingMode, converter, bindingSource);
public static T Clip<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.ClipProperty, ps, () => control.Clip = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.IsVisibleProperty, func, onChanged, expression);
public static T IsVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.OpacityProperty, binding);
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.OpacityProperty, func, onChanged, expression);
public static T Opacity<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static T Opacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OpacityMask<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.OpacityMaskProperty, binding);
public static T OpacityMask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OpacityMask<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.OpacityMaskProperty, func, onChanged, expression);
public static T OpacityMask<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);
public static T OpacityMask<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Effect<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.EffectProperty, binding);
public static T Effect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.EffectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Effect<T>(this T control, Func<Avalonia.Media.IEffect> func, Action<Avalonia.Media.IEffect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.EffectProperty, func, onChanged, expression);
public static T Effect<T>(this T control, Avalonia.Media.IEffect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.EffectProperty, ps, () => control.Effect = value, bindingMode, converter, bindingSource);
public static T Effect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IEffect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.EffectProperty, ps, () => control.Effect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RenderTransform<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.RenderTransformProperty, binding);
public static T RenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.RenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RenderTransform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.RenderTransformProperty, func, onChanged, expression);
public static T RenderTransform<T>(this T control, Avalonia.Media.ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.RenderTransformProperty, ps, () => control.RenderTransform = value, bindingMode, converter, bindingSource);
public static T RenderTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.RenderTransformProperty, ps, () => control.RenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, binding);
public static T RenderTransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RenderTransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, func, onChanged, expression);
public static T RenderTransformOrigin<T>(this T control, Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = value, bindingMode, converter, bindingSource);
public static T RenderTransformOrigin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T RenderTransformOrigin<T>(this T control, Double x = default, Double y = default, RelativeUnit unit = default) where T : Avalonia.Visual
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Point point = default, RelativeUnit unit = default) where T : Avalonia.Visual
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(point, unit));
public static T FlowDirection<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.FlowDirectionProperty, binding);
public static T FlowDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.FlowDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.FlowDirectionProperty, func, onChanged, expression);
public static T FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.FlowDirectionProperty, ps, () => control.FlowDirection = value, bindingMode, converter, bindingSource);
public static T FlowDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FlowDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.FlowDirectionProperty, ps, () => control.FlowDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ZIndex<T>(this T control, IBinding binding) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ZIndexProperty, binding);
public static T ZIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ZIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ZIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual
   => control._set(Avalonia.Visual.ZIndexProperty, func, onChanged, expression);
public static T ZIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.ZIndexProperty, ps, () => control.ZIndex = value, bindingMode, converter, bindingSource);
public static T ZIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
=> control._setEx(Avalonia.Visual.ZIndexProperty, ps, () => control.ZIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

