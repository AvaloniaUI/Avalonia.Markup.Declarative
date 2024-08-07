#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ReversibleStackPanelExtensions
{
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, IBinding binding)
   => control._set(ReversibleStackPanel.ReverseOrderProperty, binding);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ReversibleStackPanel.ReverseOrderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ReversibleStackPanel.ReverseOrderProperty, func, onChanged, expression);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = value, bindingMode, converter, bindingSource);
public static ReversibleStackPanel ReverseOrder<TValue>(this ReversibleStackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

