#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AdornerLayer_MarkupExtensions
{
//================= Properties ======================//
 // DefaultFocusAdornerProperty

/*BindFromExpressionSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.AdornerLayer
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.AdornerLayer
=> control._setEx(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultFocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.AdornerLayer
   => control._set(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DefaultFocusAdorner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.AdornerLayer
=> control._setEx(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // DefaultFocusAdornerProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Primitives.AdornerLayer
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultFocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.AdornerLayer
=> style._addSetter(Avalonia.Controls.Primitives.AdornerLayer.DefaultFocusAdornerProperty, binding);



}
