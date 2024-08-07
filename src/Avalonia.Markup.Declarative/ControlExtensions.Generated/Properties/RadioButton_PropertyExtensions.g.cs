#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RadioButtonExtensions
{
public static RadioButton GroupName(this RadioButton control, IBinding binding)
   => control._set(RadioButton.GroupNameProperty, binding);
public static RadioButton GroupName(this RadioButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RadioButton.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RadioButton GroupName(this RadioButton control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadioButton.GroupNameProperty, func, onChanged, expression);
public static RadioButton GroupName(this RadioButton control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadioButton.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);
public static RadioButton GroupName<TValue>(this RadioButton control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadioButton.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

