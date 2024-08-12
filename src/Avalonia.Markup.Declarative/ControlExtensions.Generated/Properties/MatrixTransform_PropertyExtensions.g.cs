#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MatrixTransformExtensions
{
public static MatrixTransform Matrix(this MatrixTransform control, IBinding binding)
   => control._set(MatrixTransform.MatrixProperty, binding);
public static MatrixTransform Matrix(this MatrixTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MatrixTransform.MatrixProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MatrixTransform Matrix(this MatrixTransform control, Func<Matrix> func, Action<Matrix>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MatrixTransform.MatrixProperty, func, onChanged, expression);
public static MatrixTransform Matrix(this MatrixTransform control, Matrix value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MatrixTransform.MatrixProperty, ps, () => control.Matrix = value, bindingMode, converter, bindingSource);
public static MatrixTransform Matrix<TValue>(this MatrixTransform control, TValue value, FuncValueConverter<TValue, Matrix> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MatrixTransform.MatrixProperty, ps, () => control.Matrix = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static MatrixTransform Matrix(this MatrixTransform control, Double scaleX = default, Double skewY = default, Double skewX = default, Double scaleY = default, Double offsetX = default, Double offsetY = default)
   => control._set(() => control.Matrix = new Matrix(scaleX, skewY, skewX, scaleY, offsetX, offsetY));
public static MatrixTransform Matrix(this MatrixTransform control, Double scaleX = default, Double skewY = default, Double perspX = default, Double skewX = default, Double scaleY = default, Double perspY = default, Double offsetX = default, Double offsetY = default, Double perspZ = default)
   => control._set(() => control.Matrix = new Matrix(scaleX, skewY, perspX, skewX, scaleY, perspY, offsetX, offsetY, perspZ));
}

