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
public static Style<T> IsSelected<T>(this Style<T> style, Boolean value) where T : ListBoxItem
=> style._addSetter(ListBoxItem.IsSelectedProperty, value);
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : ListBoxItem
=> style._addSetter(ListBoxItem.IsSelectedProperty, binding);
}

