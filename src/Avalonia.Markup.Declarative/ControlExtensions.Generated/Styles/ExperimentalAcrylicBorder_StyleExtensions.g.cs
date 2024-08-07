using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExperimentalAcrylicBorderExtensions
{
public static Style<ExperimentalAcrylicBorder> CornerRadius(this Style<ExperimentalAcrylicBorder> style, CornerRadius value)
=> style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, value);
public static Style<ExperimentalAcrylicBorder> CornerRadius(this Style<ExperimentalAcrylicBorder> style, IBinding binding)
=> style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, binding);

public static Style<ExperimentalAcrylicBorder> CornerRadius(this Style<ExperimentalAcrylicBorder> style, Double uniformRadius)
   => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<ExperimentalAcrylicBorder> CornerRadius(this Style<ExperimentalAcrylicBorder> style, Double top, Double bottom)
   => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<ExperimentalAcrylicBorder> CornerRadius(this Style<ExperimentalAcrylicBorder> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<ExperimentalAcrylicBorder> Material(this Style<ExperimentalAcrylicBorder> style, ExperimentalAcrylicMaterial value)
=> style._addSetter(ExperimentalAcrylicBorder.MaterialProperty, value);
public static Style<ExperimentalAcrylicBorder> Material(this Style<ExperimentalAcrylicBorder> style, IBinding binding)
=> style._addSetter(ExperimentalAcrylicBorder.MaterialProperty, binding);
}

