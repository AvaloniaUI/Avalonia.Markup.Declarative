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
public static Style<TopLevel> TransparencyLevelHint(this Style<TopLevel> style, IReadOnlyList<WindowTransparencyLevel> value)
=> style._addSetter(TopLevel.TransparencyLevelHintProperty, value);
public static Style<TopLevel> TransparencyLevelHint(this Style<TopLevel> style, IBinding binding)
=> style._addSetter(TopLevel.TransparencyLevelHintProperty, binding);
public static Style<TopLevel> TransparencyBackgroundFallback(this Style<TopLevel> style, IBrush value)
=> style._addSetter(TopLevel.TransparencyBackgroundFallbackProperty, value);
public static Style<TopLevel> TransparencyBackgroundFallback(this Style<TopLevel> style, IBinding binding)
=> style._addSetter(TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static Style<TopLevel> RequestedThemeVariant(this Style<TopLevel> style, ThemeVariant value)
=> style._addSetter(TopLevel.RequestedThemeVariantProperty, value);
public static Style<TopLevel> RequestedThemeVariant(this Style<TopLevel> style, IBinding binding)
=> style._addSetter(TopLevel.RequestedThemeVariantProperty, binding);
}

