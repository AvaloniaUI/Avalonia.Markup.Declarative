using Avalonia.Collections;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Shape = Avalonia.Controls.Shapes.Shape;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ShapeExtensions
{
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, value);
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.FillProperty, binding);
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, value);
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StretchProperty, binding);
public static Style<T> Stroke<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, value);
public static Style<T> Stroke<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeProperty, binding);
public static Style<T> StrokeDashArray<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, value);
public static Style<T> StrokeDashArray<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashArrayProperty, binding);
public static Style<T> StrokeDashOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, value);
public static Style<T> StrokeDashOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeDashOffsetProperty, binding);
public static Style<T> StrokeThickness<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, value);
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeThicknessProperty, binding);
public static Style<T> StrokeLineCap<T>(this Style<T> style, Avalonia.Media.PenLineCap value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, value);
public static Style<T> StrokeLineCap<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeLineCapProperty, binding);
public static Style<T> StrokeJoin<T>(this Style<T> style, Avalonia.Media.PenLineJoin value) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, value);
public static Style<T> StrokeJoin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Shape
=> style._addSetter(Avalonia.Controls.Shapes.Shape.StrokeJoinProperty, binding);
}

