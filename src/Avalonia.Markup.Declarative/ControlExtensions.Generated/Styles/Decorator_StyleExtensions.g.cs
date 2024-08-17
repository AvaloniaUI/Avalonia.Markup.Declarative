using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Decorator = Avalonia.Controls.Decorator;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DecoratorExtensions
{
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Decorator
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator
=> style._addSetter(Avalonia.Controls.Decorator.ChildProperty, binding);
public static Style<T> Padding<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, value);
public static Style<T> Padding<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Decorator
=> style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, binding);

public static Style<T> Padding<T>(this Style<T> style, Double uniformLength) where T : Avalonia.Controls.Decorator
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(uniformLength));
public static Style<T> Padding<T>(this Style<T> style, Double horizontal, Double vertical) where T : Avalonia.Controls.Decorator
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(horizontal, vertical));
public static Style<T> Padding<T>(this Style<T> style, Double left, Double top, Double right, Double bottom) where T : Avalonia.Controls.Decorator
   => style._addSetter(Avalonia.Controls.Decorator.PaddingProperty, new Avalonia.Thickness(left, top, right, bottom));
}

