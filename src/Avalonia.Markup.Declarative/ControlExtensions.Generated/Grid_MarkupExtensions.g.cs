#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Grid_MarkupExtensions
{
//================= Properties ======================//
 // ShowGridLines

/*BindFromExpressionSetterGenerator*/
public static T ShowGridLines<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowGridLines<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowGridLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowGridLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowGridLines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // Column

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_Column<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.ColumnProperty, ps, () => Avalonia.Controls.Grid.SetColumn(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_Column<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnProperty, func, onChanged, expression);


 // Row

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_Row<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.RowProperty, ps, () => Avalonia.Controls.Grid.SetRow(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_Row<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowProperty, func, onChanged, expression);


 // ColumnSpan

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_ColumnSpan<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.ColumnSpanProperty, ps, () => Avalonia.Controls.Grid.SetColumnSpan(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_ColumnSpan<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnSpanProperty, func, onChanged, expression);


 // RowSpan

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_RowSpan<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.RowSpanProperty, ps, () => Avalonia.Controls.Grid.SetRowSpan(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_RowSpan<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowSpanProperty, func, onChanged, expression);


 // IsSharedSizeScope

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.IsSharedSizeScopeProperty, ps, () => Avalonia.Controls.Grid.SetIsSharedSizeScope(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.IsSharedSizeScopeProperty, func, onChanged, expression);



//================= Events ======================//

//================= Styles ======================//
 // ShowGridLines

/*ValueStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);



}
