#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContextMenuExtensions
{
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.HorizontalOffsetProperty, binding);
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.HorizontalOffsetProperty, func, onChanged, expression);
public static T HorizontalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static T HorizontalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalOffset<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.VerticalOffsetProperty, binding);
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalOffset<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.VerticalOffsetProperty, func, onChanged, expression);
public static T VerticalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static T VerticalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.PlacementAnchorProperty, binding);
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementAnchor<T>(this T control, Func<PopupAnchor> func, Action<PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementAnchorProperty, func, onChanged, expression);
public static T PlacementAnchor<T>(this T control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static T PlacementAnchor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.PlacementConstraintAdjustmentProperty, binding);
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementConstraintAdjustment<T>(this T control, Func<PopupPositionerConstraintAdjustment> func, Action<PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementConstraintAdjustmentProperty, func, onChanged, expression);
public static T PlacementConstraintAdjustment<T>(this T control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static T PlacementConstraintAdjustment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementGravity<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.PlacementGravityProperty, binding);
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementGravity<T>(this T control, Func<PopupGravity> func, Action<PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementGravityProperty, func, onChanged, expression);
public static T PlacementGravity<T>(this T control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static T PlacementGravity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Placement<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.PlacementProperty, binding);
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Placement<T>(this T control, Func<PlacementMode> func, Action<PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementProperty, func, onChanged, expression);
public static T Placement<T>(this T control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementRect<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.PlacementRectProperty, binding);
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementRect<T>(this T control, Func<Nullable<Rect>> func, Action<Nullable<Rect>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementRectProperty, func, onChanged, expression);
public static T PlacementRect<T>(this T control, Nullable<Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);
public static T PlacementRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.WindowManagerAddShadowHintProperty, binding);
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WindowManagerAddShadowHint<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.WindowManagerAddShadowHintProperty, func, onChanged, expression);
public static T WindowManagerAddShadowHint<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static T WindowManagerAddShadowHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementTarget<T>(this T control, IBinding binding) where T : ContextMenu
   => control._set(ContextMenu.PlacementTargetProperty, binding);
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlacementTarget<T>(this T control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContextMenu
   => control._set(ContextMenu.PlacementTargetProperty, func, onChanged, expression);
public static T PlacementTarget<T>(this T control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);
public static T PlacementTarget<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContextMenu
=> control._setEx(ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

