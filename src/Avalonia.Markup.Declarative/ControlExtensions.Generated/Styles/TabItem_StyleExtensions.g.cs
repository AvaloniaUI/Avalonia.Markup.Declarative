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
public static Style<TabItem> IsSelected(this Style<TabItem> style, Boolean value)
=> style._addSetter(TabItem.IsSelectedProperty, value);
public static Style<TabItem> IsSelected(this Style<TabItem> style, IBinding binding)
=> style._addSetter(TabItem.IsSelectedProperty, binding);
}

