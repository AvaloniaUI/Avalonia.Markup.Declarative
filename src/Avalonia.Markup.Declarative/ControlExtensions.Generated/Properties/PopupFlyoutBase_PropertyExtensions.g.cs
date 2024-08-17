#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using PopupFlyoutBase = Avalonia.Controls.Primitives.PopupFlyoutBase;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupFlyoutBaseExtensions
{
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, binding);
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, func, onChanged, expression);
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, binding);
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, func, onChanged, expression);
public static T HorizontalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static T HorizontalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, binding);
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, func, onChanged, expression);
public static T VerticalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static T VerticalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, binding);
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, func, onChanged, expression);
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static T PlacementAnchor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, binding);
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, func, onChanged, expression);
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static T PlacementGravity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, binding);
public static T ShowMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowMode<T>(this T control, Func<Avalonia.Controls.FlyoutShowMode> func, Action<Avalonia.Controls.FlyoutShowMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, func, onChanged, expression);
public static T ShowMode<T>(this T control, Avalonia.Controls.FlyoutShowMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = value, bindingMode, converter, bindingSource);
public static T ShowMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.FlyoutShowMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, binding);
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, func, onChanged, expression);
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, binding);
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, func, onChanged, expression);
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

