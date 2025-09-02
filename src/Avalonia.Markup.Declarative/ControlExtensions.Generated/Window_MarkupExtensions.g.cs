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
public static partial class Window_MarkupExtensions
{
//================= Properties ======================//
 // SizeToContent

/*ValueSetterGenerator*/
public static T SizeToContent<T>(this T control, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> control._set(() => control.SizeToContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T SizeToContent<T>(this T control, Func<Avalonia.Controls.SizeToContent> func, Action<Avalonia.Controls.SizeToContent>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SizeToContent<T>(this T control,Avalonia.Controls.SizeToContent value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.SizeToContentProperty, ps, () => control.SizeToContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SizeToContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SizeToContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SizeToContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SizeToContent> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.SizeToContentProperty, ps, () => control.SizeToContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ExtendClientAreaToDecorationsHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaToDecorationsHint = value!);

/*BindFromExpressionSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ExtendClientAreaToDecorationsHint<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExtendClientAreaToDecorationsHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ExtendClientAreaToDecorationsHint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ExtendClientAreaChromeHints

/*ValueSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaChromeHints = value!);

/*BindFromExpressionSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, Func<Avalonia.Platform.ExtendClientAreaChromeHints> func, Action<Avalonia.Platform.ExtendClientAreaChromeHints>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ExtendClientAreaChromeHints<T>(this T control,Avalonia.Platform.ExtendClientAreaChromeHints value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExtendClientAreaChromeHints<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ExtendClientAreaChromeHints<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Platform.ExtendClientAreaChromeHints> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ExtendClientAreaTitleBarHeightHint

/*ValueSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, System.Double value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ExtendClientAreaTitleBarHeightHint = value!);

/*BindFromExpressionSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ExtendClientAreaTitleBarHeightHint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SystemDecorations

/*ValueSetterGenerator*/
public static T SystemDecorations<T>(this T control, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> control._set(() => control.SystemDecorations = value!);

/*BindFromExpressionSetterGenerator*/
public static T SystemDecorations<T>(this T control, Func<Avalonia.Controls.SystemDecorations> func, Action<Avalonia.Controls.SystemDecorations>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SystemDecorations<T>(this T control,Avalonia.Controls.SystemDecorations value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SystemDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SystemDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SystemDecorations<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SystemDecorations> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowActivated

/*ValueSetterGenerator*/
public static T ShowActivated<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ShowActivated = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowActivated<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowActivated<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ShowActivatedProperty, ps, () => control.ShowActivated = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowActivated<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowActivated<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowActivated<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ShowActivatedProperty, ps, () => control.ShowActivated = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowInTaskbar

/*ValueSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ShowInTaskbar = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowInTaskbar<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowInTaskbar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowInTaskbar<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ClosingBehavior

/*ValueSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> control._set(() => control.ClosingBehavior = value!);

/*BindFromExpressionSetterGenerator*/
public static T ClosingBehavior<T>(this T control, Func<Avalonia.Controls.WindowClosingBehavior> func, Action<Avalonia.Controls.WindowClosingBehavior>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ClosingBehavior<T>(this T control,Avalonia.Controls.WindowClosingBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClosingBehavior<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClosingBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ClosingBehavior<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowClosingBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // WindowState

/*ValueSetterGenerator*/
public static T WindowState<T>(this T control, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> control._set(() => control.WindowState = value!);

/*BindFromExpressionSetterGenerator*/
public static T WindowState<T>(this T control, Func<Avalonia.Controls.WindowState> func, Action<Avalonia.Controls.WindowState>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T WindowState<T>(this T control,Avalonia.Controls.WindowState value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.WindowStateProperty, ps, () => control.WindowState = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WindowState<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T WindowState<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowState> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.WindowStateProperty, ps, () => control.WindowState = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : Avalonia.Controls.Window 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func, Action<Avalonia.Controls.WindowIcon>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,Avalonia.Controls.WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // WindowStartupLocation

/*ValueSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> control._set(() => control.WindowStartupLocation = value!);

/*BindFromExpressionSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, Func<Avalonia.Controls.WindowStartupLocation> func, Action<Avalonia.Controls.WindowStartupLocation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T WindowStartupLocation<T>(this T control,Avalonia.Controls.WindowStartupLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WindowStartupLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T WindowStartupLocation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowStartupLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanResize

/*ValueSetterGenerator*/
public static T CanResize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanResize = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanResize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanResize<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.CanResizeProperty, ps, () => control.CanResize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanResize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanResize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanResize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanMinimize

/*ValueSetterGenerator*/
public static T CanMinimize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanMinimize = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanMinimize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanMinimize<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.CanMinimizeProperty, ps, () => control.CanMinimize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanMinimize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanMinimize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMinimizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanMinimize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.CanMinimizeProperty, ps, () => control.CanMinimize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanMaximize

/*ValueSetterGenerator*/
public static T CanMaximize<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Window 
=> control._set(() => control.CanMaximize = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanMaximize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanMaximize<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.CanMaximizeProperty, ps, () => control.CanMaximize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanMaximize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanMaximize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window 
   => control._set(Avalonia.Controls.Window.CanMaximizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanMaximize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Window 
=> control._setEx(Avalonia.Controls.Window.CanMaximizeProperty, ps, () => control.CanMaximize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Closing

/*ActionToEventGenerator*/
public static T OnClosing<T>(this T control, Action<Avalonia.Controls.WindowClosingEventArgs> action) where T : Avalonia.Controls.Window  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowClosingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closing += h);



//================= Styles ======================//
 // SizeToContent

/*ValueStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, Avalonia.Controls.SizeToContent value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SizeToContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SizeToContentProperty, binding);


 // ExtendClientAreaToDecorationsHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaToDecorationsHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);


 // ExtendClientAreaChromeHints

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, Avalonia.Platform.ExtendClientAreaChromeHints value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaChromeHints<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);


 // ExtendClientAreaTitleBarHeightHint

/*ValueStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ExtendClientAreaTitleBarHeightHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);


 // SystemDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, Avalonia.Controls.SystemDecorations value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SystemDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.SystemDecorationsProperty, binding);


 // ShowActivated

/*ValueStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowActivated<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowActivatedProperty, binding);


 // ShowInTaskbar

/*ValueStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowInTaskbar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);


 // ClosingBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, Avalonia.Controls.WindowClosingBehavior value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ClosingBehavior<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);


 // WindowState

/*ValueStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, Avalonia.Controls.WindowState value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStateProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.TitleProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, Avalonia.Controls.WindowIcon value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.IconProperty, binding);


 // WindowStartupLocation

/*ValueStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, Avalonia.Controls.WindowStartupLocation value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> WindowStartupLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);


 // CanResize

/*ValueStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanResizeProperty, binding);


 // CanMinimize

/*ValueStyleSetterGenerator*/
public static Style<T> CanMinimize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMinimizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMinimize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMinimizeProperty, binding);


 // CanMaximize

/*ValueStyleSetterGenerator*/
public static Style<T> CanMaximize<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMaximizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanMaximize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Window 
=> style._addSetter(Avalonia.Controls.Window.CanMaximizeProperty, binding);



}
