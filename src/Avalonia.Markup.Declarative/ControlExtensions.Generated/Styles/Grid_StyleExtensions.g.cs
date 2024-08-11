using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridExtensions
{
public static Style<T> ShowGridLines<T>(this Style<T> style, Boolean value) where T : Grid
=> style._addSetter(Grid.ShowGridLinesProperty, value);
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Grid
=> style._addSetter(Grid.ShowGridLinesProperty, binding);
}

