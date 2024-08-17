#nullable enable
using Avalonia.Controls.Documents;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Inline = Avalonia.Controls.Documents.Inline;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InlineExtensions
{
public static T TextDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Inline
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, binding);
public static T TextDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Inline
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.Inline
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, func, onChanged, expression);
public static T TextDecorations<T>(this T control, Avalonia.Media.TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Inline
=> control._setEx(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);
public static T TextDecorations<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Inline
=> control._setEx(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BaselineAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Inline
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, binding);
public static T BaselineAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Inline
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BaselineAlignment<T>(this T control, Func<Avalonia.Media.BaselineAlignment> func, Action<Avalonia.Media.BaselineAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.Inline
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, func, onChanged, expression);
public static T BaselineAlignment<T>(this T control, Avalonia.Media.BaselineAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Inline
=> control._setEx(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = value, bindingMode, converter, bindingSource);
public static T BaselineAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BaselineAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Inline
=> control._setEx(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

