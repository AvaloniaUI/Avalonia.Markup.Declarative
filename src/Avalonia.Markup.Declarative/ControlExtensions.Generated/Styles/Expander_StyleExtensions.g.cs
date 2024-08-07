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
public static Style<Expander> ContentTransition(this Style<Expander> style, IPageTransition value)
=> style._addSetter(Expander.ContentTransitionProperty, value);
public static Style<Expander> ContentTransition(this Style<Expander> style, IBinding binding)
=> style._addSetter(Expander.ContentTransitionProperty, binding);
public static Style<Expander> ExpandDirection(this Style<Expander> style, ExpandDirection value)
=> style._addSetter(Expander.ExpandDirectionProperty, value);
public static Style<Expander> ExpandDirection(this Style<Expander> style, IBinding binding)
=> style._addSetter(Expander.ExpandDirectionProperty, binding);
public static Style<Expander> IsExpanded(this Style<Expander> style, Boolean value)
=> style._addSetter(Expander.IsExpandedProperty, value);
public static Style<Expander> IsExpanded(this Style<Expander> style, IBinding binding)
=> style._addSetter(Expander.IsExpandedProperty, binding);
}

