using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Layoutable = Avalonia.Layout.Layoutable;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutableExtensions
{
public static Style<T> Width<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty, value);
public static Style<T> Width<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.WidthProperty, binding);
public static Style<T> Height<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty, value);
public static Style<T> Height<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.HeightProperty, binding);
public static Style<T> MinWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty, value);
public static Style<T> MinWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MinWidthProperty, binding);
public static Style<T> MaxWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty, value);
public static Style<T> MaxWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MaxWidthProperty, binding);
public static Style<T> MinHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty, value);
public static Style<T> MinHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MinHeightProperty, binding);
public static Style<T> MaxHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty, value);
public static Style<T> MaxHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MaxHeightProperty, binding);
public static Style<T> Margin<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, value);
public static Style<T> Margin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, binding);

public static Style<T> Margin<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Layout.Layoutable
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> Margin<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Layout.Layoutable
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> Margin<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Layout.Layoutable
   => style._addSetter(Avalonia.Layout.Layoutable.MarginProperty, new Avalonia.Thickness(left, top, right, bottom));
public static Style<T> HorizontalAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, value);
public static Style<T> HorizontalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, binding);
public static Style<T> VerticalAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, value);
public static Style<T> VerticalAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, binding);
public static Style<T> UseLayoutRounding<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, value);
public static Style<T> UseLayoutRounding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Layout.Layoutable
=> style._addSetter(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, binding);
}

