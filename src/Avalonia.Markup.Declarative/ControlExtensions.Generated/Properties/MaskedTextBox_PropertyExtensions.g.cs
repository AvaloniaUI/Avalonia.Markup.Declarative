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
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.AsciiOnlyProperty, binding);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.AsciiOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.AsciiOnlyProperty, func, onChanged, expression);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = value, bindingMode, converter, bindingSource);
public static MaskedTextBox AsciiOnly<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox Culture(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.CultureProperty, binding);
public static MaskedTextBox Culture(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.CultureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox Culture(this MaskedTextBox control, Func<CultureInfo> func, Action<CultureInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.CultureProperty, func, onChanged, expression);
public static MaskedTextBox Culture(this MaskedTextBox control, CultureInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = value, bindingMode, converter, bindingSource);
public static MaskedTextBox Culture<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, CultureInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, func, onChanged, expression);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = value, bindingMode, converter, bindingSource);
public static MaskedTextBox HidePromptOnLeave<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox Mask(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.MaskProperty, binding);
public static MaskedTextBox Mask(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.MaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox Mask(this MaskedTextBox control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.MaskProperty, func, onChanged, expression);
public static MaskedTextBox Mask(this MaskedTextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = value, bindingMode, converter, bindingSource);
public static MaskedTextBox Mask<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox PromptChar(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.PromptCharProperty, binding);
public static MaskedTextBox PromptChar(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.PromptCharProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox PromptChar(this MaskedTextBox control, Func<Char> func, Action<Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.PromptCharProperty, func, onChanged, expression);
public static MaskedTextBox PromptChar(this MaskedTextBox control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = value, bindingMode, converter, bindingSource);
public static MaskedTextBox PromptChar<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.ResetOnPromptProperty, binding);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.ResetOnPromptProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.ResetOnPromptProperty, func, onChanged, expression);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = value, bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnPrompt<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.ResetOnSpaceProperty, binding);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MaskedTextBox.ResetOnSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.ResetOnSpaceProperty, func, onChanged, expression);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = value, bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnSpace<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

