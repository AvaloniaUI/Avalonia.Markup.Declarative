using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DockPanel = Avalonia.Controls.DockPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DockPanelExtensions
{
public static Style<T> LastChildFill<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DockPanel
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty, value);
public static Style<T> LastChildFill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DockPanel
=> style._addSetter(Avalonia.Controls.DockPanel.LastChildFillProperty, binding);
}

