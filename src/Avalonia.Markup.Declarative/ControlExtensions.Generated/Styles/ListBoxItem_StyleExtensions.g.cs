using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ListBoxItem = Avalonia.Controls.ListBoxItem;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxItemExtensions
{
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ListBoxItem
=> style._addSetter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, value);
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ListBoxItem
=> style._addSetter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, binding);
}

