using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ReversibleStackPanelExtensions
{
public static Style<ReversibleStackPanel> ReverseOrder(this Style<ReversibleStackPanel> style, Boolean value)
=> style._addSetter(ReversibleStackPanel.ReverseOrderProperty, value);
public static Style<ReversibleStackPanel> ReverseOrder(this Style<ReversibleStackPanel> style, IBinding binding)
=> style._addSetter(ReversibleStackPanel.ReverseOrderProperty, binding);
}

