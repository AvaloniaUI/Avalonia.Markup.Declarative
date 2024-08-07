#nullable enable
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
public static UniformGrid Rows(this UniformGrid control, IBinding binding)
   => control._set(UniformGrid.RowsProperty, binding);
public static UniformGrid Rows(this UniformGrid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(UniformGrid.RowsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static UniformGrid Rows(this UniformGrid control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(UniformGrid.RowsProperty, func, onChanged, expression);
public static UniformGrid Rows(this UniformGrid control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.RowsProperty, ps, () => control.Rows = value, bindingMode, converter, bindingSource);
public static UniformGrid Rows<TValue>(this UniformGrid control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.RowsProperty, ps, () => control.Rows = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static UniformGrid Columns(this UniformGrid control, IBinding binding)
   => control._set(UniformGrid.ColumnsProperty, binding);
public static UniformGrid Columns(this UniformGrid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(UniformGrid.ColumnsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static UniformGrid Columns(this UniformGrid control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(UniformGrid.ColumnsProperty, func, onChanged, expression);
public static UniformGrid Columns(this UniformGrid control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.ColumnsProperty, ps, () => control.Columns = value, bindingMode, converter, bindingSource);
public static UniformGrid Columns<TValue>(this UniformGrid control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.ColumnsProperty, ps, () => control.Columns = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static UniformGrid FirstColumn(this UniformGrid control, IBinding binding)
   => control._set(UniformGrid.FirstColumnProperty, binding);
public static UniformGrid FirstColumn(this UniformGrid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(UniformGrid.FirstColumnProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static UniformGrid FirstColumn(this UniformGrid control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(UniformGrid.FirstColumnProperty, func, onChanged, expression);
public static UniformGrid FirstColumn(this UniformGrid control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = value, bindingMode, converter, bindingSource);
public static UniformGrid FirstColumn<TValue>(this UniformGrid control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

