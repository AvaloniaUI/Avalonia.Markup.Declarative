using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ComboBoxExtensions
{
public static Style<T> IsDropDownOpen<T>(this Style<T> style, Boolean value) where T : ComboBox
=> style._addSetter(ComboBox.IsDropDownOpenProperty, value);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.IsDropDownOpenProperty, binding);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, Double value) where T : ComboBox
=> style._addSetter(ComboBox.MaxDropDownHeightProperty, value);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.MaxDropDownHeightProperty, binding);
public static Style<T> PlaceholderText<T>(this Style<T> style, String value) where T : ComboBox
=> style._addSetter(ComboBox.PlaceholderTextProperty, value);
public static Style<T> PlaceholderText<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.PlaceholderTextProperty, binding);
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBrush value) where T : ComboBox
=> style._addSetter(ComboBox.PlaceholderForegroundProperty, value);
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.PlaceholderForegroundProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : ComboBox
=> style._addSetter(ComboBox.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : ComboBox
=> style._addSetter(ComboBox.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.VerticalContentAlignmentProperty, binding);
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IDataTemplate value) where T : ComboBox
=> style._addSetter(ComboBox.SelectionBoxItemTemplateProperty, value);
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IBinding binding) where T : ComboBox
=> style._addSetter(ComboBox.SelectionBoxItemTemplateProperty, binding);
}

