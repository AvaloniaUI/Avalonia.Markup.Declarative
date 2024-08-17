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
using TopLevel = Avalonia.Controls.TopLevel;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevelExtensions
{
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, value);
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, value);
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, value);
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);
}

