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
public static partial class DateTimePicker_MarkupExtensions
{
//================= Properties ======================//
 // SelectedDate

/*ValueSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Ursa.Controls.DateTimePicker 
=> control._set(() => control.SelectedDate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.SelectedDateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedDate<T>(this T control,System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.SelectedDateProperty, ps, () => control.SelectedDate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedDate<T>(this T control, IBinding binding) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.SelectedDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedDate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Ursa.Controls.DateTimePicker 
=> control._set(() => control.Watermark = value!);

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.WatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.WatermarkProperty, ps, () => control.Watermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PanelFormat

/*ValueSetterGenerator*/
public static T PanelFormat<T>(this T control, System.String value) where T : Ursa.Controls.DateTimePicker 
=> control._set(() => control.PanelFormat = value!);

/*BindFromExpressionSetterGenerator*/
public static T PanelFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.PanelFormatProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PanelFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.PanelFormatProperty, ps, () => control.PanelFormat = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PanelFormat<T>(this T control, IBinding binding) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.PanelFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PanelFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.PanelFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PanelFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.PanelFormatProperty, ps, () => control.PanelFormat = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // NeedConfirmation

/*ValueSetterGenerator*/
public static T NeedConfirmation<T>(this T control, System.Boolean value) where T : Ursa.Controls.DateTimePicker 
=> control._set(() => control.NeedConfirmation = value!);

/*BindFromExpressionSetterGenerator*/
public static T NeedConfirmation<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.NeedConfirmationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T NeedConfirmation<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.NeedConfirmationProperty, ps, () => control.NeedConfirmation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NeedConfirmation<T>(this T control, IBinding binding) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.NeedConfirmationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NeedConfirmation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateTimePicker 
   => control._set(Ursa.Controls.DateTimePicker.NeedConfirmationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T NeedConfirmation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateTimePicker 
=> control._setEx(Ursa.Controls.DateTimePicker.NeedConfirmationProperty, ps, () => control.NeedConfirmation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.SelectedDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.SelectedDateProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.WatermarkProperty, binding);


 // PanelFormat

/*ValueStyleSetterGenerator*/
public static Style<T> PanelFormat<T>(this Style<T> style, System.String value) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.PanelFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanelFormat<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.PanelFormatProperty, binding);


 // NeedConfirmation

/*ValueStyleSetterGenerator*/
public static Style<T> NeedConfirmation<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.NeedConfirmationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NeedConfirmation<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateTimePicker 
=> style._addSetter(Ursa.Controls.DateTimePicker.NeedConfirmationProperty, binding);



}
