#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Platform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowExtensions
{
public static T SizeToContent<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.SizeToContentProperty, binding);
public static T SizeToContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.SizeToContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SizeToContent<T>(this T control, Func<SizeToContent> func, Action<SizeToContent>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.SizeToContentProperty, func, onChanged, expression);
public static T SizeToContent<T>(this T control, SizeToContent value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = value, bindingMode, converter, bindingSource);
public static T SizeToContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SizeToContent> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, func, onChanged, expression);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = value, bindingMode, converter, bindingSource);
public static T ExtendClientAreaToDecorationsHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExtendClientAreaChromeHints<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.ExtendClientAreaChromeHintsProperty, binding);
public static T ExtendClientAreaChromeHints<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.ExtendClientAreaChromeHintsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExtendClientAreaChromeHints<T>(this T control, Func<ExtendClientAreaChromeHints> func, Action<ExtendClientAreaChromeHints>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.ExtendClientAreaChromeHintsProperty, func, onChanged, expression);
public static T ExtendClientAreaChromeHints<T>(this T control, ExtendClientAreaChromeHints value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = value, bindingMode, converter, bindingSource);
public static T ExtendClientAreaChromeHints<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ExtendClientAreaChromeHints> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, func, onChanged, expression);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = value, bindingMode, converter, bindingSource);
public static T ExtendClientAreaTitleBarHeightHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SystemDecorations<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.SystemDecorationsProperty, binding);
public static T SystemDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.SystemDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SystemDecorations<T>(this T control, Func<SystemDecorations> func, Action<SystemDecorations>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.SystemDecorationsProperty, func, onChanged, expression);
public static T SystemDecorations<T>(this T control, SystemDecorations value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = value, bindingMode, converter, bindingSource);
public static T SystemDecorations<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SystemDecorations> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowActivated<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.ShowActivatedProperty, binding);
public static T ShowActivated<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.ShowActivatedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowActivated<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.ShowActivatedProperty, func, onChanged, expression);
public static T ShowActivated<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = value, bindingMode, converter, bindingSource);
public static T ShowActivated<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowInTaskbar<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.ShowInTaskbarProperty, binding);
public static T ShowInTaskbar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.ShowInTaskbarProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowInTaskbar<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.ShowInTaskbarProperty, func, onChanged, expression);
public static T ShowInTaskbar<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = value, bindingMode, converter, bindingSource);
public static T ShowInTaskbar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ClosingBehavior<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.ClosingBehaviorProperty, binding);
public static T ClosingBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.ClosingBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClosingBehavior<T>(this T control, Func<WindowClosingBehavior> func, Action<WindowClosingBehavior>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.ClosingBehaviorProperty, func, onChanged, expression);
public static T ClosingBehavior<T>(this T control, WindowClosingBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = value, bindingMode, converter, bindingSource);
public static T ClosingBehavior<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, WindowClosingBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WindowState<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.WindowStateProperty, binding);
public static T WindowState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.WindowStateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WindowState<T>(this T control, Func<WindowState> func, Action<WindowState>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.WindowStateProperty, func, onChanged, expression);
public static T WindowState<T>(this T control, WindowState value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = value, bindingMode, converter, bindingSource);
public static T WindowState<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, WindowState> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Title<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.TitleProperty, binding);
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Title<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.TitleProperty, func, onChanged, expression);
public static T Title<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static T Title<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<WindowIcon> func, Action<WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WindowStartupLocation<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.WindowStartupLocationProperty, binding);
public static T WindowStartupLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.WindowStartupLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WindowStartupLocation<T>(this T control, Func<WindowStartupLocation> func, Action<WindowStartupLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.WindowStartupLocationProperty, func, onChanged, expression);
public static T WindowStartupLocation<T>(this T control, WindowStartupLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = value, bindingMode, converter, bindingSource);
public static T WindowStartupLocation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, WindowStartupLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CanResize<T>(this T control, IBinding binding) where T : Window
   => control._set(Window.CanResizeProperty, binding);
public static T CanResize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Window
   => control._set(Window.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CanResize<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Window
   => control._set(Window.CanResizeProperty, func, onChanged, expression);
public static T CanResize<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = value, bindingMode, converter, bindingSource);
public static T CanResize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Window
=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

