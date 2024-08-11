using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TabItemExtensions
{
public static Style<T> IsSelected<T>(this Style<T> style, Boolean value) where T : TabItem
=> style._addSetter(TabItem.IsSelectedProperty, value);
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : TabItem
=> style._addSetter(TabItem.IsSelectedProperty, binding);
}

