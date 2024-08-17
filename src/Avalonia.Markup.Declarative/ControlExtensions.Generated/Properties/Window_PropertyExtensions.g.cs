#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Platform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Window = Avalonia.Controls.Window;

namespace Avalonia.Markup.Declarative;
public static partial class WindowExtensions
{
public static T SizeToContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, binding);
public static T SizeToContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SizeToContent<T>(this T control, Func<Avalonia.Controls.SizeToContent> func, Action<Avalonia.Controls.SizeToContent>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.SizeToContentProperty, func, onChanged, expression);
public static T SizeToContent<T>(this T control, Avalonia.Controls.SizeToContent value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.SizeToContentProperty, ps, () => control.SizeToContent = value, bindingMode, converter, bindingSource);
public static T SizeToContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SizeToContent> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.SizeToContentProperty, ps, () => control.SizeToContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, func, onChanged, expression);
public static T ExtendClientAreaToDecorationsHint<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = value, bindingMode, converter, bindingSource);
public static T ExtendClientAreaToDecorationsHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExtendClientAreaChromeHints<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, binding);
public static T ExtendClientAreaChromeHints<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExtendClientAreaChromeHints<T>(this T control, Func<Avalonia.Platform.ExtendClientAreaChromeHints> func, Action<Avalonia.Platform.ExtendClientAreaChromeHints>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, func, onChanged, expression);
public static T ExtendClientAreaChromeHints<T>(this T control, Avalonia.Platform.ExtendClientAreaChromeHints value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = value, bindingMode, converter, bindingSource);
public static T ExtendClientAreaChromeHints<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Platform.ExtendClientAreaChromeHints> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, func, onChanged, expression);
public static T ExtendClientAreaTitleBarHeightHint<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = value, bindingMode, converter, bindingSource);
public static T ExtendClientAreaTitleBarHeightHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SystemDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, binding);
public static T SystemDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SystemDecorations<T>(this T control, Func<Avalonia.Controls.SystemDecorations> func, Action<Avalonia.Controls.SystemDecorations>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.SystemDecorationsProperty, func, onChanged, expression);
public static T SystemDecorations<T>(this T control, Avalonia.Controls.SystemDecorations value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = value, bindingMode, converter, bindingSource);
public static T SystemDecorations<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SystemDecorations> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowActivated<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, binding);
public static T ShowActivated<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowActivated<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ShowActivatedProperty, func, onChanged, expression);
public static T ShowActivated<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ShowActivatedProperty, ps, () => control.ShowActivated = value, bindingMode, converter, bindingSource);
public static T ShowActivated<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ShowActivatedProperty, ps, () => control.ShowActivated = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowInTaskbar<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, binding);
public static T ShowInTaskbar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowInTaskbar<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ShowInTaskbarProperty, func, onChanged, expression);
public static T ShowInTaskbar<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = value, bindingMode, converter, bindingSource);
public static T ShowInTaskbar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ClosingBehavior<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, binding);
public static T ClosingBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClosingBehavior<T>(this T control, Func<Avalonia.Controls.WindowClosingBehavior> func, Action<Avalonia.Controls.WindowClosingBehavior>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.ClosingBehaviorProperty, func, onChanged, expression);
public static T ClosingBehavior<T>(this T control, Avalonia.Controls.WindowClosingBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = value, bindingMode, converter, bindingSource);
public static T ClosingBehavior<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowClosingBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WindowState<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.WindowStateProperty, binding);
public static T WindowState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.WindowStateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WindowState<T>(this T control, Func<Avalonia.Controls.WindowState> func, Action<Avalonia.Controls.WindowState>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.WindowStateProperty, func, onChanged, expression);
public static T WindowState<T>(this T control, Avalonia.Controls.WindowState value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.WindowStateProperty, ps, () => control.WindowState = value, bindingMode, converter, bindingSource);
public static T WindowState<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowState> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.WindowStateProperty, ps, () => control.WindowState = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Title<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.TitleProperty, binding);
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.TitleProperty, func, onChanged, expression);
public static T Title<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static T Title<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func, Action<Avalonia.Controls.WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WindowStartupLocation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, binding);
public static T WindowStartupLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WindowStartupLocation<T>(this T control, Func<Avalonia.Controls.WindowStartupLocation> func, Action<Avalonia.Controls.WindowStartupLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.WindowStartupLocationProperty, func, onChanged, expression);
public static T WindowStartupLocation<T>(this T control, Avalonia.Controls.WindowStartupLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = value, bindingMode, converter, bindingSource);
public static T WindowStartupLocation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowStartupLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CanResize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.CanResizeProperty, binding);
public static T CanResize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CanResize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Window
   => control._set(Avalonia.Controls.Window.CanResizeProperty, func, onChanged, expression);
public static T CanResize<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.CanResizeProperty, ps, () => control.CanResize = value, bindingMode, converter, bindingSource);
public static T CanResize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Window
=> control._setEx(Avalonia.Controls.Window.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

