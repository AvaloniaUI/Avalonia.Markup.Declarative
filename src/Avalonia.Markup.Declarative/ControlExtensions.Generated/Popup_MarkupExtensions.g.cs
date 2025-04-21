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
public static partial class Popup_MarkupExtensions
{
//================= Properties ======================//
 // WindowManagerAddShadowHint

/*BindFromExpressionSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T WindowManagerAddShadowHint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Child

/*BindFromExpressionSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Child<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Child<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InheritsTransform

/*BindFromExpressionSetterGenerator*/
public static T InheritsTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InheritsTransform<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InheritsTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InheritsTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InheritsTransform<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsOpen

/*BindFromExpressionSetterGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsOpenProperty, ps, () => control.IsOpen = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementAnchor

/*BindFromExpressionSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementAnchor<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementAnchor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementConstraintAdjustment

/*BindFromExpressionSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementConstraintAdjustment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementGravity

/*BindFromExpressionSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementGravity<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementGravity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Placement

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Placement<T>(this T control,Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Placement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementRect

/*BindFromExpressionSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementRect<T>(this T control,System.Nullable<Avalonia.Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementRect<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementRect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<Avalonia.Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementTarget

/*BindFromExpressionSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementTarget<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementTarget<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementTarget<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CustomPopupPlacementCallback

/*BindFromExpressionSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, ps, () => control.CustomPopupPlacementCallback = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CustomPopupPlacementCallback<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, ps, () => control.CustomPopupPlacementCallback = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OverlayDismissEventPassThrough

/*BindFromExpressionSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OverlayDismissEventPassThrough<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OverlayInputPassThroughElement

/*BindFromExpressionSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control,Avalonia.Input.IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OverlayInputPassThroughElement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalOffset

/*BindFromExpressionSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsLightDismissEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsLightDismissEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalOffset

/*BindFromExpressionSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Topmost

/*BindFromExpressionSetterGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Topmost<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Topmost<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Topmost<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Topmost<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TakesFocusFromNativeControl

/*BindFromExpressionSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, ps, () => control.TakesFocusFromNativeControl = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TakesFocusFromNativeControl<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TakesFocusFromNativeControl<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.Popup 
=> control._setEx(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, ps, () => control.TakesFocusFromNativeControl = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // TakesFocusFromNativeControl

/*AttachedPropertyMagicalSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, ps, () => Avalonia.Controls.Primitives.Popup.SetTakesFocusFromNativeControl(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Popup_TakesFocusFromNativeControl<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, func, onChanged, expression);



//================= Events ======================//
 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);



//================= Styles ======================//
 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);


 // InheritsTransform

/*ValueStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);


 // PlacementAnchor

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustment

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravity

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);


 // PlacementRect

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);


 // PlacementTarget

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);


 // CustomPopupPlacementCallback

/*ValueStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomPopupPlacementCallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty, binding);


 // OverlayDismissEventPassThrough

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);


 // OverlayInputPassThroughElement

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);


 // HorizontalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);


 // IsLightDismissEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);


 // VerticalOffset

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);


 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);


 // TakesFocusFromNativeControl

/*ValueStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TakesFocusFromNativeControl<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup 
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TakesFocusFromNativeControlProperty, binding);



}
