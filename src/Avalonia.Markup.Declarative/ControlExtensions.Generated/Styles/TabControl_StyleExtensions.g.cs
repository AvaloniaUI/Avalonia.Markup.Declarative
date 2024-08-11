using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TabControlExtensions
{
public static Style<T> TabStripPlacement<T>(this Style<T> style, Dock value) where T : TabControl
=> style._addSetter(TabControl.TabStripPlacementProperty, value);
public static Style<T> TabStripPlacement<T>(this Style<T> style, IBinding binding) where T : TabControl
=> style._addSetter(TabControl.TabStripPlacementProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, HorizontalAlignment value) where T : TabControl
=> style._addSetter(TabControl.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : TabControl
=> style._addSetter(TabControl.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, VerticalAlignment value) where T : TabControl
=> style._addSetter(TabControl.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : TabControl
=> style._addSetter(TabControl.VerticalContentAlignmentProperty, binding);
public static Style<T> ContentTemplate<T>(this Style<T> style, IDataTemplate value) where T : TabControl
=> style._addSetter(TabControl.ContentTemplateProperty, value);
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : TabControl
=> style._addSetter(TabControl.ContentTemplateProperty, binding);
}

