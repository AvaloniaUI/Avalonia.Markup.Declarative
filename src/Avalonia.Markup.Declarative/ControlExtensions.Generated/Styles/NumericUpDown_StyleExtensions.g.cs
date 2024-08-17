using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using NumericUpDown = Avalonia.Controls.NumericUpDown;
using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class NumericUpDownExtensions
{
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty, value);
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.AllowSpinProperty, binding);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, value);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ButtonSpinnerLocationProperty, binding);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, value);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ShowButtonSpinnerProperty, binding);
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, value);
public static Style<T> ClipValueToMinMax<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ClipValueToMinMaxProperty, binding);
public static Style<T> NumberFormat<T>(this Style<T> style, System.Globalization.NumberFormatInfo value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty, value);
public static Style<T> NumberFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.NumberFormatProperty, binding);
public static Style<T> FormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty, value);
public static Style<T> FormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.FormatStringProperty, binding);
public static Style<T> Increment<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty, value);
public static Style<T> Increment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.IncrementProperty, binding);
public static Style<T> IsReadOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, value);
public static Style<T> IsReadOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.IsReadOnlyProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.MaximumProperty, binding);
public static Style<T> Minimum<T>(this Style<T> style, System.Decimal value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.MinimumProperty, binding);
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, System.Globalization.NumberStyles value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, value);
public static Style<T> ParsingNumberStyle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ParsingNumberStyleProperty, binding);
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextProperty, binding);
public static Style<T> TextConverter<T>(this Style<T> style, Avalonia.Data.Converters.IValueConverter value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty, value);
public static Style<T> TextConverter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextConverterProperty, binding);
public static Style<T> Value<T>(this Style<T> style, System.Nullable<System.Decimal> value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty, value);
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.ValueProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.WatermarkProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.VerticalContentAlignmentProperty, binding);
public static Style<T> TextAlignment<T>(this Style<T> style, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, value);
public static Style<T> TextAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.TextAlignmentProperty, binding);
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, value);
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerLeftContentProperty, binding);
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, value);
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.NumericUpDown
=> style._addSetter(Avalonia.Controls.NumericUpDown.InnerRightContentProperty, binding);
}

