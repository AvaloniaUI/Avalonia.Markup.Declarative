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
public static Style<NumericUpDown> AllowSpin(this Style<NumericUpDown> style, Boolean value)
=> style._addSetter(NumericUpDown.AllowSpinProperty, value);
public static Style<NumericUpDown> AllowSpin(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.AllowSpinProperty, binding);
public static Style<NumericUpDown> ButtonSpinnerLocation(this Style<NumericUpDown> style, Location value)
=> style._addSetter(NumericUpDown.ButtonSpinnerLocationProperty, value);
public static Style<NumericUpDown> ButtonSpinnerLocation(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.ButtonSpinnerLocationProperty, binding);
public static Style<NumericUpDown> ShowButtonSpinner(this Style<NumericUpDown> style, Boolean value)
=> style._addSetter(NumericUpDown.ShowButtonSpinnerProperty, value);
public static Style<NumericUpDown> ShowButtonSpinner(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.ShowButtonSpinnerProperty, binding);
public static Style<NumericUpDown> ClipValueToMinMax(this Style<NumericUpDown> style, Boolean value)
=> style._addSetter(NumericUpDown.ClipValueToMinMaxProperty, value);
public static Style<NumericUpDown> ClipValueToMinMax(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.ClipValueToMinMaxProperty, binding);
public static Style<NumericUpDown> NumberFormat(this Style<NumericUpDown> style, NumberFormatInfo value)
=> style._addSetter(NumericUpDown.NumberFormatProperty, value);
public static Style<NumericUpDown> NumberFormat(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.NumberFormatProperty, binding);
public static Style<NumericUpDown> FormatString(this Style<NumericUpDown> style, String value)
=> style._addSetter(NumericUpDown.FormatStringProperty, value);
public static Style<NumericUpDown> FormatString(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.FormatStringProperty, binding);
public static Style<NumericUpDown> Increment(this Style<NumericUpDown> style, Decimal value)
=> style._addSetter(NumericUpDown.IncrementProperty, value);
public static Style<NumericUpDown> Increment(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.IncrementProperty, binding);
public static Style<NumericUpDown> IsReadOnly(this Style<NumericUpDown> style, Boolean value)
=> style._addSetter(NumericUpDown.IsReadOnlyProperty, value);
public static Style<NumericUpDown> IsReadOnly(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.IsReadOnlyProperty, binding);
public static Style<NumericUpDown> Maximum(this Style<NumericUpDown> style, Decimal value)
=> style._addSetter(NumericUpDown.MaximumProperty, value);
public static Style<NumericUpDown> Maximum(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.MaximumProperty, binding);
public static Style<NumericUpDown> Minimum(this Style<NumericUpDown> style, Decimal value)
=> style._addSetter(NumericUpDown.MinimumProperty, value);
public static Style<NumericUpDown> Minimum(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.MinimumProperty, binding);
public static Style<NumericUpDown> ParsingNumberStyle(this Style<NumericUpDown> style, NumberStyles value)
=> style._addSetter(NumericUpDown.ParsingNumberStyleProperty, value);
public static Style<NumericUpDown> ParsingNumberStyle(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.ParsingNumberStyleProperty, binding);
public static Style<NumericUpDown> Text(this Style<NumericUpDown> style, String value)
=> style._addSetter(NumericUpDown.TextProperty, value);
public static Style<NumericUpDown> Text(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.TextProperty, binding);
public static Style<NumericUpDown> TextConverter(this Style<NumericUpDown> style, IValueConverter value)
=> style._addSetter(NumericUpDown.TextConverterProperty, value);
public static Style<NumericUpDown> TextConverter(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.TextConverterProperty, binding);
public static Style<NumericUpDown> Value(this Style<NumericUpDown> style, Nullable<Decimal> value)
=> style._addSetter(NumericUpDown.ValueProperty, value);
public static Style<NumericUpDown> Value(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.ValueProperty, binding);
public static Style<NumericUpDown> Watermark(this Style<NumericUpDown> style, String value)
=> style._addSetter(NumericUpDown.WatermarkProperty, value);
public static Style<NumericUpDown> Watermark(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.WatermarkProperty, binding);
public static Style<NumericUpDown> HorizontalContentAlignment(this Style<NumericUpDown> style, HorizontalAlignment value)
=> style._addSetter(NumericUpDown.HorizontalContentAlignmentProperty, value);
public static Style<NumericUpDown> HorizontalContentAlignment(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.HorizontalContentAlignmentProperty, binding);
public static Style<NumericUpDown> VerticalContentAlignment(this Style<NumericUpDown> style, VerticalAlignment value)
=> style._addSetter(NumericUpDown.VerticalContentAlignmentProperty, value);
public static Style<NumericUpDown> VerticalContentAlignment(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.VerticalContentAlignmentProperty, binding);
public static Style<NumericUpDown> TextAlignment(this Style<NumericUpDown> style, TextAlignment value)
=> style._addSetter(NumericUpDown.TextAlignmentProperty, value);
public static Style<NumericUpDown> TextAlignment(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.TextAlignmentProperty, binding);
public static Style<NumericUpDown> InnerLeftContent(this Style<NumericUpDown> style, Object value)
=> style._addSetter(NumericUpDown.InnerLeftContentProperty, value);
public static Style<NumericUpDown> InnerLeftContent(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.InnerLeftContentProperty, binding);
public static Style<NumericUpDown> InnerRightContent(this Style<NumericUpDown> style, Object value)
=> style._addSetter(NumericUpDown.InnerRightContentProperty, value);
public static Style<NumericUpDown> InnerRightContent(this Style<NumericUpDown> style, IBinding binding)
=> style._addSetter(NumericUpDown.InnerRightContentProperty, binding);
}

