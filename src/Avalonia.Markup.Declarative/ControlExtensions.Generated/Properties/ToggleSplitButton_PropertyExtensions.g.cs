#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSplitButtonExtensions
{
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, IBinding binding)
   => control._set(ToggleSplitButton.IsCheckedProperty, binding);
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ToggleSplitButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSplitButton.IsCheckedProperty, func, onChanged, expression);
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSplitButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static ToggleSplitButton IsChecked<TValue>(this ToggleSplitButton control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSplitButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

