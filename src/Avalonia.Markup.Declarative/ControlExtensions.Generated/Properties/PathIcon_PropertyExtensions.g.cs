#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathIconExtensions
{
public static PathIcon Data(this PathIcon control, IBinding binding)
   => control._set(PathIcon.DataProperty, binding);
public static PathIcon Data(this PathIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PathIcon.DataProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PathIcon Data(this PathIcon control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathIcon.DataProperty, func, onChanged, expression);
public static PathIcon Data(this PathIcon control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathIcon.DataProperty, ps, () => control.Data = value, bindingMode, converter, bindingSource);
public static PathIcon Data<TValue>(this PathIcon control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathIcon.DataProperty, ps, () => control.Data = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

