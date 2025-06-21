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
public static partial class TimePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // NeedsConfirmation

/*ValueSetterGenerator*/
public static T NeedsConfirmation<T>(this T control, System.Boolean value) where T : Ursa.Controls.TimePickerPresenter 
=> control._set(() => control.NeedsConfirmation = value!);

/*BindFromExpressionSetterGenerator*/
public static T NeedsConfirmation<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T NeedsConfirmation<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty, ps, () => control.NeedsConfirmation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NeedsConfirmation<T>(this T control, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NeedsConfirmation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T NeedsConfirmation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty, ps, () => control.NeedsConfirmation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinuteIncrement

/*ValueSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value) where T : Ursa.Controls.TimePickerPresenter 
=> control._set(() => control.MinuteIncrement = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinuteIncrement<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinuteIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SecondIncrement

/*ValueSetterGenerator*/
public static T SecondIncrement<T>(this T control, System.Int32 value) where T : Ursa.Controls.TimePickerPresenter 
=> control._set(() => control.SecondIncrement = value!);

/*BindFromExpressionSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SecondIncrement<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty, ps, () => control.SecondIncrement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SecondIncrement<T>(this T control, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SecondIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SecondIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty, ps, () => control.SecondIncrement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PanelFormat

/*ValueSetterGenerator*/
public static T PanelFormat<T>(this T control, System.String value) where T : Ursa.Controls.TimePickerPresenter 
=> control._set(() => control.PanelFormat = value!);

/*BindFromExpressionSetterGenerator*/
public static T PanelFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.PanelFormatProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PanelFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.PanelFormatProperty, ps, () => control.PanelFormat = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PanelFormat<T>(this T control, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.PanelFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PanelFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimePickerPresenter 
   => control._set(Ursa.Controls.TimePickerPresenter.PanelFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PanelFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimePickerPresenter 
=> control._setEx(Ursa.Controls.TimePickerPresenter.PanelFormatProperty, ps, () => control.PanelFormat = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // SelectedTimeChanged

/*ActionToEventGenerator*/
public static T OnSelectedTimeChanged<T>(this T control, Action<Ursa.Controls.TimeChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.TimePickerPresenter 
{
  control.AddHandler(Ursa.Controls.TimePickerPresenter.SelectedTimeChangedEvent, (_, args) => action(args), routes ?? Ursa.Controls.TimePickerPresenter.SelectedTimeChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // NeedsConfirmation

/*ValueStyleSetterGenerator*/
public static Style<T> NeedsConfirmation<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> NeedsConfirmation<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.NeedsConfirmationProperty, binding);


 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.SecondIncrementProperty, binding);


 // PanelFormat

/*ValueStyleSetterGenerator*/
public static Style<T> PanelFormat<T>(this Style<T> style, System.String value) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.PanelFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PanelFormat<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimePickerPresenter 
=> style._addSetter(Ursa.Controls.TimePickerPresenter.PanelFormatProperty, binding);



}
