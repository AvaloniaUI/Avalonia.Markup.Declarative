using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevelExtensions
{
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IReadOnlyList<WindowTransparencyLevel> value) where T : TopLevel
=> style._addSetter(TopLevel.TransparencyLevelHintProperty, value);
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : TopLevel
=> style._addSetter(TopLevel.TransparencyLevelHintProperty, binding);
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBrush value) where T : TopLevel
=> style._addSetter(TopLevel.TransparencyBackgroundFallbackProperty, value);
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : TopLevel
=> style._addSetter(TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, ThemeVariant value) where T : TopLevel
=> style._addSetter(TopLevel.RequestedThemeVariantProperty, value);
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : TopLevel
=> style._addSetter(TopLevel.RequestedThemeVariantProperty, binding);
}

