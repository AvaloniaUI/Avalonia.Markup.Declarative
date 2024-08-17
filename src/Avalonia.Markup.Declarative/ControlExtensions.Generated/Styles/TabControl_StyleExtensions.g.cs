using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TabControl = Avalonia.Controls.TabControl;

namespace Avalonia.Markup.Declarative;
public static partial class TabControlExtensions
{
public static Style<T> TabStripPlacement<T>(this Style<T> style, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty, value);
public static Style<T> TabStripPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, value);
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, value);
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty, value);
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);
}

