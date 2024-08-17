using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DateTimePickerPanel = Avalonia.Controls.Primitives.DateTimePickerPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DateTimePickerPanelExtensions
{
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, value);
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, binding);
public static Style<T> PanelType<T>(this Style<T> style, Avalonia.Controls.Primitives.DateTimePickerPanelType value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, value);
public static Style<T> PanelType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, binding);
public static Style<T> ItemFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, value);
public static Style<T> ItemFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, binding);
public static Style<T> ShouldLoop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, value);
public static Style<T> ShouldLoop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> style._addSetter(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, binding);
}

