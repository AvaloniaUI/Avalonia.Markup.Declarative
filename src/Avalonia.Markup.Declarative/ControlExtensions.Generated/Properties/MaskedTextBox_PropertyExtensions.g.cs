#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MaskedTextBoxExtensions
{
public static T AsciiOnly<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.AsciiOnlyProperty, binding);
public static T AsciiOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.AsciiOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AsciiOnly<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.AsciiOnlyProperty, func, onChanged, expression);
public static T AsciiOnly<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = value, bindingMode, converter, bindingSource);
public static T AsciiOnly<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Culture<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.CultureProperty, binding);
public static T Culture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.CultureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Culture<T>(this T control, Func<CultureInfo> func, Action<CultureInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.CultureProperty, func, onChanged, expression);
public static T Culture<T>(this T control, CultureInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = value, bindingMode, converter, bindingSource);
public static T Culture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CultureInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HidePromptOnLeave<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static T HidePromptOnLeave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HidePromptOnLeave<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, func, onChanged, expression);
public static T HidePromptOnLeave<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = value, bindingMode, converter, bindingSource);
public static T HidePromptOnLeave<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Mask<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.MaskProperty, binding);
public static T Mask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.MaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Mask<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.MaskProperty, func, onChanged, expression);
public static T Mask<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = value, bindingMode, converter, bindingSource);
public static T Mask<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PromptChar<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.PromptCharProperty, binding);
public static T PromptChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.PromptCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PromptChar<T>(this T control, Func<Char> func, Action<Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.PromptCharProperty, func, onChanged, expression);
public static T PromptChar<T>(this T control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = value, bindingMode, converter, bindingSource);
public static T PromptChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ResetOnPrompt<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.ResetOnPromptProperty, binding);
public static T ResetOnPrompt<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.ResetOnPromptProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResetOnPrompt<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.ResetOnPromptProperty, func, onChanged, expression);
public static T ResetOnPrompt<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = value, bindingMode, converter, bindingSource);
public static T ResetOnPrompt<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ResetOnSpace<T>(this T control, IBinding binding) where T : MaskedTextBox
   => control._set(MaskedTextBox.ResetOnSpaceProperty, binding);
public static T ResetOnSpace<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.ResetOnSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResetOnSpace<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MaskedTextBox
   => control._set(MaskedTextBox.ResetOnSpaceProperty, func, onChanged, expression);
public static T ResetOnSpace<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = value, bindingMode, converter, bindingSource);
public static T ResetOnSpace<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MaskedTextBox
=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

