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
public static Style<T> LastChildFill<T>(this Style<T> style, Boolean value) where T : DockPanel
=> style._addSetter(DockPanel.LastChildFillProperty, value);
public static Style<T> LastChildFill<T>(this Style<T> style, IBinding binding) where T : DockPanel
=> style._addSetter(DockPanel.LastChildFillProperty, binding);
}

