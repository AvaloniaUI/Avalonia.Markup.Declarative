#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridExtensions
{
public static Grid ShowGridLines(this Grid control, IBinding binding)
   => control._set(Grid.ShowGridLinesProperty, binding);
public static Grid ShowGridLines(this Grid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Grid.ShowGridLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Grid ShowGridLines(this Grid control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Grid.ShowGridLinesProperty, func, onChanged, expression);
public static Grid ShowGridLines(this Grid control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = value, bindingMode, converter, bindingSource);
public static Grid ShowGridLines<TValue>(this Grid control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

