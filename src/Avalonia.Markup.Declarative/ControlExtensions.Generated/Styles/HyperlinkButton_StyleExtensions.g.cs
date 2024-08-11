using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HyperlinkButtonExtensions
{
public static Style<T> IsVisited<T>(this Style<T> style, Boolean value) where T : HyperlinkButton
=> style._addSetter(HyperlinkButton.IsVisitedProperty, value);
public static Style<T> IsVisited<T>(this Style<T> style, IBinding binding) where T : HyperlinkButton
=> style._addSetter(HyperlinkButton.IsVisitedProperty, binding);
public static Style<T> NavigateUri<T>(this Style<T> style, Uri value) where T : HyperlinkButton
=> style._addSetter(HyperlinkButton.NavigateUriProperty, value);
public static Style<T> NavigateUri<T>(this Style<T> style, IBinding binding) where T : HyperlinkButton
=> style._addSetter(HyperlinkButton.NavigateUriProperty, binding);
}

