using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DateTimePickerPanelExtensions
{
public static Style<DateTimePickerPanel> ItemHeight(this Style<DateTimePickerPanel> style, Double value)
=> style._addSetter(DateTimePickerPanel.ItemHeightProperty, value);
public static Style<DateTimePickerPanel> ItemHeight(this Style<DateTimePickerPanel> style, IBinding binding)
=> style._addSetter(DateTimePickerPanel.ItemHeightProperty, binding);
public static Style<DateTimePickerPanel> PanelType(this Style<DateTimePickerPanel> style, DateTimePickerPanelType value)
=> style._addSetter(DateTimePickerPanel.PanelTypeProperty, value);
public static Style<DateTimePickerPanel> PanelType(this Style<DateTimePickerPanel> style, IBinding binding)
=> style._addSetter(DateTimePickerPanel.PanelTypeProperty, binding);
public static Style<DateTimePickerPanel> ItemFormat(this Style<DateTimePickerPanel> style, String value)
=> style._addSetter(DateTimePickerPanel.ItemFormatProperty, value);
public static Style<DateTimePickerPanel> ItemFormat(this Style<DateTimePickerPanel> style, IBinding binding)
=> style._addSetter(DateTimePickerPanel.ItemFormatProperty, binding);
public static Style<DateTimePickerPanel> ShouldLoop(this Style<DateTimePickerPanel> style, Boolean value)
=> style._addSetter(DateTimePickerPanel.ShouldLoopProperty, value);
public static Style<DateTimePickerPanel> ShouldLoop(this Style<DateTimePickerPanel> style, IBinding binding)
=> style._addSetter(DateTimePickerPanel.ShouldLoopProperty, binding);
}

