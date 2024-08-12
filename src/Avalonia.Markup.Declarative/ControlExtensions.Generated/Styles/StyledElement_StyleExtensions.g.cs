using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyledElementExtensions
{
public static Style<T> DataContext<T>(this Style<T> style, Object value) where T : StyledElement
=> style._addSetter(StyledElement.DataContextProperty, value);
public static Style<T> DataContext<T>(this Style<T> style, IBinding binding) where T : StyledElement
=> style._addSetter(StyledElement.DataContextProperty, binding);
public static Style<T> Name<T>(this Style<T> style, String value) where T : StyledElement
=> style._addSetter(StyledElement.NameProperty, value);
public static Style<T> Name<T>(this Style<T> style, IBinding binding) where T : StyledElement
=> style._addSetter(StyledElement.NameProperty, binding);
public static Style<T> Theme<T>(this Style<T> style, ControlTheme value) where T : StyledElement
=> style._addSetter(StyledElement.ThemeProperty, value);
public static Style<T> Theme<T>(this Style<T> style, IBinding binding) where T : StyledElement
=> style._addSetter(StyledElement.ThemeProperty, binding);
}

