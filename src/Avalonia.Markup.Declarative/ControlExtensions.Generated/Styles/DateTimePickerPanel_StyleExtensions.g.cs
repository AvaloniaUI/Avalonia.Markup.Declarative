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
public static Style<T> ItemHeight<T>(this Style<T> style, Double value) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.ItemHeightProperty, value);
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.ItemHeightProperty, binding);
public static Style<T> PanelType<T>(this Style<T> style, DateTimePickerPanelType value) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.PanelTypeProperty, value);
public static Style<T> PanelType<T>(this Style<T> style, IBinding binding) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.PanelTypeProperty, binding);
public static Style<T> ItemFormat<T>(this Style<T> style, String value) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.ItemFormatProperty, value);
public static Style<T> ItemFormat<T>(this Style<T> style, IBinding binding) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.ItemFormatProperty, binding);
public static Style<T> ShouldLoop<T>(this Style<T> style, Boolean value) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.ShouldLoopProperty, value);
public static Style<T> ShouldLoop<T>(this Style<T> style, IBinding binding) where T : DateTimePickerPanel
=> style._addSetter(DateTimePickerPanel.ShouldLoopProperty, binding);
}

