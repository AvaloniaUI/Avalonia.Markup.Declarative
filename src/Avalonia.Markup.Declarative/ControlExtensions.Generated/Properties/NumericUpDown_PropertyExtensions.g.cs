#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NumericUpDownExtensions
{
public static NumericUpDown AllowSpin(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.AllowSpinProperty, binding);
public static NumericUpDown AllowSpin(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.AllowSpinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown AllowSpin(this NumericUpDown control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.AllowSpinProperty, func, onChanged, expression);
public static NumericUpDown AllowSpin(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static NumericUpDown AllowSpin<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ButtonSpinnerLocationProperty, binding);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, Func<Location> func, Action<Location>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ButtonSpinnerLocationProperty, func, onChanged, expression);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static NumericUpDown ButtonSpinnerLocation<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ShowButtonSpinnerProperty, binding);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ShowButtonSpinnerProperty, func, onChanged, expression);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static NumericUpDown ShowButtonSpinner<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ClipValueToMinMaxProperty, binding);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.ClipValueToMinMaxProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ClipValueToMinMaxProperty, func, onChanged, expression);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = value, bindingMode, converter, bindingSource);
public static NumericUpDown ClipValueToMinMax<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown NumberFormat(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.NumberFormatProperty, binding);
public static NumericUpDown NumberFormat(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.NumberFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown NumberFormat(this NumericUpDown control, Func<NumberFormatInfo> func, Action<NumberFormatInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.NumberFormatProperty, func, onChanged, expression);
public static NumericUpDown NumberFormat(this NumericUpDown control, NumberFormatInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = value, bindingMode, converter, bindingSource);
public static NumericUpDown NumberFormat<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, NumberFormatInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown FormatString(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.FormatStringProperty, binding);
public static NumericUpDown FormatString(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.FormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown FormatString(this NumericUpDown control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.FormatStringProperty, func, onChanged, expression);
public static NumericUpDown FormatString(this NumericUpDown control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.FormatStringProperty, ps, () => control.FormatString = value, bindingMode, converter, bindingSource);
public static NumericUpDown FormatString<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.FormatStringProperty, ps, () => control.FormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Increment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.IncrementProperty, binding);
public static NumericUpDown Increment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.IncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown Increment(this NumericUpDown control, Func<Decimal> func, Action<Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.IncrementProperty, func, onChanged, expression);
public static NumericUpDown Increment(this NumericUpDown control, Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IncrementProperty, ps, () => control.Increment = value, bindingMode, converter, bindingSource);
public static NumericUpDown Increment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IncrementProperty, ps, () => control.Increment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown IsReadOnly(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.IsReadOnlyProperty, binding);
public static NumericUpDown IsReadOnly(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown IsReadOnly(this NumericUpDown control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.IsReadOnlyProperty, func, onChanged, expression);
public static NumericUpDown IsReadOnly(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);
public static NumericUpDown IsReadOnly<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Maximum(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.MaximumProperty, binding);
public static NumericUpDown Maximum(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown Maximum(this NumericUpDown control, Func<Decimal> func, Action<Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.MaximumProperty, func, onChanged, expression);
public static NumericUpDown Maximum(this NumericUpDown control, Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static NumericUpDown Maximum<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Minimum(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.MinimumProperty, binding);
public static NumericUpDown Minimum(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown Minimum(this NumericUpDown control, Func<Decimal> func, Action<Decimal>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.MinimumProperty, func, onChanged, expression);
public static NumericUpDown Minimum(this NumericUpDown control, Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static NumericUpDown Minimum<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ParsingNumberStyleProperty, binding);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.ParsingNumberStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, Func<NumberStyles> func, Action<NumberStyles>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ParsingNumberStyleProperty, func, onChanged, expression);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, NumberStyles value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = value, bindingMode, converter, bindingSource);
public static NumericUpDown ParsingNumberStyle<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, NumberStyles> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Text(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.TextProperty, binding);
public static NumericUpDown Text(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown Text(this NumericUpDown control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.TextProperty, func, onChanged, expression);
public static NumericUpDown Text(this NumericUpDown control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static NumericUpDown Text<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown TextConverter(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.TextConverterProperty, binding);
public static NumericUpDown TextConverter(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.TextConverterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown TextConverter(this NumericUpDown control, Func<IValueConverter> func, Action<IValueConverter>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.TextConverterProperty, func, onChanged, expression);
public static NumericUpDown TextConverter(this NumericUpDown control, IValueConverter value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = value, bindingMode, converter, bindingSource);
public static NumericUpDown TextConverter<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, IValueConverter> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Value(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ValueProperty, binding);
public static NumericUpDown Value(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown Value(this NumericUpDown control, Func<Nullable<Decimal>> func, Action<Nullable<Decimal>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ValueProperty, func, onChanged, expression);
public static NumericUpDown Value(this NumericUpDown control, Nullable<Decimal> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static NumericUpDown Value<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Nullable<Decimal>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Watermark(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.WatermarkProperty, binding);
public static NumericUpDown Watermark(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown Watermark(this NumericUpDown control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.WatermarkProperty, func, onChanged, expression);
public static NumericUpDown Watermark(this NumericUpDown control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static NumericUpDown Watermark<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.HorizontalContentAlignmentProperty, binding);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static NumericUpDown HorizontalContentAlignment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.VerticalContentAlignmentProperty, binding);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.VerticalContentAlignmentProperty, func, onChanged, expression);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static NumericUpDown VerticalContentAlignment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown TextAlignment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.TextAlignmentProperty, binding);
public static NumericUpDown TextAlignment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.TextAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown TextAlignment(this NumericUpDown control, Func<TextAlignment> func, Action<TextAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.TextAlignmentProperty, func, onChanged, expression);
public static NumericUpDown TextAlignment(this NumericUpDown control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static NumericUpDown TextAlignment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown InnerLeftContent(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.InnerLeftContentProperty, binding);
public static NumericUpDown InnerLeftContent(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown InnerLeftContent(this NumericUpDown control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.InnerLeftContentProperty, func, onChanged, expression);
public static NumericUpDown InnerLeftContent(this NumericUpDown control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static NumericUpDown InnerLeftContent<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown InnerRightContent(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.InnerRightContentProperty, binding);
public static NumericUpDown InnerRightContent(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NumericUpDown.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NumericUpDown InnerRightContent(this NumericUpDown control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.InnerRightContentProperty, func, onChanged, expression);
public static NumericUpDown InnerRightContent(this NumericUpDown control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static NumericUpDown InnerRightContent<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

