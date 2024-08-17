using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using UniformGrid = Avalonia.Controls.Primitives.UniformGrid;

namespace Avalonia.Markup.Declarative;
public static partial class UniformGridExtensions
{
public static Style<T> Rows<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, value);
public static Style<T> Rows<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);
public static Style<T> Columns<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, value);
public static Style<T> Columns<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);
public static Style<T> FirstColumn<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, value);
public static Style<T> FirstColumn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);
}

