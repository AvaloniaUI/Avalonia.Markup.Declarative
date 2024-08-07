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
public static Window SizeToContent(this Window control, IBinding binding)
   => control._set(Window.SizeToContentProperty, binding);
public static Window SizeToContent(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.SizeToContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window SizeToContent(this Window control, Func<SizeToContent> func, Action<SizeToContent>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.SizeToContentProperty, func, onChanged, expression);
public static Window SizeToContent(this Window control, SizeToContent value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = value, bindingMode, converter, bindingSource);
public static Window SizeToContent<TValue>(this Window control, TValue value, FuncValueConverter<TValue, SizeToContent> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ExtendClientAreaToDecorationsHint(this Window control, IBinding binding)
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static Window ExtendClientAreaToDecorationsHint(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window ExtendClientAreaToDecorationsHint(this Window control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, func, onChanged, expression);
public static Window ExtendClientAreaToDecorationsHint(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = value, bindingMode, converter, bindingSource);
public static Window ExtendClientAreaToDecorationsHint<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ExtendClientAreaChromeHints(this Window control, IBinding binding)
   => control._set(Window.ExtendClientAreaChromeHintsProperty, binding);
public static Window ExtendClientAreaChromeHints(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.ExtendClientAreaChromeHintsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window ExtendClientAreaChromeHints(this Window control, Func<ExtendClientAreaChromeHints> func, Action<ExtendClientAreaChromeHints>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ExtendClientAreaChromeHintsProperty, func, onChanged, expression);
public static Window ExtendClientAreaChromeHints(this Window control, ExtendClientAreaChromeHints value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = value, bindingMode, converter, bindingSource);
public static Window ExtendClientAreaChromeHints<TValue>(this Window control, TValue value, FuncValueConverter<TValue, ExtendClientAreaChromeHints> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, IBinding binding)
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, func, onChanged, expression);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = value, bindingMode, converter, bindingSource);
public static Window ExtendClientAreaTitleBarHeightHint<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window SystemDecorations(this Window control, IBinding binding)
   => control._set(Window.SystemDecorationsProperty, binding);
public static Window SystemDecorations(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.SystemDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window SystemDecorations(this Window control, Func<SystemDecorations> func, Action<SystemDecorations>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.SystemDecorationsProperty, func, onChanged, expression);
public static Window SystemDecorations(this Window control, SystemDecorations value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = value, bindingMode, converter, bindingSource);
public static Window SystemDecorations<TValue>(this Window control, TValue value, FuncValueConverter<TValue, SystemDecorations> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ShowActivated(this Window control, IBinding binding)
   => control._set(Window.ShowActivatedProperty, binding);
public static Window ShowActivated(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.ShowActivatedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window ShowActivated(this Window control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ShowActivatedProperty, func, onChanged, expression);
public static Window ShowActivated(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = value, bindingMode, converter, bindingSource);
public static Window ShowActivated<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ShowInTaskbar(this Window control, IBinding binding)
   => control._set(Window.ShowInTaskbarProperty, binding);
public static Window ShowInTaskbar(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.ShowInTaskbarProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window ShowInTaskbar(this Window control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ShowInTaskbarProperty, func, onChanged, expression);
public static Window ShowInTaskbar(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = value, bindingMode, converter, bindingSource);
public static Window ShowInTaskbar<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ClosingBehavior(this Window control, IBinding binding)
   => control._set(Window.ClosingBehaviorProperty, binding);
public static Window ClosingBehavior(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.ClosingBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window ClosingBehavior(this Window control, Func<WindowClosingBehavior> func, Action<WindowClosingBehavior>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ClosingBehaviorProperty, func, onChanged, expression);
public static Window ClosingBehavior(this Window control, WindowClosingBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = value, bindingMode, converter, bindingSource);
public static Window ClosingBehavior<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowClosingBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ClosingBehaviorProperty, ps, () => control.ClosingBehavior = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window WindowState(this Window control, IBinding binding)
   => control._set(Window.WindowStateProperty, binding);
public static Window WindowState(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.WindowStateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window WindowState(this Window control, Func<WindowState> func, Action<WindowState>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.WindowStateProperty, func, onChanged, expression);
public static Window WindowState(this Window control, WindowState value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = value, bindingMode, converter, bindingSource);
public static Window WindowState<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowState> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window Title(this Window control, IBinding binding)
   => control._set(Window.TitleProperty, binding);
public static Window Title(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window Title(this Window control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.TitleProperty, func, onChanged, expression);
public static Window Title(this Window control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static Window Title<TValue>(this Window control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window Icon(this Window control, IBinding binding)
   => control._set(Window.IconProperty, binding);
public static Window Icon(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window Icon(this Window control, Func<WindowIcon> func, Action<WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.IconProperty, func, onChanged, expression);
public static Window Icon(this Window control, WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static Window Icon<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window WindowStartupLocation(this Window control, IBinding binding)
   => control._set(Window.WindowStartupLocationProperty, binding);
public static Window WindowStartupLocation(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.WindowStartupLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window WindowStartupLocation(this Window control, Func<WindowStartupLocation> func, Action<WindowStartupLocation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.WindowStartupLocationProperty, func, onChanged, expression);
public static Window WindowStartupLocation(this Window control, WindowStartupLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = value, bindingMode, converter, bindingSource);
public static Window WindowStartupLocation<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowStartupLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window CanResize(this Window control, IBinding binding)
   => control._set(Window.CanResizeProperty, binding);
public static Window CanResize(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Window.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Window CanResize(this Window control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.CanResizeProperty, func, onChanged, expression);
public static Window CanResize(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = value, bindingMode, converter, bindingSource);
public static Window CanResize<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

