using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ListBox = Avalonia.Controls.ListBox;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxExtensions
{
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.ListBox
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty, value);
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ListBox
=> style._addSetter(Avalonia.Controls.ListBox.SelectionModeProperty, binding);
}

