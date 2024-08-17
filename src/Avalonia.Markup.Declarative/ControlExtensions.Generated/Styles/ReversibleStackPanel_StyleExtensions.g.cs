using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ReversibleStackPanel = Avalonia.Controls.ReversibleStackPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ReversibleStackPanelExtensions
{
public static Style<T> ReverseOrder<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, value);
public static Style<T> ReverseOrder<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);
}

