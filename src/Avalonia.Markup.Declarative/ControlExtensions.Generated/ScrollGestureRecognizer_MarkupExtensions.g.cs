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
public static partial class ScrollGestureRecognizer_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*BindFromExpressionSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CanHorizontallyScroll<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CanVerticallyScroll

/*BindFromExpressionSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CanVerticallyScroll<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsScrollInertiaEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsScrollInertiaEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ScrollStartDistance

/*BindFromExpressionSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ScrollStartDistance<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, IBinding binding) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ScrollStartDistance<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
   => control._set(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ScrollStartDistance<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer 
=> control._setEx(Avalonia.Input.GestureRecognizers.ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
