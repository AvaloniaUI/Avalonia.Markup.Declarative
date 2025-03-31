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
public static partial class ToolTip_MarkupExtensions
{
//================= Attached Properties ======================//
 // Tip

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_Tip<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.TipProperty, ps, () => Avalonia.Controls.ToolTip.SetTip(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_Tip<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.TipProperty, func, onChanged, expression);


 // IsOpen

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_IsOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.IsOpenProperty, ps, () => Avalonia.Controls.ToolTip.SetIsOpen(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.IsOpenProperty, func, onChanged, expression);


 // Placement

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_Placement<T>(this T control, Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.PlacementProperty, ps, () => Avalonia.Controls.ToolTip.SetPlacement(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.PlacementProperty, func, onChanged, expression);


 // HorizontalOffset

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.HorizontalOffsetProperty, ps, () => Avalonia.Controls.ToolTip.SetHorizontalOffset(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_HorizontalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.HorizontalOffsetProperty, func, onChanged, expression);


 // VerticalOffset

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.VerticalOffsetProperty, ps, () => Avalonia.Controls.ToolTip.SetVerticalOffset(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_VerticalOffset<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.VerticalOffsetProperty, func, onChanged, expression);


 // CustomPopupPlacementCallback

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty, ps, () => Avalonia.Controls.ToolTip.SetCustomPopupPlacementCallback(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_CustomPopupPlacementCallback<T>(this T control, Func<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback> func, Action<Avalonia.Controls.Primitives.PopupPositioning.CustomPopupPlacementCallback>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.CustomPopupPlacementCallbackProperty, func, onChanged, expression);


 // ShowDelay

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.ShowDelayProperty, ps, () => Avalonia.Controls.ToolTip.SetShowDelay(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_ShowDelay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowDelayProperty, func, onChanged, expression);


 // BetweenShowDelay

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.BetweenShowDelayProperty, ps, () => Avalonia.Controls.ToolTip.SetBetweenShowDelay(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_BetweenShowDelay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.BetweenShowDelayProperty, func, onChanged, expression);


 // ShowOnDisabled

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.ShowOnDisabledProperty, ps, () => Avalonia.Controls.ToolTip.SetShowOnDisabled(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_ShowOnDisabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ShowOnDisabledProperty, func, onChanged, expression);


 // ServiceEnabled

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.ServiceEnabledProperty, ps, () => Avalonia.Controls.ToolTip.SetServiceEnabled(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolTip_ServiceEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ToolTip.ServiceEnabledProperty, func, onChanged, expression);



}
