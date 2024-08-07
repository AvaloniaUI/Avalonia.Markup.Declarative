using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class UniformGridExtensions
{
public static Style<UniformGrid> Rows(this Style<UniformGrid> style, Int32 value)
=> style._addSetter(UniformGrid.RowsProperty, value);
public static Style<UniformGrid> Rows(this Style<UniformGrid> style, IBinding binding)
=> style._addSetter(UniformGrid.RowsProperty, binding);
public static Style<UniformGrid> Columns(this Style<UniformGrid> style, Int32 value)
=> style._addSetter(UniformGrid.ColumnsProperty, value);
public static Style<UniformGrid> Columns(this Style<UniformGrid> style, IBinding binding)
=> style._addSetter(UniformGrid.ColumnsProperty, binding);
public static Style<UniformGrid> FirstColumn(this Style<UniformGrid> style, Int32 value)
=> style._addSetter(UniformGrid.FirstColumnProperty, value);
public static Style<UniformGrid> FirstColumn(this Style<UniformGrid> style, IBinding binding)
=> style._addSetter(UniformGrid.FirstColumnProperty, binding);
}

