#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class UniformGrid_MarkupExtensions
{
//================= Properties ======================//
 // Rows

/*BindFromExpressionSetterGenerator*/
public static T Rows<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Rows<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._setEx(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, ps, () => control.Rows = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Rows<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Rows<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Rows<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._setEx(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, ps, () => control.Rows = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Columns

/*BindFromExpressionSetterGenerator*/
public static T Columns<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Columns<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._setEx(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, ps, () => control.Columns = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Columns<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Columns<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Columns<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._setEx(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, ps, () => control.Columns = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FirstColumn

/*BindFromExpressionSetterGenerator*/
public static T FirstColumn<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FirstColumn<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._setEx(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FirstColumn<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FirstColumn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.UniformGrid 
   => control._set(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FirstColumn<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.UniformGrid 
=> control._setEx(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Rows

/*ValueStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Rows<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.RowsProperty, binding);


 // Columns

/*ValueStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Columns<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.ColumnsProperty, binding);


 // FirstColumn

/*ValueStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstColumn<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.UniformGrid 
=> style._addSetter(Avalonia.Controls.Primitives.UniformGrid.FirstColumnProperty, binding);



}
