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
public static Style<Decorator> Child(this Style<Decorator> style, Control value)
=> style._addSetter(Decorator.ChildProperty, value);
public static Style<Decorator> Child(this Style<Decorator> style, IBinding binding)
=> style._addSetter(Decorator.ChildProperty, binding);
public static Style<Decorator> Padding(this Style<Decorator> style, Thickness value)
=> style._addSetter(Decorator.PaddingProperty, value);
public static Style<Decorator> Padding(this Style<Decorator> style, IBinding binding)
=> style._addSetter(Decorator.PaddingProperty, binding);

public static Style<Decorator> Padding(this Style<Decorator> style, Double uniformLength)
   => style._addSetter(Decorator.PaddingProperty, new Thickness(uniformLength));
public static Style<Decorator> Padding(this Style<Decorator> style, Double horizontal, Double vertical)
   => style._addSetter(Decorator.PaddingProperty, new Thickness(horizontal, vertical));
public static Style<Decorator> Padding(this Style<Decorator> style, Double left, Double top, Double right, Double bottom)
   => style._addSetter(Decorator.PaddingProperty, new Thickness(left, top, right, bottom));
}

