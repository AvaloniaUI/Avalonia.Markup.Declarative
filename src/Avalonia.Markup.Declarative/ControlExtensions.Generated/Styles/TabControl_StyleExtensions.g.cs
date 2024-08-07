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
public static Style<TabControl> TabStripPlacement(this Style<TabControl> style, Avalonia.Controls.Dock value)
=> style._addSetter(TabControl.TabStripPlacementProperty, value);
public static Style<TabControl> TabStripPlacement(this Style<TabControl> style, IBinding binding)
=> style._addSetter(TabControl.TabStripPlacementProperty, binding);
public static Style<TabControl> HorizontalContentAlignment(this Style<TabControl> style, HorizontalAlignment value)
=> style._addSetter(TabControl.HorizontalContentAlignmentProperty, value);
public static Style<TabControl> HorizontalContentAlignment(this Style<TabControl> style, IBinding binding)
=> style._addSetter(TabControl.HorizontalContentAlignmentProperty, binding);
public static Style<TabControl> VerticalContentAlignment(this Style<TabControl> style, VerticalAlignment value)
=> style._addSetter(TabControl.VerticalContentAlignmentProperty, value);
public static Style<TabControl> VerticalContentAlignment(this Style<TabControl> style, IBinding binding)
=> style._addSetter(TabControl.VerticalContentAlignmentProperty, binding);
public static Style<TabControl> ContentTemplate(this Style<TabControl> style, IDataTemplate value)
=> style._addSetter(TabControl.ContentTemplateProperty, value);
public static Style<TabControl> ContentTemplate(this Style<TabControl> style, IBinding binding)
=> style._addSetter(TabControl.ContentTemplateProperty, binding);
}

