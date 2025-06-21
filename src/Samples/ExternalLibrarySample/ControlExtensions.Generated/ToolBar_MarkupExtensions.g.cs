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
public static partial class ToolBar_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Ursa.Controls.ToolBar 
=> control._set(() => control.Orientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ToolBar 
   => control._set(Ursa.Controls.ToolBar.OrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ToolBar 
=> control._setEx(Ursa.Controls.ToolBar.OrientationProperty, ps, () => control.Orientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Ursa.Controls.ToolBar 
   => control._set(Ursa.Controls.ToolBar.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ToolBar 
   => control._set(Ursa.Controls.ToolBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ToolBar 
=> control._setEx(Ursa.Controls.ToolBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupPlacement

/*ValueSetterGenerator*/
public static T PopupPlacement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Ursa.Controls.ToolBar 
=> control._set(() => control.PopupPlacement = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupPlacement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ToolBar 
   => control._set(Ursa.Controls.ToolBar.PopupPlacementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupPlacement<T>(this T control,Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ToolBar 
=> control._setEx(Ursa.Controls.ToolBar.PopupPlacementProperty, ps, () => control.PopupPlacement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupPlacement<T>(this T control, IBinding binding) where T : Ursa.Controls.ToolBar 
   => control._set(Ursa.Controls.ToolBar.PopupPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ToolBar 
   => control._set(Ursa.Controls.ToolBar.PopupPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupPlacement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ToolBar 
=> control._setEx(Ursa.Controls.ToolBar.PopupPlacementProperty, ps, () => control.PopupPlacement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // OverflowMode

/*AttachedPropertyMagicalSetterGenerator*/
public static T ToolBar_OverflowMode<T>(this T control, Ursa.Controls.OverflowMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Ursa.Controls.ToolBar.OverflowModeProperty, ps, () => Ursa.Controls.ToolBar.SetOverflowMode(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ToolBar_OverflowMode<T>(this T control, Func<Ursa.Controls.OverflowMode> func, Action<Ursa.Controls.OverflowMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Ursa.Controls.ToolBar.OverflowModeProperty!, func, onChanged, expression);



//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Ursa.Controls.ToolBar 
=> style._addSetter(Ursa.Controls.ToolBar.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ToolBar 
=> style._addSetter(Ursa.Controls.ToolBar.OrientationProperty, binding);


 // PopupPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> PopupPlacement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Ursa.Controls.ToolBar 
=> style._addSetter(Ursa.Controls.ToolBar.PopupPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupPlacement<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ToolBar 
=> style._addSetter(Ursa.Controls.ToolBar.PopupPlacementProperty, binding);



}
