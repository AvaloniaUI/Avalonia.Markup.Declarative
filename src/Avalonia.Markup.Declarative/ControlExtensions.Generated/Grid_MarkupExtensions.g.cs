#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Grid_MarkupExtensions
{
//================= Properties ======================//
 // ShowGridLinesProperty

/*BindFromExpressionSetterGenerator*/
public static T ShowGridLines<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Grid
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowGridLines<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Grid
=> control._setEx(Avalonia.Controls.Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowGridLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Grid
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowGridLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Grid
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowGridLines<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Grid
=> control._setEx(Avalonia.Controls.Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // ShowGridLinesProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Grid
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);



}
