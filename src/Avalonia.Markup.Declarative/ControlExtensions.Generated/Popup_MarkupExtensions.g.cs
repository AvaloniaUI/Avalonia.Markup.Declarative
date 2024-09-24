#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Popup_MarkupExtensions
{
//================= Properties ======================//
 // WindowManagerAddShadowHintProperty

/*BindFromExpressionSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowManagerAddShadowHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T WindowManagerAddShadowHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ChildProperty

/*BindFromExpressionSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Child<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InheritsTransformProperty

/*BindFromExpressionSetterGenerator*/
public static T InheritsTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InheritsTransform<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InheritsTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InheritsTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InheritsTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsOpenProperty

/*BindFromExpressionSetterGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsOpenProperty, ps, () => control.IsOpen = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementAnchorProperty

/*BindFromExpressionSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementAnchor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementConstraintAdjustmentProperty

/*BindFromExpressionSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementConstraintAdjustment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementGravityProperty

/*BindFromExpressionSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementGravity<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementGravity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementProperty

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementRectProperty

/*BindFromExpressionSetterGenerator*/
public static T PlacementRect<T>(this T control, Func<System.Nullable<Avalonia.Rect>> func, Action<System.Nullable<Avalonia.Rect>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementRect<T>(this T control, System.Nullable<Avalonia.Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementRect<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<Avalonia.Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementTargetProperty

/*BindFromExpressionSetterGenerator*/
public static T PlacementTarget<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementTarget<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementTarget<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementTarget<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementTarget<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OverlayDismissEventPassThroughProperty

/*BindFromExpressionSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OverlayDismissEventPassThrough<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OverlayInputPassThroughElementProperty

/*BindFromExpressionSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Avalonia.Input.IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OverlayInputPassThroughElement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalOffsetProperty

/*BindFromExpressionSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsLightDismissEnabledProperty

/*BindFromExpressionSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsLightDismissEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsLightDismissEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalOffsetProperty

/*BindFromExpressionSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TopmostProperty

/*BindFromExpressionSetterGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Topmost<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Topmost<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Topmost<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Popup
   => control._set(Avalonia.Controls.Primitives.Popup.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Topmost<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Popup
=> control._setEx(Avalonia.Controls.Primitives.Popup.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Closed

/*ActionToEventGenerator*/
    public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup => 
        control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // Opened

/*ActionToEventGenerator*/
    public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.Popup => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);



//================= Styles ======================//
 // WindowManagerAddShadowHintProperty

/*ValueStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);


 // ChildProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);


 // InheritsTransformProperty

/*ValueStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);


 // IsOpenProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);


 // PlacementAnchorProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);


 // PlacementConstraintAdjustmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);


 // PlacementGravityProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);


 // PlacementProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);


 // PlacementRectProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);


 // PlacementTargetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);


 // OverlayDismissEventPassThroughProperty

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);


 // OverlayInputPassThroughElementProperty

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);


 // HorizontalOffsetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);


 // IsLightDismissEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);


 // VerticalOffsetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);


 // TopmostProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);



}