#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ContextMenu_MarkupExtensions
{
//================= Properties ======================//
 // HorizontalOffset

/*BindFromExpressionSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalOffset

/*BindFromExpressionSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementAnchor

/*BindFromExpressionSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementAnchor<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementAnchor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementConstraintAdjustment

/*BindFromExpressionSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementConstraintAdjustment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementGravity

/*BindFromExpressionSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementGravity<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementGravity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Placement

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Placement<T>(this T control,Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Placement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementRect

/*BindFromExpressionSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementRect<T>(this T control,System.Nullable<Avalonia.Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementRect<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementRect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<Avalonia.Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // WindowManagerAddShadowHint

/*BindFromExpressionSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T WindowManagerAddShadowHint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementTarget

/*BindFromExpressionSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementTarget<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementTarget<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementTarget<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CustomPopupPlacementCallback

/*BindFromExpressionSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, ps, () => control.CustomPopupPlacementCallback = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ContextMenu 
   => control._set(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CustomPopupPlacementCallback<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ContextMenu 
=> control._setEx(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, ps, () => control.CustomPopupPlacementCallback = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.ContextMenu  => 
 control._setEvent((System.ComponentModel.CancelEventHandler) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu 
=> style._addSetter(Avalonia.Controls.ContextMenu.CustomPopupPlacementCallbackProperty, binding);



}
