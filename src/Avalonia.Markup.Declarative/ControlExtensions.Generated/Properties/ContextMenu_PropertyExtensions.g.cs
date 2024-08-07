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
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu HorizontalOffset<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu VerticalOffset<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, Func<PopupAnchor> func, Action<PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementAnchor<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, Func<PopupPositionerConstraintAdjustment> func, Action<PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, Func<PopupGravity> func, Action<PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementGravity<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, binding);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, Func<PlacementMode> func, Action<PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu Placement<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, Func<Nullable<Rect>> func, Action<Nullable<Rect>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, Nullable<Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementRect<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Nullable<Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, func, onChanged, expression);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementTarget<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

