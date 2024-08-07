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
public static Style<StyledElement> DataContext(this Style<StyledElement> style, Object value)
=> style._addSetter(StyledElement.DataContextProperty, value);
public static Style<StyledElement> DataContext(this Style<StyledElement> style, IBinding binding)
=> style._addSetter(StyledElement.DataContextProperty, binding);
public static Style<StyledElement> Name(this Style<StyledElement> style, String value)
=> style._addSetter(StyledElement.NameProperty, value);
public static Style<StyledElement> Name(this Style<StyledElement> style, IBinding binding)
=> style._addSetter(StyledElement.NameProperty, binding);
public static Style<StyledElement> Theme(this Style<StyledElement> style, ControlTheme value)
=> style._addSetter(StyledElement.ThemeProperty, value);
public static Style<StyledElement> Theme(this Style<StyledElement> style, IBinding binding)
=> style._addSetter(StyledElement.ThemeProperty, binding);
}

