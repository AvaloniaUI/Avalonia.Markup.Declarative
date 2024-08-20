#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Geometry_MarkupExtensions
{
//================= Properties ======================//
 // TransformProperty

/*BindFromExpressionSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Geometry
   => control._set(Avalonia.Media.Geometry.TransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Transform<T>(this T control, Avalonia.Media.Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Geometry
=> control._setEx(Avalonia.Media.Geometry.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Media.Geometry
   => control._set(Avalonia.Media.Geometry.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Geometry
   => control._set(Avalonia.Media.Geometry.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Transform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Geometry
=> control._setEx(Avalonia.Media.Geometry.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Changed

/*ActionToEventGenerator*/
    public static T OnChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Geometry => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Changed += h);



//================= Styles ======================//

}
