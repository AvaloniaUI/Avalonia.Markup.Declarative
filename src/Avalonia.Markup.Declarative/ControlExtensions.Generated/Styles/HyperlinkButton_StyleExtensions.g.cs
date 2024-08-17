using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using HyperlinkButton = Avalonia.Controls.HyperlinkButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HyperlinkButtonExtensions
{
public static Style<T> IsVisited<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.HyperlinkButton
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, value);
public static Style<T> IsVisited<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton
=> style._addSetter(Avalonia.Controls.HyperlinkButton.IsVisitedProperty, binding);
public static Style<T> NavigateUri<T>(this Style<T> style, System.Uri value) where T : Avalonia.Controls.HyperlinkButton
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, value);
public static Style<T> NavigateUri<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.HyperlinkButton
=> style._addSetter(Avalonia.Controls.HyperlinkButton.NavigateUriProperty, binding);
}

