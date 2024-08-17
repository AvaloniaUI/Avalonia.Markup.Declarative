#nullable enable
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ToggleSwitch = Avalonia.Controls.ToggleSwitch;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSwitchExtensions
{
public static T OffContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty, binding);
public static T OffContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OffContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty, func, onChanged, expression);
public static T OffContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentProperty, ps, () => control.OffContent = value, bindingMode, converter, bindingSource);
public static T OffContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentProperty, ps, () => control.OffContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OffContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, binding);
public static T OffContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OffContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, func, onChanged, expression);
public static T OffContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = value, bindingMode, converter, bindingSource);
public static T OffContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OnContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty, binding);
public static T OnContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OnContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty, func, onChanged, expression);
public static T OnContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentProperty, ps, () => control.OnContent = value, bindingMode, converter, bindingSource);
public static T OnContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentProperty, ps, () => control.OnContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OnContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, binding);
public static T OnContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OnContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, func, onChanged, expression);
public static T OnContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = value, bindingMode, converter, bindingSource);
public static T OnContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T KnobTransitions<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, binding);
public static T KnobTransitions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T KnobTransitions<T>(this T control, Func<Avalonia.Animation.Transitions> func, Action<Avalonia.Animation.Transitions>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ToggleSwitch
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, func, onChanged, expression);
public static T KnobTransitions<T>(this T control, Avalonia.Animation.Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = value, bindingMode, converter, bindingSource);
public static T KnobTransitions<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSwitch
=> control._setEx(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

