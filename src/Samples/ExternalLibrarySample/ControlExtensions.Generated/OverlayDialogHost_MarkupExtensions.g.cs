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
public static partial class OverlayDialogHost_MarkupExtensions
{
//================= Properties ======================//
 // IsInModalStatus

/*ValueSetterGenerator*/
public static T IsInModalStatus<T>(this T control, System.Boolean value) where T : Ursa.Controls.OverlayDialogHost 
=> control._set(() => control.IsInModalStatus = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsInModalStatus<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsInModalStatus<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayDialogHost 
=> control._setEx(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty, ps, () => control.IsInModalStatus = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsInModalStatus<T>(this T control, IBinding binding) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsInModalStatus<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsInModalStatus<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayDialogHost 
=> control._setEx(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty, ps, () => control.IsInModalStatus = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsModalStatusReporter

/*ValueSetterGenerator*/
public static T IsModalStatusReporter<T>(this T control, System.Boolean value) where T : Ursa.Controls.OverlayDialogHost 
=> control._set(() => control.IsModalStatusReporter = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsModalStatusReporter<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsModalStatusReporter<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayDialogHost 
=> control._setEx(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty, ps, () => control.IsModalStatusReporter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsModalStatusReporter<T>(this T control, IBinding binding) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsModalStatusReporter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsModalStatusReporter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayDialogHost 
=> control._setEx(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty, ps, () => control.IsModalStatusReporter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OverlayMaskBrush

/*ValueSetterGenerator*/
public static T OverlayMaskBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.OverlayDialogHost 
=> control._set(() => control.OverlayMaskBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T OverlayMaskBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OverlayMaskBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayDialogHost 
=> control._setEx(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty, ps, () => control.OverlayMaskBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OverlayMaskBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OverlayMaskBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.OverlayDialogHost 
   => control._set(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OverlayMaskBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayDialogHost 
=> control._setEx(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty, ps, () => control.OverlayMaskBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // IsModalStatusScope

/*AttachedPropertyMagicalSetterGenerator*/
public static T OverlayDialogHost_IsModalStatusScope<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Ursa.Controls.OverlayDialogHost.IsModalStatusScopeProperty, ps, () => Ursa.Controls.OverlayDialogHost.SetIsModalStatusScope(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T OverlayDialogHost_IsModalStatusScope<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Ursa.Controls.OverlayDialogHost.IsModalStatusScopeProperty!, func, onChanged, expression);



//================= Styles ======================//
 // IsInModalStatus

/*ValueStyleSetterGenerator*/
public static Style<T> IsInModalStatus<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.OverlayDialogHost 
=> style._addSetter(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsInModalStatus<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.OverlayDialogHost 
=> style._addSetter(Ursa.Controls.OverlayDialogHost.IsInModalStatusProperty, binding);


 // IsModalStatusReporter

/*ValueStyleSetterGenerator*/
public static Style<T> IsModalStatusReporter<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.OverlayDialogHost 
=> style._addSetter(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsModalStatusReporter<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.OverlayDialogHost 
=> style._addSetter(Ursa.Controls.OverlayDialogHost.IsModalStatusReporterProperty, binding);


 // OverlayMaskBrush

/*ValueStyleSetterGenerator*/
public static Style<T> OverlayMaskBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.OverlayDialogHost 
=> style._addSetter(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OverlayMaskBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.OverlayDialogHost 
=> style._addSetter(Ursa.Controls.OverlayDialogHost.OverlayMaskBrushProperty, binding);



}
