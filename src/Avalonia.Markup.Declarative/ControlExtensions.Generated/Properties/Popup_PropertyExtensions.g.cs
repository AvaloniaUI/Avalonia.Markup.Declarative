#nullable enable
using Avalonia;
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
public static partial class PopupExtensions
{
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.WindowManagerAddShadowHintProperty, binding);
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WindowManagerAddShadowHint<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.WindowManagerAddShadowHintProperty, func, onChanged, expression);
public static T WindowManagerAddShadowHint<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static T WindowManagerAddShadowHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Child<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.ChildProperty, binding);
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Child<T>(this T control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.ChildProperty, func, onChanged, expression);
public static T Child<T>(this T control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static T Child<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InheritsTransform<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.InheritsTransformProperty, binding);
public static T InheritsTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.InheritsTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InheritsTransform<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.InheritsTransformProperty, func, onChanged, expression);
public static T InheritsTransform<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = value, bindingMode, converter, bindingSource);
public static T InheritsTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsOpen<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.IsOpenProperty, binding);
public static T IsOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsOpen<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.IsOpenProperty, func, onChanged, expression);
public static T IsOpen<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = value, bindingMode, converter, bindingSource);
public static T IsOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.PlacementAnchorProperty, binding);
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementAnchor<T>(this T control, Func<PopupAnchor> func, Action<PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.PlacementAnchorProperty, func, onChanged, expression);
public static T PlacementAnchor<T>(this T control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static T PlacementAnchor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.PlacementConstraintAdjustmentProperty, binding);
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementConstraintAdjustment<T>(this T control, Func<PopupPositionerConstraintAdjustment> func, Action<PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.PlacementConstraintAdjustmentProperty, func, onChanged, expression);
public static T PlacementConstraintAdjustment<T>(this T control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.PlacementGravityProperty, binding);
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementGravity<T>(this T control, Func<PopupGravity> func, Action<PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.PlacementGravityProperty, func, onChanged, expression);
public static T PlacementGravity<T>(this T control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static T PlacementGravity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Placement<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.PlacementProperty, binding);
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Placement<T>(this T control, Func<PlacementMode> func, Action<PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.PlacementProperty, func, onChanged, expression);
public static T Placement<T>(this T control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementRect<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.PlacementRectProperty, binding);
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementRect<T>(this T control, Func<Nullable<Rect>> func, Action<Nullable<Rect>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.PlacementRectProperty, func, onChanged, expression);
public static T PlacementRect<T>(this T control, Nullable<Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);
public static T PlacementRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementTarget<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.PlacementTargetProperty, binding);
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementTarget<T>(this T control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.PlacementTargetProperty, func, onChanged, expression);
public static T PlacementTarget<T>(this T control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);
public static T PlacementTarget<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OverlayDismissEventPassThrough<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.OverlayDismissEventPassThroughProperty, binding);
public static T OverlayDismissEventPassThrough<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OverlayDismissEventPassThrough<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.OverlayDismissEventPassThroughProperty, func, onChanged, expression);
public static T OverlayDismissEventPassThrough<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value, bindingMode, converter, bindingSource);
public static T OverlayDismissEventPassThrough<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.OverlayInputPassThroughElementProperty, binding);
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OverlayInputPassThroughElement<T>(this T control, Func<IInputElement> func, Action<IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.OverlayInputPassThroughElementProperty, func, onChanged, expression);
public static T OverlayInputPassThroughElement<T>(this T control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.HorizontalOffsetProperty, binding);
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.HorizontalOffsetProperty, func, onChanged, expression);
public static T HorizontalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static T HorizontalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsLightDismissEnabled<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.IsLightDismissEnabledProperty, binding);
public static T IsLightDismissEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.IsLightDismissEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsLightDismissEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.IsLightDismissEnabledProperty, func, onChanged, expression);
public static T IsLightDismissEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = value, bindingMode, converter, bindingSource);
public static T IsLightDismissEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.VerticalOffsetProperty, binding);
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.VerticalOffsetProperty, func, onChanged, expression);
public static T VerticalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static T VerticalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Topmost<T>(this T control, IBinding binding) where T : Popup
   => control._set(Popup.TopmostProperty, binding);
public static T Topmost<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Popup
   => control._set(Popup.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Topmost<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Popup
   => control._set(Popup.TopmostProperty, func, onChanged, expression);
public static T Topmost<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);
public static T Topmost<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Popup
=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

