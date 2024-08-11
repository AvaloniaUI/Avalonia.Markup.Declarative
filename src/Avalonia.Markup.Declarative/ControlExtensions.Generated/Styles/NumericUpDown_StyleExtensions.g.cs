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
public static Style<T> AllowSpin<T>(this Style<T> style, Boolean value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.AllowSpinProperty, value);
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.AllowSpinProperty, binding);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Location value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ButtonSpinnerLocationProperty, value);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ButtonSpinnerLocationProperty, binding);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, Boolean value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ShowButtonSpinnerProperty, value);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ShowButtonSpinnerProperty, binding);
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, Boolean value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ClipValueToMinMaxProperty, value);
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ClipValueToMinMaxProperty, binding);
public static Style<T> NumberFormat<T>(this Style<T> style, NumberFormatInfo value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.NumberFormatProperty, value);
public static Style<T> NumberFormat<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.NumberFormatProperty, binding);
public static Style<T> FormatString<T>(this Style<T> style, String value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.FormatStringProperty, value);
public static Style<T> FormatString<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.FormatStringProperty, binding);
public static Style<T> Increment<T>(this Style<T> style, Decimal value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.IncrementProperty, value);
public static Style<T> Increment<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.IncrementProperty, binding);
public static Style<T> IsReadOnly<T>(this Style<T> style, Boolean value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.IsReadOnlyProperty, value);
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.IsReadOnlyProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, Decimal value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.MaximumProperty, binding);
public static Style<T> Minimum<T>(this Style<T> style, Decimal value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.MinimumProperty, binding);
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, NumberStyles value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ParsingNumberStyleProperty, value);
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ParsingNumberStyleProperty, binding);
public static Style<T> Text<T>(this Style<T> style, String value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.TextProperty, binding);
public static Style<T> TextConverter<T>(this Style<T> style, IValueConverter value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.TextConverterProperty, value);
public static Style<T> TextConverter<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.TextConverterProperty, binding);
public static Style<T> Value<T>(this Style<T> style, Nullable<Decimal> value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ValueProperty, value);
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.ValueProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, String value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.WatermarkProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.VerticalContentAlignmentProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, TextAlignment value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.TextAlignmentProperty, binding);
public static Style<T> InnerLeftContent<T>(this Style<T> style, Object value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.InnerLeftContentProperty, value);
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.InnerLeftContentProperty, binding);
public static Style<T> InnerRightContent<T>(this Style<T> style, Object value) where T : NumericUpDown
=> style._addSetter(NumericUpDown.InnerRightContentProperty, value);
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : NumericUpDown
=> style._addSetter(NumericUpDown.InnerRightContentProperty, binding);
}

