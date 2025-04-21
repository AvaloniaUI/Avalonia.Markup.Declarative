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
public static partial class PopupFlyoutBase_MarkupExtensions
{
//================= Properties ======================//
 // Placement

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Placement<T>(this T control,Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Placement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalOffset

/*BindFromExpressionSetterGenerator*/
public static T HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalOffset

/*BindFromExpressionSetterGenerator*/
public static T VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalOffset<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalOffset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalOffset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementAnchor

/*BindFromExpressionSetterGenerator*/
public static T PlacementAnchor<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementAnchor<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementAnchor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementGravity

/*BindFromExpressionSetterGenerator*/
public static T PlacementGravity<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupGravity>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementGravity<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementGravity<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementGravity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CustomPopupPlacementCallback

/*BindFromExpressionSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty, ps, () => control.CustomPopupPlacementCallback = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomPopupPlacementCallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CustomPopupPlacementCallback<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.CustomPopupPlacementCallbackProperty, ps, () => control.CustomPopupPlacementCallback = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ShowMode

/*BindFromExpressionSetterGenerator*/
public static T ShowMode<T>(this T control, Func<Avalonia.Controls.FlyoutShowMode> func, Action<Avalonia.Controls.FlyoutShowMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowMode<T>(this T control,Avalonia.Controls.FlyoutShowMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.FlyoutShowMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OverlayDismissEventPassThrough

/*BindFromExpressionSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayDismissEventPassThrough<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OverlayDismissEventPassThrough<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OverlayInputPassThroughElement

/*BindFromExpressionSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control,Avalonia.Input.IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OverlayInputPassThroughElement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PlacementConstraintAdjustment

/*BindFromExpressionSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> func, Action<Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control,Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlacementConstraintAdjustment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
   => control._set(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PlacementConstraintAdjustment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.PopupFlyoutBase 
=> control._setEx(Avalonia.Controls.Primitives.PopupFlyoutBase.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.Primitives.PopupFlyoutBase  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);


 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PopupFlyoutBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opening += h);



}
