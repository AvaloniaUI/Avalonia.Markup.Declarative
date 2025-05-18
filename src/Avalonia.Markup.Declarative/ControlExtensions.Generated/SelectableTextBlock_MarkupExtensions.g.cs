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
public static partial class SelectableTextBlock_MarkupExtensions
{
//================= Properties ======================//
 // SelectionStart

/*ValueSetterGenerator*/
public static T SelectionStart<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionStart = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionStart<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionStart<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionEnd

/*ValueSetterGenerator*/
public static T SelectionEnd<T>(this T control, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionEnd = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionEnd<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionEnd<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionBrush

/*ValueSetterGenerator*/
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionForegroundBrush

/*ValueSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> control._set(() => control.SelectionForegroundBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionForegroundBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock 
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionForegroundBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock 
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // CopyingToClipboard

/*ActionToEventGenerator*/
public static T OnCopyingToClipboard<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.SelectableTextBlock 
{
  control.AddHandler(Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent, (_, args) => action(args), routes ?? Avalonia.Controls.SelectableTextBlock.CopyingToClipboardEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // SelectionStart

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, binding);


 // SelectionEnd

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, binding);


 // SelectionBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, binding);


 // SelectionForegroundBrush

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionForegroundBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock 
=> style._addSetter(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, binding);



}
