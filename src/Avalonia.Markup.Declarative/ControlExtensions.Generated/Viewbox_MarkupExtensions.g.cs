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
public static partial class Viewbox_MarkupExtensions
{
//================= Properties ======================//
 // Stretch

/*ValueSetterGenerator*/
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox 
=> control._set(() => control.Stretch = value!);

/*BindFromExpressionSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Stretch<T>(this T control,Avalonia.Media.Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Viewbox 
=> control._setEx(Avalonia.Controls.Viewbox.StretchProperty, ps, () => control.Stretch = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Stretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Viewbox 
=> control._setEx(Avalonia.Controls.Viewbox.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // StretchDirection

/*ValueSetterGenerator*/
public static T StretchDirection<T>(this T control, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox 
=> control._set(() => control.StretchDirection = value!);

/*BindFromExpressionSetterGenerator*/
public static T StretchDirection<T>(this T control, Func<Avalonia.Media.StretchDirection> func, Action<Avalonia.Media.StretchDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchDirectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StretchDirection<T>(this T control,Avalonia.Media.StretchDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Viewbox 
=> control._setEx(Avalonia.Controls.Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StretchDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StretchDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.StretchDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StretchDirection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.StretchDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Viewbox 
=> control._setEx(Avalonia.Controls.Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Child

/*ValueSetterGenerator*/
public static T Child<T>(this T control, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox 
=> control._set(() => control.Child = value!);

/*BindFromExpressionSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.ChildProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Child<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Viewbox 
=> control._setEx(Avalonia.Controls.Viewbox.ChildProperty, ps, () => control.Child = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.ChildProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Viewbox 
   => control._set(Avalonia.Controls.Viewbox.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Child<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Viewbox 
=> control._setEx(Avalonia.Controls.Viewbox.ChildProperty, ps, () => control.Child = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Stretch

/*ValueStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty, binding);


 // StretchDirection

/*ValueStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty, binding);


 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox 
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty, binding);



}
