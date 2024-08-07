using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxItemExtensions
{
public static Style<ListBoxItem> IsSelected(this Style<ListBoxItem> style, Boolean value)
=> style._addSetter(ListBoxItem.IsSelectedProperty, value);
public static Style<ListBoxItem> IsSelected(this Style<ListBoxItem> style, IBinding binding)
=> style._addSetter(ListBoxItem.IsSelectedProperty, binding);
}

