#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using MaskedTextBox = Avalonia.Controls.MaskedTextBox;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MaskedTextBoxExtensions
{
public static T AsciiOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);
public static T AsciiOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AsciiOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, func, onChanged, expression);
public static T AsciiOnly<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = value, bindingMode, converter, bindingSource);
public static T AsciiOnly<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Culture<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);
public static T Culture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Culture<T>(this T control, Func<System.Globalization.CultureInfo> func, Action<System.Globalization.CultureInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, func, onChanged, expression);
public static T Culture<T>(this T control, System.Globalization.CultureInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.CultureProperty, ps, () => control.Culture = value, bindingMode, converter, bindingSource);
public static T Culture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Globalization.CultureInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.CultureProperty, ps, () => control.Culture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HidePromptOnLeave<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static T HidePromptOnLeave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HidePromptOnLeave<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, func, onChanged, expression);
public static T HidePromptOnLeave<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = value, bindingMode, converter, bindingSource);
public static T HidePromptOnLeave<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Mask<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);
public static T Mask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Mask<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, func, onChanged, expression);
public static T Mask<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.MaskProperty, ps, () => control.Mask = value, bindingMode, converter, bindingSource);
public static T Mask<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.MaskProperty, ps, () => control.Mask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PromptChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);
public static T PromptChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PromptChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, func, onChanged, expression);
public static T PromptChar<T>(this T control, System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = value, bindingMode, converter, bindingSource);
public static T PromptChar<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ResetOnPrompt<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);
public static T ResetOnPrompt<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResetOnPrompt<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, func, onChanged, expression);
public static T ResetOnPrompt<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = value, bindingMode, converter, bindingSource);
public static T ResetOnPrompt<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ResetOnSpace<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);
public static T ResetOnSpace<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResetOnSpace<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, func, onChanged, expression);
public static T ResetOnSpace<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = value, bindingMode, converter, bindingSource);
public static T ResetOnSpace<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

