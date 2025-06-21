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
public static partial class TimelineItemTypeToIconForegroundConverter_MarkupExtensions
{
//================= Properties ======================//
 // DefaultBrush

/*ValueSetterGenerator*/
public static T DefaultBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._set(() => control.DefaultBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T DefaultBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DefaultBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, ps, () => control.DefaultBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DefaultBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.DefaultBrushProperty, ps, () => control.DefaultBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OngoingBrush

/*ValueSetterGenerator*/
public static T OngoingBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._set(() => control.OngoingBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T OngoingBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OngoingBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, ps, () => control.OngoingBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OngoingBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OngoingBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OngoingBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.OngoingBrushProperty, ps, () => control.OngoingBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SuccessBrush

/*ValueSetterGenerator*/
public static T SuccessBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._set(() => control.SuccessBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T SuccessBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SuccessBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, ps, () => control.SuccessBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SuccessBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SuccessBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SuccessBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.SuccessBrushProperty, ps, () => control.SuccessBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // WarningBrush

/*ValueSetterGenerator*/
public static T WarningBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._set(() => control.WarningBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T WarningBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T WarningBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, ps, () => control.WarningBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WarningBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WarningBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T WarningBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.WarningBrushProperty, ps, () => control.WarningBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ErrorBrush

/*ValueSetterGenerator*/
public static T ErrorBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._set(() => control.ErrorBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T ErrorBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ErrorBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, ps, () => control.ErrorBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ErrorBrush<T>(this T control, IBinding binding) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ErrorBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
   => control._set(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ErrorBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter 
=> control._setEx(Ursa.Themes.Semi.Converters.TimelineItemTypeToIconForegroundConverter.ErrorBrushProperty, ps, () => control.ErrorBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
