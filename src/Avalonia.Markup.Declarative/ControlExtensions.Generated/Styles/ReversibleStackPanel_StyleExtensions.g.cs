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
public static Style<T> ReverseOrder<T>(this Style<T> style, Boolean value) where T : ReversibleStackPanel
=> style._addSetter(ReversibleStackPanel.ReverseOrderProperty, value);
public static Style<T> ReverseOrder<T>(this Style<T> style, IBinding binding) where T : ReversibleStackPanel
=> style._addSetter(ReversibleStackPanel.ReverseOrderProperty, binding);
}

