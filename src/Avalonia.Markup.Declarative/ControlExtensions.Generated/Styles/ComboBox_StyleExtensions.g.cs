using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using ComboBox = Avalonia.Controls.ComboBox;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ComboBoxExtensions
{
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, value);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, value);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);
public static Style<T> PlaceholderText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty, value);
public static Style<T> PlaceholderText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);
public static Style<T> PlaceholderForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, value);
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, value);
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);
}

