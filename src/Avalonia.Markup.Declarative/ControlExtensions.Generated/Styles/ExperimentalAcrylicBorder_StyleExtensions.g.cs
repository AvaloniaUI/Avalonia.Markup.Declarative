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
public static Style<T> CornerRadius<T>(this Style<T> style, CornerRadius value) where T : ExperimentalAcrylicBorder
=> style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, value);
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : ExperimentalAcrylicBorder
=> style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, binding);

public static Style<T> CornerRadius<T>(this Style<T> style, Double uniformRadius) where T : ExperimentalAcrylicBorder
   => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, new CornerRadius(uniformRadius));
public static Style<T> CornerRadius<T>(this Style<T> style, Double top, Double bottom) where T : ExperimentalAcrylicBorder
   => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, new CornerRadius(top, bottom));
public static Style<T> CornerRadius<T>(this Style<T> style, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : ExperimentalAcrylicBorder
   => style._addSetter(ExperimentalAcrylicBorder.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Style<T> Material<T>(this Style<T> style, ExperimentalAcrylicMaterial value) where T : ExperimentalAcrylicBorder
=> style._addSetter(ExperimentalAcrylicBorder.MaterialProperty, value);
public static Style<T> Material<T>(this Style<T> style, IBinding binding) where T : ExperimentalAcrylicBorder
=> style._addSetter(ExperimentalAcrylicBorder.MaterialProperty, binding);
}

