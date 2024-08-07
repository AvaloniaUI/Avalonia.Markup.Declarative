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
public static Style<Grid> ShowGridLines(this Style<Grid> style, Boolean value)
=> style._addSetter(Grid.ShowGridLinesProperty, value);
public static Style<Grid> ShowGridLines(this Style<Grid> style, IBinding binding)
=> style._addSetter(Grid.ShowGridLinesProperty, binding);
}

