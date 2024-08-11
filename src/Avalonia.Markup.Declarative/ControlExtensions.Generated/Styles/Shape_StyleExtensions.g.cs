using Avalonia.Collections;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ShapeExtensions
{
public static Style<T> Fill<T>(this Style<T> style, IBrush value) where T : Shape
=> style._addSetter(Shape.FillProperty, value);
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.FillProperty, binding);
public static Style<T> Stretch<T>(this Style<T> style, Stretch value) where T : Shape
=> style._addSetter(Shape.StretchProperty, value);
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StretchProperty, binding);
public static Style<T> Stroke<T>(this Style<T> style, IBrush value) where T : Shape
=> style._addSetter(Shape.StrokeProperty, value);
public static Style<T> Stroke<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StrokeProperty, binding);
public static Style<T> StrokeDashArray<T>(this Style<T> style, AvaloniaList<Double> value) where T : Shape
=> style._addSetter(Shape.StrokeDashArrayProperty, value);
public static Style<T> StrokeDashArray<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StrokeDashArrayProperty, binding);
public static Style<T> StrokeDashOffset<T>(this Style<T> style, Double value) where T : Shape
=> style._addSetter(Shape.StrokeDashOffsetProperty, value);
public static Style<T> StrokeDashOffset<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StrokeDashOffsetProperty, binding);
public static Style<T> StrokeThickness<T>(this Style<T> style, Double value) where T : Shape
=> style._addSetter(Shape.StrokeThicknessProperty, value);
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StrokeThicknessProperty, binding);
public static Style<T> StrokeLineCap<T>(this Style<T> style, PenLineCap value) where T : Shape
=> style._addSetter(Shape.StrokeLineCapProperty, value);
public static Style<T> StrokeLineCap<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StrokeLineCapProperty, binding);
public static Style<T> StrokeJoin<T>(this Style<T> style, PenLineJoin value) where T : Shape
=> style._addSetter(Shape.StrokeJoinProperty, value);
public static Style<T> StrokeJoin<T>(this Style<T> style, IBinding binding) where T : Shape
=> style._addSetter(Shape.StrokeJoinProperty, binding);
}

