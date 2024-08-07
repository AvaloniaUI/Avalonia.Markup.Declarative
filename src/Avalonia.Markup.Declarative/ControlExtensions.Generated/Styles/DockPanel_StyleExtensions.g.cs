using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DockPanelExtensions
{
public static Style<DockPanel> LastChildFill(this Style<DockPanel> style, Boolean value)
=> style._addSetter(DockPanel.LastChildFillProperty, value);
public static Style<DockPanel> LastChildFill(this Style<DockPanel> style, IBinding binding)
=> style._addSetter(DockPanel.LastChildFillProperty, binding);
}

