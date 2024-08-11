using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DecoratorExtensions
{
public static Style<T> Child<T>(this Style<T> style, Control value) where T : Decorator
=> style._addSetter(Decorator.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Decorator
=> style._addSetter(Decorator.ChildProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Thickness value) where T : Decorator
=> style._addSetter(Decorator.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Decorator
=> style._addSetter(Decorator.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : Decorator
   => style._addSetter(Decorator.PaddingProperty, new Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : Decorator
   => style._addSetter(Decorator.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Decorator
   => style._addSetter(Decorator.PaddingProperty, new Thickness(left, top, right, bottom));
}

