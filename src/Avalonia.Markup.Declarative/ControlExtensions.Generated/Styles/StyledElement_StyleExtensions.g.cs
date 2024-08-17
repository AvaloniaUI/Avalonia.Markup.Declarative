using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using StyledElement = Avalonia.StyledElement;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyledElementExtensions
{
public static Style<T> DataContext<T>(this Style<T> style, System.Object value) where T : Avalonia.StyledElement
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, value);
public static Style<T> DataContext<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, binding);
public static Style<T> Theme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, value);
public static Style<T> Theme<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, binding);
}

