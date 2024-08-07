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
public static Style<Shape> Fill(this Style<Shape> style, IBrush value)
=> style._addSetter(Shape.FillProperty, value);
public static Style<Shape> Fill(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.FillProperty, binding);
public static Style<Shape> Stretch(this Style<Shape> style, Stretch value)
=> style._addSetter(Shape.StretchProperty, value);
public static Style<Shape> Stretch(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StretchProperty, binding);
public static Style<Shape> Stroke(this Style<Shape> style, IBrush value)
=> style._addSetter(Shape.StrokeProperty, value);
public static Style<Shape> Stroke(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StrokeProperty, binding);
public static Style<Shape> StrokeDashArray(this Style<Shape> style, AvaloniaList<Double> value)
=> style._addSetter(Shape.StrokeDashArrayProperty, value);
public static Style<Shape> StrokeDashArray(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StrokeDashArrayProperty, binding);
public static Style<Shape> StrokeDashOffset(this Style<Shape> style, Double value)
=> style._addSetter(Shape.StrokeDashOffsetProperty, value);
public static Style<Shape> StrokeDashOffset(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StrokeDashOffsetProperty, binding);
public static Style<Shape> StrokeThickness(this Style<Shape> style, Double value)
=> style._addSetter(Shape.StrokeThicknessProperty, value);
public static Style<Shape> StrokeThickness(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StrokeThicknessProperty, binding);
public static Style<Shape> StrokeLineCap(this Style<Shape> style, PenLineCap value)
=> style._addSetter(Shape.StrokeLineCapProperty, value);
public static Style<Shape> StrokeLineCap(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StrokeLineCapProperty, binding);
public static Style<Shape> StrokeJoin(this Style<Shape> style, PenLineJoin value)
=> style._addSetter(Shape.StrokeJoinProperty, value);
public static Style<Shape> StrokeJoin(this Style<Shape> style, IBinding binding)
=> style._addSetter(Shape.StrokeJoinProperty, binding);
}

