using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Grid = Avalonia.Controls.Grid;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridExtensions
{
public static Style<T> ShowGridLines<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Grid
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, value);
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);
}

