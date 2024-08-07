#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupFlyoutBaseExtensions
{
public static T Placement<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementProperty, binding);
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Placement<T>(this T control, Func<PlacementMode> func, Action<PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementProperty, func, onChanged, expression);
public static T Placement<T>(this T control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.HorizontalOffsetProperty, binding);
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.HorizontalOffsetProperty, func, onChanged, expression);
public static T HorizontalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static T HorizontalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalOffset<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.VerticalOffsetProperty, binding);
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.VerticalOffsetProperty, func, onChanged, expression);
public static T VerticalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static T VerticalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementAnchorProperty, binding);
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementAnchor<T>(this T control, Func<PopupAnchor> func, Action<PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementAnchorProperty, func, onChanged, expression);
public static T PlacementAnchor<T>(this T control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static T PlacementAnchor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementGravity<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementGravityProperty, binding);
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementGravity<T>(this T control, Func<PopupGravity> func, Action<PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementGravityProperty, func, onChanged, expression);
public static T PlacementGravity<T>(this T control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static T PlacementGravity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowMode<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.ShowModeProperty, binding);
public static T ShowMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.ShowModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowMode<T>(this T control, Func<FlyoutShowMode> func, Action<FlyoutShowMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.ShowModeProperty, func, onChanged, expression);
public static T ShowMode<T>(this T control, FlyoutShowMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = value, bindingMode, converter, bindingSource);
public static T ShowMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlyoutShowMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.OverlayInputPassThroughElementProperty, binding);
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OverlayInputPassThroughElement<T>(this T control, Func<IInputElement> func, Action<IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.OverlayInputPassThroughElementProperty, func, onChanged, expression);
public static T OverlayInputPassThroughElement<T>(this T control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementConstraintAdjustmentProperty, binding);
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementConstraintAdjustment<T>(this T control, Func<PopupPositionerConstraintAdjustment> func, Action<PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementConstraintAdjustmentProperty, func, onChanged, expression);
public static T PlacementConstraintAdjustment<T>(this T control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

