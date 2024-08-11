using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExpanderExtensions
{
public static Style<T> ContentTransition<T>(this Style<T> style, IPageTransition value) where T : Expander
=> style._addSetter(Expander.ContentTransitionProperty, value);
public static Style<T> ContentTransition<T>(this Style<T> style, IBinding binding) where T : Expander
=> style._addSetter(Expander.ContentTransitionProperty, binding);
public static Style<T> ExpandDirection<T>(this Style<T> style, ExpandDirection value) where T : Expander
=> style._addSetter(Expander.ExpandDirectionProperty, value);
public static Style<T> ExpandDirection<T>(this Style<T> style, IBinding binding) where T : Expander
=> style._addSetter(Expander.ExpandDirectionProperty, binding);
public static Style<T> IsExpanded<T>(this Style<T> style, Boolean value) where T : Expander
=> style._addSetter(Expander.IsExpandedProperty, value);
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Expander
=> style._addSetter(Expander.IsExpandedProperty, binding);
}

