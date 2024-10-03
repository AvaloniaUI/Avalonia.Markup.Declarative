#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class NumericUpDown_MarkupExtensions
{
//================= Properties ======================//
 // AllowSpin

/*BindFromExpressionSetterGenerator*/
public static T AllowSpin<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AllowSpin<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowSpin<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowSpin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.AllowSpinProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AllowSpin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ButtonSpinnerLocation

/*BindFromExpressionSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func, Action<Avalonia.Controls.Location>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control,Avalonia.Controls.Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ButtonSpinnerLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ButtonSpinnerLocation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ShowButtonSpinner

/*BindFromExpressionSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowButtonSpinner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowButtonSpinner<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ClipValueToMinMax

/*BindFromExpressionSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClipValueToMinMax<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ClipValueToMinMax<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // NumberFormat

/*BindFromExpressionSetterGenerator*/
public static T NumberFormat<T>(this T control, Func<System.Globalization.NumberFormatInfo> func, Action<System.Globalization.NumberFormatInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T NumberFormat<T>(this T control,System.Globalization.NumberFormatInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T NumberFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T NumberFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.NumberFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T NumberFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Globalization.NumberFormatInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FormatString

/*BindFromExpressionSetterGenerator*/
public static T FormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FormatString<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.FormatStringProperty, ps, () => control.FormatString = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FormatString<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FormatString<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.FormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FormatString<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.FormatStringProperty, ps, () => control.FormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Increment

/*BindFromExpressionSetterGenerator*/
public static T Increment<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Increment<T>(this T control,System.Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.IncrementProperty, ps, () => control.Increment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Increment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Increment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Increment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.IncrementProperty, ps, () => control.Increment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsReadOnly

/*BindFromExpressionSetterGenerator*/
public static T IsReadOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsReadOnly<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsReadOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsReadOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsReadOnly<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Maximum

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Maximum<T>(this T control,System.Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Maximum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Minimum

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Decimal> func, Action<System.Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Minimum<T>(this T control,System.Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Minimum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ParsingNumberStyle

/*BindFromExpressionSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, Func<System.Globalization.NumberStyles> func, Action<System.Globalization.NumberStyles>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control,System.Globalization.NumberStyles value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ParsingNumberStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ParsingNumberStyle<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Globalization.NumberStyles> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Text

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextConverter

/*BindFromExpressionSetterGenerator*/
public static T TextConverter<T>(this T control, Func<Avalonia.Data.Converters.IValueConverter> func, Action<Avalonia.Data.Converters.IValueConverter>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextConverter<T>(this T control,Avalonia.Data.Converters.IValueConverter value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextConverter<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextConverter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextConverterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextConverter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.Converters.IValueConverter> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Value

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Nullable<System.Decimal>> func, Action<System.Nullable<System.Decimal>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Value<T>(this T control,System.Nullable<System.Decimal> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Value<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Decimal>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Watermark

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextAlignment

/*BindFromExpressionSetterGenerator*/
public static T TextAlignment<T>(this T control, Func<Avalonia.Media.TextAlignment> func, Action<Avalonia.Media.TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextAlignment<T>(this T control,Avalonia.Media.TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InnerLeftContent

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InnerRightContent

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NumericUpDown 
   => control._set(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NumericUpDown 
=> control._setEx(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Spinned

/*ActionToEventGenerator*/
public static T OnSpinned<T>(this T control, Action<Avalonia.Controls.SpinEventArgs> action) where T : Avalonia.Controls.NumericUpDown  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.SpinEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Spinned += h);


 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.NumericUpDownValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.NumericUpDown 
{
  control.AddHandler(Avalonia.Controls.NumericUpDown.ValueChangedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // AllowSpin

/*ValueStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty, binding);


 // ButtonSpinnerLocation

/*ValueStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, binding);


 // ShowButtonSpinner

/*ValueStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, binding);


 // ClipValueToMinMax

/*ValueStyleSetterGenerator*/
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, binding);


 // NumberFormat

/*ValueStyleSetterGenerator*/
public static Style<T> NumberFormat<T>(this Style<T> style, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> NumberFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty, binding);


 // FormatString

/*ValueStyleSetterGenerator*/
public static Style<T> FormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty, binding);


 // Increment

/*ValueStyleSetterGenerator*/
public static Style<T> Increment<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Increment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty, binding);


 // IsReadOnly

/*ValueStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty, binding);


 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty, binding);


 // ParsingNumberStyle

/*ValueStyleSetterGenerator*/
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty, binding);


 // TextConverter

/*ValueStyleSetterGenerator*/
public static Style<T> TextConverter<T>(this Style<T> style, Avalonia.Data.Converters.IValueConverter value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextConverter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Nullable<System.Decimal> value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, binding);


 // TextAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown 
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, binding);



}
