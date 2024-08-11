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
public static Style<T> Rows<T>(this Style<T> style, Int32 value) where T : UniformGrid
=> style._addSetter(UniformGrid.RowsProperty, value);
public static Style<T> Rows<T>(this Style<T> style, IBinding binding) where T : UniformGrid
=> style._addSetter(UniformGrid.RowsProperty, binding);
public static Style<T> Columns<T>(this Style<T> style, Int32 value) where T : UniformGrid
=> style._addSetter(UniformGrid.ColumnsProperty, value);
public static Style<T> Columns<T>(this Style<T> style, IBinding binding) where T : UniformGrid
=> style._addSetter(UniformGrid.ColumnsProperty, binding);
public static Style<T> FirstColumn<T>(this Style<T> style, Int32 value) where T : UniformGrid
=> style._addSetter(UniformGrid.FirstColumnProperty, value);
public static Style<T> FirstColumn<T>(this Style<T> style, IBinding binding) where T : UniformGrid
=> style._addSetter(UniformGrid.FirstColumnProperty, binding);
}

