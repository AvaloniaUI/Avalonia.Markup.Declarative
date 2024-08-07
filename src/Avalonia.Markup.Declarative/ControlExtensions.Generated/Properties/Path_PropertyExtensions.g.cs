#nullable enable
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PathExtensions
{
public static Path Data(this Path control, IBinding binding)
   => control._set(Path.DataProperty, binding);
public static Path Data(this Path control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Path.DataProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Path Data(this Path control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Path.DataProperty, func, onChanged, expression);
public static Path Data(this Path control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Path.DataProperty, ps, () => control.Data = value, bindingMode, converter, bindingSource);
public static Path Data<TValue>(this Path control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Path.DataProperty, ps, () => control.Data = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

