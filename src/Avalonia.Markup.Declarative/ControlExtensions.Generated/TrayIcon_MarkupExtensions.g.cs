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
public static partial class TrayIcon_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CommandParameter

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Menu

/*BindFromExpressionSetterGenerator*/
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Menu<T>(this T control,Avalonia.Controls.NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Menu<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Menu<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Icon

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func, Action<Avalonia.Controls.WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Icon<T>(this T control,Avalonia.Controls.WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ToolTipText

/*BindFromExpressionSetterGenerator*/
public static T ToolTipText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ToolTipText<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ToolTipText<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToolTipText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ToolTipText<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsVisible

/*BindFromExpressionSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon 
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon 
=> control._setEx(Avalonia.Controls.TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // Icons

/*AttachedPropertyMagicalSetterGenerator*/
public static T TrayIcon_Icons<T>(this T control, Avalonia.Controls.TrayIcons value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
 => control._setEx(Avalonia.Controls.TrayIcon.IconsProperty, ps, () => Avalonia.Controls.TrayIcon.SetIcons(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TrayIcon_Icons<T>(this T control, Func<Avalonia.Controls.TrayIcons> func, Action<Avalonia.Controls.TrayIcons>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application 
   => control._set(Avalonia.Controls.TrayIcon.IconsProperty, func, onChanged, expression);



//================= Events ======================//
 // Clicked

/*ActionToEventGenerator*/
    public static T OnClicked<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TrayIcon => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Clicked += h);



}
