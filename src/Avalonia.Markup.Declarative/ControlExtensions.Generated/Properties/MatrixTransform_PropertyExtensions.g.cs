#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using MatrixTransform = Avalonia.Media.MatrixTransform;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MatrixTransformExtensions
{
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, IBinding binding)
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty, binding);
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Func<Avalonia.Matrix> func, Action<Avalonia.Matrix>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty, func, onChanged, expression);
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Avalonia.Matrix value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.MatrixTransform.MatrixProperty, ps, () => control.Matrix = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.MatrixTransform Matrix<TValue>(this Avalonia.Media.MatrixTransform control, TValue value, FuncValueConverter<TValue, Avalonia.Matrix> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.MatrixTransform.MatrixProperty, ps, () => control.Matrix = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Double scaleX = default, Double skewY = default, Double skewX = default, Double scaleY = default, Double offsetX = default, Double offsetY = default)
   => control._set(() => control.Matrix = new Avalonia.Matrix(scaleX, skewY, skewX, scaleY, offsetX, offsetY));
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Double scaleX = default, Double skewY = default, Double perspX = default, Double skewX = default, Double scaleY = default, Double perspY = default, Double offsetX = default, Double offsetY = default, Double perspZ = default)
   => control._set(() => control.Matrix = new Avalonia.Matrix(scaleX, skewY, perspX, skewX, scaleY, perspY, offsetX, offsetY, perspZ));
}

