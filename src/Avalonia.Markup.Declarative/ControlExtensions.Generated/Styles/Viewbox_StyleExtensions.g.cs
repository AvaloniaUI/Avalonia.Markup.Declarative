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
public static Style<Viewbox> Stretch(this Style<Viewbox> style, Stretch value)
=> style._addSetter(Viewbox.StretchProperty, value);
public static Style<Viewbox> Stretch(this Style<Viewbox> style, IBinding binding)
=> style._addSetter(Viewbox.StretchProperty, binding);
public static Style<Viewbox> StretchDirection(this Style<Viewbox> style, StretchDirection value)
=> style._addSetter(Viewbox.StretchDirectionProperty, value);
public static Style<Viewbox> StretchDirection(this Style<Viewbox> style, IBinding binding)
=> style._addSetter(Viewbox.StretchDirectionProperty, binding);
public static Style<Viewbox> Child(this Style<Viewbox> style, Control value)
=> style._addSetter(Viewbox.ChildProperty, value);
public static Style<Viewbox> Child(this Style<Viewbox> style, IBinding binding)
=> style._addSetter(Viewbox.ChildProperty, binding);
}

