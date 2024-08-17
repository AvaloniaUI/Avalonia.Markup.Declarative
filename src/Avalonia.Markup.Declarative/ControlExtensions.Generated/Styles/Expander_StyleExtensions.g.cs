using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Expander = Avalonia.Controls.Expander;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExpanderExtensions
{
public static Style<T> ContentTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, value);
public static Style<T> ContentTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, binding);
public static Style<T> ExpandDirection<T>(this Style<T> style, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, value);
public static Style<T> ExpandDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Expander
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, value);
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, binding);
}

