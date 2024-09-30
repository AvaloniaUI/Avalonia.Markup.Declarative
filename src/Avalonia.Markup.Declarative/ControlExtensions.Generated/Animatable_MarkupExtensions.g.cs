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
public static partial class Animatable_MarkupExtensions
{
//================= Properties ======================//
 // Transitions

/*BindFromExpressionSetterGenerator*/
public static T Transitions<T>(this T control, Func<Avalonia.Animation.Transitions> func, Action<Avalonia.Animation.Transitions>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Animation.Animatable Transitions<T>(this T control,Avalonia.Animation.Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.Animatable=> control._setEx(Avalonia.Animation.Animatable.TransitionsProperty, ps, () => control.Transitions = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Transitions<T>(this T control, IBinding binding) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transitions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Transitions<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.Animatable=> control._setEx(Avalonia.Animation.Animatable.TransitionsProperty, ps, () => control.Transitions = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
