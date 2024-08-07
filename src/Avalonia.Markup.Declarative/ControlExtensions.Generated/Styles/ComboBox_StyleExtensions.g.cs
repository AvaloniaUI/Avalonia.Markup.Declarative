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
public static Style<ComboBox> IsDropDownOpen(this Style<ComboBox> style, Boolean value)
=> style._addSetter(ComboBox.IsDropDownOpenProperty, value);
public static Style<ComboBox> IsDropDownOpen(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.IsDropDownOpenProperty, binding);
public static Style<ComboBox> MaxDropDownHeight(this Style<ComboBox> style, Double value)
=> style._addSetter(ComboBox.MaxDropDownHeightProperty, value);
public static Style<ComboBox> MaxDropDownHeight(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.MaxDropDownHeightProperty, binding);
public static Style<ComboBox> PlaceholderText(this Style<ComboBox> style, String value)
=> style._addSetter(ComboBox.PlaceholderTextProperty, value);
public static Style<ComboBox> PlaceholderText(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.PlaceholderTextProperty, binding);
public static Style<ComboBox> PlaceholderForeground(this Style<ComboBox> style, IBrush value)
=> style._addSetter(ComboBox.PlaceholderForegroundProperty, value);
public static Style<ComboBox> PlaceholderForeground(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.PlaceholderForegroundProperty, binding);
public static Style<ComboBox> HorizontalContentAlignment(this Style<ComboBox> style, HorizontalAlignment value)
=> style._addSetter(ComboBox.HorizontalContentAlignmentProperty, value);
public static Style<ComboBox> HorizontalContentAlignment(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.HorizontalContentAlignmentProperty, binding);
public static Style<ComboBox> VerticalContentAlignment(this Style<ComboBox> style, VerticalAlignment value)
=> style._addSetter(ComboBox.VerticalContentAlignmentProperty, value);
public static Style<ComboBox> VerticalContentAlignment(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.VerticalContentAlignmentProperty, binding);
public static Style<ComboBox> SelectionBoxItemTemplate(this Style<ComboBox> style, IDataTemplate value)
=> style._addSetter(ComboBox.SelectionBoxItemTemplateProperty, value);
public static Style<ComboBox> SelectionBoxItemTemplate(this Style<ComboBox> style, IBinding binding)
=> style._addSetter(ComboBox.SelectionBoxItemTemplateProperty, binding);
}

