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
public static Popup WindowManagerAddShadowHint(this Popup control, IBinding binding)
   => control._set(Popup.WindowManagerAddShadowHintProperty, binding);
public static Popup WindowManagerAddShadowHint(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup WindowManagerAddShadowHint(this Popup control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.WindowManagerAddShadowHintProperty, func, onChanged, expression);
public static Popup WindowManagerAddShadowHint(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static Popup WindowManagerAddShadowHint<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup Child(this Popup control, IBinding binding)
   => control._set(Popup.ChildProperty, binding);
public static Popup Child(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup Child(this Popup control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.ChildProperty, func, onChanged, expression);
public static Popup Child(this Popup control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static Popup Child<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup InheritsTransform(this Popup control, IBinding binding)
   => control._set(Popup.InheritsTransformProperty, binding);
public static Popup InheritsTransform(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.InheritsTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup InheritsTransform(this Popup control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.InheritsTransformProperty, func, onChanged, expression);
public static Popup InheritsTransform(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = value, bindingMode, converter, bindingSource);
public static Popup InheritsTransform<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup IsOpen(this Popup control, IBinding binding)
   => control._set(Popup.IsOpenProperty, binding);
public static Popup IsOpen(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup IsOpen(this Popup control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.IsOpenProperty, func, onChanged, expression);
public static Popup IsOpen(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = value, bindingMode, converter, bindingSource);
public static Popup IsOpen<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementAnchor(this Popup control, IBinding binding)
   => control._set(Popup.PlacementAnchorProperty, binding);
public static Popup PlacementAnchor(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup PlacementAnchor(this Popup control, Func<PopupAnchor> func, Action<PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementAnchorProperty, func, onChanged, expression);
public static Popup PlacementAnchor(this Popup control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static Popup PlacementAnchor<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementConstraintAdjustment(this Popup control, IBinding binding)
   => control._set(Popup.PlacementConstraintAdjustmentProperty, binding);
public static Popup PlacementConstraintAdjustment(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup PlacementConstraintAdjustment(this Popup control, Func<PopupPositionerConstraintAdjustment> func, Action<PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementConstraintAdjustmentProperty, func, onChanged, expression);
public static Popup PlacementConstraintAdjustment(this Popup control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static Popup PlacementConstraintAdjustment<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementGravity(this Popup control, IBinding binding)
   => control._set(Popup.PlacementGravityProperty, binding);
public static Popup PlacementGravity(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup PlacementGravity(this Popup control, Func<PopupGravity> func, Action<PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementGravityProperty, func, onChanged, expression);
public static Popup PlacementGravity(this Popup control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static Popup PlacementGravity<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup Placement(this Popup control, IBinding binding)
   => control._set(Popup.PlacementProperty, binding);
public static Popup Placement(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup Placement(this Popup control, Func<PlacementMode> func, Action<PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementProperty, func, onChanged, expression);
public static Popup Placement(this Popup control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static Popup Placement<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementRect(this Popup control, IBinding binding)
   => control._set(Popup.PlacementRectProperty, binding);
public static Popup PlacementRect(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup PlacementRect(this Popup control, Func<Nullable<Rect>> func, Action<Nullable<Rect>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementRectProperty, func, onChanged, expression);
public static Popup PlacementRect(this Popup control, Nullable<Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);
public static Popup PlacementRect<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Nullable<Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementTarget(this Popup control, IBinding binding)
   => control._set(Popup.PlacementTargetProperty, binding);
public static Popup PlacementTarget(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup PlacementTarget(this Popup control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementTargetProperty, func, onChanged, expression);
public static Popup PlacementTarget(this Popup control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);
public static Popup PlacementTarget<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup OverlayDismissEventPassThrough(this Popup control, IBinding binding)
   => control._set(Popup.OverlayDismissEventPassThroughProperty, binding);
public static Popup OverlayDismissEventPassThrough(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup OverlayDismissEventPassThrough(this Popup control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.OverlayDismissEventPassThroughProperty, func, onChanged, expression);
public static Popup OverlayDismissEventPassThrough(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value, bindingMode, converter, bindingSource);
public static Popup OverlayDismissEventPassThrough<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup OverlayInputPassThroughElement(this Popup control, IBinding binding)
   => control._set(Popup.OverlayInputPassThroughElementProperty, binding);
public static Popup OverlayInputPassThroughElement(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup OverlayInputPassThroughElement(this Popup control, Func<IInputElement> func, Action<IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.OverlayInputPassThroughElementProperty, func, onChanged, expression);
public static Popup OverlayInputPassThroughElement(this Popup control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);
public static Popup OverlayInputPassThroughElement<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup HorizontalOffset(this Popup control, IBinding binding)
   => control._set(Popup.HorizontalOffsetProperty, binding);
public static Popup HorizontalOffset(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup HorizontalOffset(this Popup control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.HorizontalOffsetProperty, func, onChanged, expression);
public static Popup HorizontalOffset(this Popup control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static Popup HorizontalOffset<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup IsLightDismissEnabled(this Popup control, IBinding binding)
   => control._set(Popup.IsLightDismissEnabledProperty, binding);
public static Popup IsLightDismissEnabled(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.IsLightDismissEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup IsLightDismissEnabled(this Popup control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.IsLightDismissEnabledProperty, func, onChanged, expression);
public static Popup IsLightDismissEnabled(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = value, bindingMode, converter, bindingSource);
public static Popup IsLightDismissEnabled<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup VerticalOffset(this Popup control, IBinding binding)
   => control._set(Popup.VerticalOffsetProperty, binding);
public static Popup VerticalOffset(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup VerticalOffset(this Popup control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.VerticalOffsetProperty, func, onChanged, expression);
public static Popup VerticalOffset(this Popup control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static Popup VerticalOffset<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup Topmost(this Popup control, IBinding binding)
   => control._set(Popup.TopmostProperty, binding);
public static Popup Topmost(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Popup.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Popup Topmost(this Popup control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.TopmostProperty, func, onChanged, expression);
public static Popup Topmost(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);
public static Popup Topmost<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

