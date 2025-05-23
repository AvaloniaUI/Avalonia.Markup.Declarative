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
public static partial class NativeMenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Menu

/*ValueSetterGenerator*/
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Menu = value!);

/*BindFromExpressionSetterGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Menu<T>(this T control,Avalonia.Controls.NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.MenuProperty, ps, () => control.Menu = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Menu<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Menu<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.MenuProperty, ps, () => control.Menu = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Media.Imaging.Bitmap value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Media.Imaging.Bitmap> func, Action<Avalonia.Media.Imaging.Bitmap>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,Avalonia.Media.Imaging.Bitmap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Imaging.Bitmap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Header

/*ValueSetterGenerator*/
public static T Header<T>(this T control, System.String value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Header = value!);

/*BindFromExpressionSetterGenerator*/
public static T Header<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Header<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.HeaderProperty, ps, () => control.Header = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Header<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Header<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ToolTip

/*ValueSetterGenerator*/
public static T ToolTip<T>(this T control, System.String value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.ToolTip = value!);

/*BindFromExpressionSetterGenerator*/
public static T ToolTip<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ToolTip<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ToolTip<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToolTip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ToolTip<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Gesture = value!);

/*BindFromExpressionSetterGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Gesture<T>(this T control,Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.GestureProperty, ps, () => control.Gesture = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Gesture<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Gesture<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsChecked

/*ValueSetterGenerator*/
public static T IsChecked<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsChecked = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsChecked<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsChecked<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ToggleType

/*ValueSetterGenerator*/
public static T ToggleType<T>(this T control, Avalonia.Controls.NativeMenuItemToggleType value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.ToggleType = value!);

/*BindFromExpressionSetterGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.NativeMenuItemToggleType> func, Action<Avalonia.Controls.NativeMenuItemToggleType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ToggleType<T>(this T control,Avalonia.Controls.NativeMenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ToggleType<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ToggleType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.NativeMenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.Command = value!);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandProperty, ps, () => control.Command = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.CommandParameter = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsVisible

/*ValueSetterGenerator*/
public static T IsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.NativeMenuItem 
=> control._set(() => control.IsVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem 
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.NativeMenuItem 
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenuItem  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Click += h);



}
