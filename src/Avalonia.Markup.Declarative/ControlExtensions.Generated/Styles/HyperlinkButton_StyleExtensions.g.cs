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
public static Style<HyperlinkButton> IsVisited(this Style<HyperlinkButton> style, Boolean value)
=> style._addSetter(HyperlinkButton.IsVisitedProperty, value);
public static Style<HyperlinkButton> IsVisited(this Style<HyperlinkButton> style, IBinding binding)
=> style._addSetter(HyperlinkButton.IsVisitedProperty, binding);
public static Style<HyperlinkButton> NavigateUri(this Style<HyperlinkButton> style, Uri value)
=> style._addSetter(HyperlinkButton.NavigateUriProperty, value);
public static Style<HyperlinkButton> NavigateUri(this Style<HyperlinkButton> style, IBinding binding)
=> style._addSetter(HyperlinkButton.NavigateUriProperty, binding);
}

