using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Viewbox = Avalonia.Controls.Viewbox;

namespace Avalonia.Markup.Declarative;
public static partial class ViewboxExtensions
{
public static Style<T> Stretch<T>(this Style<T> style, Avalonia.Media.Stretch value) where T : Avalonia.Controls.Viewbox
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty, value);
public static Style<T> Stretch<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox
=> style._addSetter(Avalonia.Controls.Viewbox.StretchProperty, binding);
public static Style<T> StretchDirection<T>(this Style<T> style, Avalonia.Media.StretchDirection value) where T : Avalonia.Controls.Viewbox
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty, value);
public static Style<T> StretchDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox
=> style._addSetter(Avalonia.Controls.Viewbox.StretchDirectionProperty, binding);
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Viewbox
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Viewbox
=> style._addSetter(Avalonia.Controls.Viewbox.ChildProperty, binding);
}

