#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class AdornerLayer_MarkupExtensions
{
//================= Properties ======================//
 // DefaultFocusAdorner

/*BindFromExpressionSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control,Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> control._setEx(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.AdornerLayer 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DefaultFocusAdorner<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> control._setEx(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // AdornedElement

/*AttachedPropertyMagicalSetterGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, Avalonia.Visual value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
 => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty, ps, () => Avalonia.Controls.Primitives.AdornerLayer.SetAdornedElement(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T AdornerLayer_AdornedElement<T>(this T control, Func<Avalonia.Visual> func, Action<Avalonia.Visual>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornedElementProperty, func, onChanged, expression);


 // IsClipEnabled

/*AttachedPropertyMagicalSetterGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
 => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty, ps, () => Avalonia.Controls.Primitives.AdornerLayer.SetIsClipEnabled(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T AdornerLayer_IsClipEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.IsClipEnabledProperty, func, onChanged, expression);


 // Adorner

/*AttachedPropertyMagicalSetterGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
 => control._setEx(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty, ps, () => Avalonia.Controls.Primitives.AdornerLayer.SetAdorner(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T AdornerLayer_Adorner<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.AdornerProperty, func, onChanged, expression);



//================= Styles ======================//
 // DefaultFocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer 
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);



}
