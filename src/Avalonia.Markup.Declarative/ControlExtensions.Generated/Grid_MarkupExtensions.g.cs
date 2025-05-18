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
public static partial class Grid_MarkupExtensions
{
//================= Properties ======================//
 // ShowGridLines

/*ValueSetterGenerator*/
public static T ShowGridLines<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Grid 
=> control._set(() => control.ShowGridLines = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowGridLines<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowGridLines<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowGridLines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowGridLines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ShowGridLinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowGridLines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RowSpacing

/*ValueSetterGenerator*/
public static T RowSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Grid 
=> control._set(() => control.RowSpacing = value!);

/*BindFromExpressionSetterGenerator*/
public static T RowSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.RowSpacingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RowSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.RowSpacingProperty, ps, () => control.RowSpacing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RowSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.RowSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RowSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.RowSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RowSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.RowSpacingProperty, ps, () => control.RowSpacing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ColumnSpacing

/*ValueSetterGenerator*/
public static T ColumnSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.Grid 
=> control._set(() => control.ColumnSpacing = value!);

/*BindFromExpressionSetterGenerator*/
public static T ColumnSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ColumnSpacingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ColumnSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.ColumnSpacingProperty, ps, () => control.ColumnSpacing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ColumnSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ColumnSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColumnSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Grid 
   => control._set(Avalonia.Controls.Grid.ColumnSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ColumnSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Grid 
=> control._setEx(Avalonia.Controls.Grid.ColumnSpacingProperty, ps, () => control.ColumnSpacing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // Column

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_Column<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.ColumnProperty, ps, () => Avalonia.Controls.Grid.SetColumn(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_Column<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnProperty!, func, onChanged, expression);


 // Row

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_Row<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.RowProperty, ps, () => Avalonia.Controls.Grid.SetRow(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_Row<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowProperty!, func, onChanged, expression);


 // ColumnSpan

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_ColumnSpan<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.ColumnSpanProperty, ps, () => Avalonia.Controls.Grid.SetColumnSpan(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_ColumnSpan<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.ColumnSpanProperty!, func, onChanged, expression);


 // RowSpan

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_RowSpan<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.RowSpanProperty, ps, () => Avalonia.Controls.Grid.SetRowSpan(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_RowSpan<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.RowSpanProperty!, func, onChanged, expression);


 // IsSharedSizeScope

/*AttachedPropertyMagicalSetterGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.Grid.IsSharedSizeScopeProperty, ps, () => Avalonia.Controls.Grid.SetIsSharedSizeScope(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Grid_IsSharedSizeScope<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Grid.IsSharedSizeScopeProperty!, func, onChanged, expression);



//================= Styles ======================//
 // ShowGridLines

/*ValueStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowGridLines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ShowGridLinesProperty, binding);


 // RowSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.RowSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RowSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.RowSpacingProperty, binding);


 // ColumnSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ColumnSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColumnSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Grid 
=> style._addSetter(Avalonia.Controls.Grid.ColumnSpacingProperty, binding);



}
