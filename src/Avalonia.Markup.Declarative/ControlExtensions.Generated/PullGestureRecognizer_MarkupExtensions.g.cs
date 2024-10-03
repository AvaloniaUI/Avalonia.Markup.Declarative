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
public static partial class PullGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // PullDirection

/*BindFromExpressionSetterGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PullDirection<T>(this T control,Avalonia.Input.PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.PullGestureRecognizer 
=> control._setEx(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PullDirection<T>(this T control, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.PullGestureRecognizer 
   => control._set(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PullDirection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.PullGestureRecognizer 
=> control._setEx(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer 
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);



}
