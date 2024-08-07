using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutableExtensions
{
public static Style<T> Width<T>(this Style<T> style, Double value) where T : Layoutable
=> style._addSetter(Layoutable.WidthProperty, value);
public static Style<T> Width<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.WidthProperty, binding);
public static Style<T> Height<T>(this Style<T> style, Double value) where T : Layoutable
=> style._addSetter(Layoutable.HeightProperty, value);
public static Style<T> Height<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.HeightProperty, binding);
public static Style<T> MinWidth<T>(this Style<T> style, Double value) where T : Layoutable
=> style._addSetter(Layoutable.MinWidthProperty, value);
public static Style<T> MinWidth<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.MinWidthProperty, binding);
public static Style<T> MaxWidth<T>(this Style<T> style, Double value) where T : Layoutable
=> style._addSetter(Layoutable.MaxWidthProperty, value);
public static Style<T> MaxWidth<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.MaxWidthProperty, binding);
public static Style<T> MinHeight<T>(this Style<T> style, Double value) where T : Layoutable
=> style._addSetter(Layoutable.MinHeightProperty, value);
public static Style<T> MinHeight<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.MinHeightProperty, binding);
public static Style<T> MaxHeight<T>(this Style<T> style, Double value) where T : Layoutable
=> style._addSetter(Layoutable.MaxHeightProperty, value);
public static Style<T> MaxHeight<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.MaxHeightProperty, binding);
public static Style<T> Margin<T>(this Style<T> style, Thickness value) where T : Layoutable
=> style._addSetter(Layoutable.MarginProperty, value);
public static Style<T> Margin<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.MarginProperty, binding);

public static Style<T> Margin<T>(this Style<T> style, Double uniformLength) where T : Layoutable
   => style._addSetter(Layoutable.MarginProperty, new Thickness(uniformLength));
public static Style<T> Margin<T>(this Style<T> style, Double horizontal, Double vertical) where T : Layoutable
   => style._addSetter(Layoutable.MarginProperty, new Thickness(horizontal, vertical));
public static Style<T> Margin<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Layoutable
   => style._addSetter(Layoutable.MarginProperty, new Thickness(left, top, right, bottom));
public static Style<T> HorizontalAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : Layoutable
=> style._addSetter(Layoutable.HorizontalAlignmentProperty, value);
public static Style<T> HorizontalAlignment<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.HorizontalAlignmentProperty, binding);
public static Style<T> VerticalAlignment<T>(this Style<T> style, VerticalAlignment value) where T : Layoutable
=> style._addSetter(Layoutable.VerticalAlignmentProperty, value);
public static Style<T> VerticalAlignment<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.VerticalAlignmentProperty, binding);
public static Style<T> UseLayoutRounding<T>(this Style<T> style, Boolean value) where T : Layoutable
=> style._addSetter(Layoutable.UseLayoutRoundingProperty, value);
public static Style<T> UseLayoutRounding<T>(this Style<T> style, IBinding binding) where T : Layoutable
=> style._addSetter(Layoutable.UseLayoutRoundingProperty, binding);
}

