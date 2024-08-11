using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ViewboxExtensions
{
public static Style<T> Stretch<T>(this Style<T> style, Stretch value) where T : Viewbox
=> style._addSetter(Viewbox.StretchProperty, value);
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Viewbox
=> style._addSetter(Viewbox.StretchProperty, binding);
public static Style<T> StretchDirection<T>(this Style<T> style, StretchDirection value) where T : Viewbox
=> style._addSetter(Viewbox.StretchDirectionProperty, value);
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Viewbox
=> style._addSetter(Viewbox.StretchDirectionProperty, binding);
public static Style<T> Child<T>(this Style<T> style, Control value) where T : Viewbox
=> style._addSetter(Viewbox.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Viewbox
=> style._addSetter(Viewbox.ChildProperty, binding);
}

