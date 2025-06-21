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
public static partial class Avatar_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*ValueSetterGenerator*/
public static T Source<T>(this T control, Avalonia.Media.IImage value) where T : Ursa.Controls.Avatar 
=> control._set(() => control.Source = value!);

/*BindFromExpressionSetterGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Avatar 
   => control._set(Ursa.Controls.Avatar.SourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Source<T>(this T control,Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Avatar 
=> control._setEx(Ursa.Controls.Avatar.SourceProperty, ps, () => control.Source = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Source<T>(this T control, IBinding binding) where T : Ursa.Controls.Avatar 
   => control._set(Ursa.Controls.Avatar.SourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Source<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Avatar 
   => control._set(Ursa.Controls.Avatar.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Source<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Avatar 
=> control._setEx(Ursa.Controls.Avatar.SourceProperty, ps, () => control.Source = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HoverMask

/*ValueSetterGenerator*/
public static T HoverMask<T>(this T control, System.Object value) where T : Ursa.Controls.Avatar 
=> control._set(() => control.HoverMask = value!);

/*BindFromExpressionSetterGenerator*/
public static T HoverMask<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Avatar 
   => control._set(Ursa.Controls.Avatar.HoverMaskProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HoverMask<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Avatar 
=> control._setEx(Ursa.Controls.Avatar.HoverMaskProperty, ps, () => control.HoverMask = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HoverMask<T>(this T control, IBinding binding) where T : Ursa.Controls.Avatar 
   => control._set(Ursa.Controls.Avatar.HoverMaskProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HoverMask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Avatar 
   => control._set(Ursa.Controls.Avatar.HoverMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HoverMask<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Avatar 
=> control._setEx(Ursa.Controls.Avatar.HoverMaskProperty, ps, () => control.HoverMask = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Source

/*ValueStyleSetterGenerator*/
public static Style<T> Source<T>(this Style<T> style, Avalonia.Media.IImage value) where T : Ursa.Controls.Avatar 
=> style._addSetter(Ursa.Controls.Avatar.SourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Source<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Avatar 
=> style._addSetter(Ursa.Controls.Avatar.SourceProperty, binding);


 // HoverMask

/*ValueStyleSetterGenerator*/
public static Style<T> HoverMask<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.Avatar 
=> style._addSetter(Ursa.Controls.Avatar.HoverMaskProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HoverMask<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Avatar 
=> style._addSetter(Ursa.Controls.Avatar.HoverMaskProperty, binding);



}
