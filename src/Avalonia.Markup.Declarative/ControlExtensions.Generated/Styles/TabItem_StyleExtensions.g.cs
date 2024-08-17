using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TabItem = Avalonia.Controls.TabItem;

namespace Avalonia.Markup.Declarative;
public static partial class TabItemExtensions
{
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TabItem
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty, value);
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabItem
=> style._addSetter(Avalonia.Controls.TabItem.IsSelectedProperty, binding);
}

