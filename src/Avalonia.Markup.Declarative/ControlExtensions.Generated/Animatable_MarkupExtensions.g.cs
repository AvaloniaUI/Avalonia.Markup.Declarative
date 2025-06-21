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
public static partial class Animatable_MarkupExtensions
{
//================= Properties ======================//
 // Transitions

/*ValueSetterGenerator*/
public static T Transitions<T>(this T control, Avalonia.Animation.Transitions value) where T : Avalonia.Animation.Animatable 
=> control._set(() => control.Transitions = value!);

/*BindFromExpressionSetterGenerator*/
public static T Transitions<T>(this T control, Func<Avalonia.Animation.Transitions> func, Action<Avalonia.Animation.Transitions>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Transitions<T>(this T control,Avalonia.Animation.Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Animation.Animatable 
=> control._setEx(Avalonia.Animation.Animatable.TransitionsProperty, ps, () => control.Transitions = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Transitions<T>(this T control, IBinding binding) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transitions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.Animatable 
   => control._set(Avalonia.Animation.Animatable.TransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Transitions<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Animation.Animatable 
=> control._setEx(Avalonia.Animation.Animatable.TransitionsProperty, ps, () => control.Transitions = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
