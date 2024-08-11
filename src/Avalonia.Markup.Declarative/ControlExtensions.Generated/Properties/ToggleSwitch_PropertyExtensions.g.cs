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

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSwitchExtensions
{
public static T OffContent<T>(this T control, IBinding binding) where T : ToggleSwitch
   => control._set(ToggleSwitch.OffContentProperty, binding);
public static T OffContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OffContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OffContent<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OffContentProperty, func, onChanged, expression);
public static T OffContent<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OffContentProperty, ps, () => control.OffContent = value, bindingMode, converter, bindingSource);
public static T OffContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OffContentProperty, ps, () => control.OffContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OffContentTemplate<T>(this T control, IBinding binding) where T : ToggleSwitch
   => control._set(ToggleSwitch.OffContentTemplateProperty, binding);
public static T OffContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OffContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OffContentTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OffContentTemplateProperty, func, onChanged, expression);
public static T OffContentTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = value, bindingMode, converter, bindingSource);
public static T OffContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OnContent<T>(this T control, IBinding binding) where T : ToggleSwitch
   => control._set(ToggleSwitch.OnContentProperty, binding);
public static T OnContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OnContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OnContent<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OnContentProperty, func, onChanged, expression);
public static T OnContent<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OnContentProperty, ps, () => control.OnContent = value, bindingMode, converter, bindingSource);
public static T OnContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OnContentProperty, ps, () => control.OnContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OnContentTemplate<T>(this T control, IBinding binding) where T : ToggleSwitch
   => control._set(ToggleSwitch.OnContentTemplateProperty, binding);
public static T OnContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OnContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OnContentTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.OnContentTemplateProperty, func, onChanged, expression);
public static T OnContentTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = value, bindingMode, converter, bindingSource);
public static T OnContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T KnobTransitions<T>(this T control, IBinding binding) where T : ToggleSwitch
   => control._set(ToggleSwitch.KnobTransitionsProperty, binding);
public static T KnobTransitions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.KnobTransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T KnobTransitions<T>(this T control, Func<Transitions> func, Action<Transitions>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleSwitch
   => control._set(ToggleSwitch.KnobTransitionsProperty, func, onChanged, expression);
public static T KnobTransitions<T>(this T control, Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = value, bindingMode, converter, bindingSource);
public static T KnobTransitions<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleSwitch
=> control._setEx(ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

