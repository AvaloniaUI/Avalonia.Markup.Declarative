#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineExtensions
{
public static Inline TextDecorations(this Inline control, IBinding binding)
   => control._set(Inline.TextDecorationsProperty, binding);
public static Inline TextDecorations(this Inline control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Inline.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Inline TextDecorations(this Inline control, Func<TextDecorationCollection> func, Action<TextDecorationCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Inline.TextDecorationsProperty, func, onChanged, expression);
public static Inline TextDecorations(this Inline control, TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);
public static Inline TextDecorations<TValue>(this Inline control, TValue value, FuncValueConverter<TValue, TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Inline BaselineAlignment(this Inline control, IBinding binding)
   => control._set(Inline.BaselineAlignmentProperty, binding);
public static Inline BaselineAlignment(this Inline control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Inline.BaselineAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Inline BaselineAlignment(this Inline control, Func<BaselineAlignment> func, Action<BaselineAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Inline.BaselineAlignmentProperty, func, onChanged, expression);
public static Inline BaselineAlignment(this Inline control, BaselineAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = value, bindingMode, converter, bindingSource);
public static Inline BaselineAlignment<TValue>(this Inline control, TValue value, FuncValueConverter<TValue, BaselineAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

